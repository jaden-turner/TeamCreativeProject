using System;
using System.Text;
using System.Text.RegularExpressions;
using NetworkUtil;
using Newtonsoft.Json;

namespace Controller
{
    /// <summary>
    /// Mediates the passing of information between the GUI and the spreadsheet 
    /// server. 
    /// </summary>
    public class SpreadsheetController
    {
        // Controller events that the view can subscribe to
        public delegate void UpdateFromServer();
        public event UpdateFromServer Update;
        public delegate void ConnectedHandler(string[] ssNames);
        public event ConnectedHandler Connected;
        public delegate void ErrorHandler(string err);
        public event ErrorHandler Error;

        // private variables
        private String userName;
        private StringBuilder jsonInfo;

        // state representing the connection to the server
        SocketState theServer = null;

        /// <summary>
        /// Atttemps to connect to a server from a given address.
        /// </summary>
        /// <param name="address">Address of the server to connect to </param>
        /// <param name="name">The user's input name</param>
        public void Connect(string address, string name)
        {
            // save the name of the client connecting
            userName = name;

            // Attempt to connect to the server
            Networking.ConnectToServer(OnConnect, address, 1100);
        }

        /// <summary>
        /// Callback for the connect method
        /// </summary>
        /// <param name="state"></param>
        private void OnConnect(SocketState state)
        {
            if (state.ErrorOccured)
            {
                Error("Error connecting to server");
                state.OnNetworkAction = (SocketState) => { };
                return;
            }
            else
            {
                // set our server to this new connection
                theServer = state;

                // tell the server who we are
                Networking.Send(theServer.TheSocket, this.userName + "\n");

                // assign the network action event to our recieve data event
                state.OnNetworkAction = receiveStartUpData;

                // start receiving start up data
                jsonInfo = new StringBuilder();
                Networking.GetData(state);
            }


        }

        /// <summary>
        /// Callback for the OnConnect method
        /// Recieves initial data about spreadsheet names in the server
        /// </summary>
        /// <param name="state"></param>
        private void receiveStartUpData(SocketState state)
        {
            if (state.ErrorOccured)
            {
                Error("Lost connection to server");
                return;
            }

            // get the Json information
            jsonInfo.Append(state.GetData());

            // Check if all spreadsheet name data has been gathered
            if (jsonInfo.ToString().Contains("\n\n"))
            {
                // split it into actual messages
                // send the spreadsheet names to the GUI
                Connected(Regex.Split(jsonInfo.ToString(), @"(?<=[\n])"));
            }
            // Continue gathering startup data
            else
            {
                Networking.GetData(state);
            }
        }

        /// <summary>
        /// Attepts to access a specifed spreadsheet from the server.
        /// </summary>
        /// <param name="ssName">Name of the selected spreadsheet</param>
        public void selectSpreadsheet(string ssName)
        {
            if (theServer == null)
            {
                Error("Must have connection to server to select spreadsheets. Make call to Connect first.");
                return;
            }
            SocketState state = theServer;
            state.OnNetworkAction = receiveUpdate;

            // Send the selected spreadsheet name
            Networking.Send(state.TheSocket, ssName + "\n");
        }

        /// <summary>
        /// Recieves data from the server
        /// </summary>
        /// <param name="state">The SocketState containing our server</param>
        private void receiveUpdate(SocketState state)
        {
        }
    }
}
