/*
  Main class for running the spreadsheet server through socket connections.
 */
#include <iostream>
#include <boost/asio.hpp>

using namespace boost::asio;

std::vector<tcp::socket> clients;
std::vector<spreadsheet> spreadsheets;

int main()
{
  boost::asio::io_service io_service;
  Server server(io_service);

  while (true)
    {
      for(spreadsheet& s: spreadsheets)
	{
	  //check if an update is needed and comply
	}
    }
  return 0;
}
