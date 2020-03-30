# FetchData/SQL Example

This example application shows how to query the `Odyssey API` via the `FetchData/SQL `method. This is a Visual Basic console application which is coded to run an SQL query and display its result in a message box.

This information is intended for Odyssey administrators or developers who wish to understand how to use the `Odyssey API`, and the `FetchData/SQL` method, in Visual Basic code.

# Requirements

* Windows PC with `.NET Framework 4.6.1`
* `Visual Studio 2017` or newer

# Setup

*  Download this project, then open the `FetchDataSQL.sln` file
*  Build the solution
*  Run the solution by pressing F5

# Usage

All of the code we have created exists in `Module1.vb`. In this file, there are several classes / functions. 

*  `Main()` - This is the main entry point of the application, where the logic exists. This is where you will need to define your API location, API Key, Company ID and configure your SQL Query. Depending on your query and the fields it returns, you will need to update the Message Box that displays its result.
*  `Class FetchDataSQL` - This class is designed to handle HTTP requests to the Odyssey API. This class was created so that it could be reused throughout your Visual Basic application
*  `Class FetchDataSQLRequest` - This class encapsulates all data sent to the Odyssey API when performing an SQL request
*  `Class FetchDataSQLResponse` - This class encapsulates all data returned from the Odyssey API when performing an SQL request

# About
[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](blinfo-small.png)](https://www.blinfo.com)  