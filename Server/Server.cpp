/*
  Main class for running the spreadsheet server through socket connections.
 */
//socket class
#include <sys/socket.h>
#include <iostream>
#include <netinet/in.h>
#include <vector>

#define PORT 1100

int main()
{
  int server_socket;
  int opt = 1;
  std::vector<int> clients;
  
  //build address struct to specify server settings
  struct sockaddr_in address;
  address.sin_family = AF_INET;
  address.sin_addr.s_addr = INADDR_ANY;
  address.sin_port = htons(PORT);
  
  //get length of address
  int addrlen = sizeof(address);

  //create an streaming, IPv4 socket
  server_socket = socket(AF_INET, SOCK_STREAM, 0);
  //set options to remember the port and address
  setsockopt(server_socket, SOL_SOCKET, SO_REUSEPORT, &opt, sizeof(opt)); 
  setsockopt(server_socket, SOL_SOCKET, SO_REUSEADDR, &opt, sizeof(opt)); 
  bind(server_socket, (struct sockaddr *)&address, sizeof(address));

  //begin listening
  listen(server_socket, 5);
  
  //accept incoming client
  int client_socket = accept(server_socket, (struct sockaddr *)&address, (socklen_t*)&addrlen);

  clients.push_back(client_socket);

  return 0;
}
