# FetchData/SQL Example

This example application shows how to query the OODAPI via the FetchData/SQL method. This is a WinForms graphical application that allows you to enter an SQL query into a textbox and immediately see its results.

# Requirements

* Windows PC with `.NET 4.6`
* `Visual Studio 2017` or newer

# Setup

*  Download this project, then open the `FetchDataSQL.sln` file
*  Build the solution
*  Run the solution by pressing F5

# Usage

In the interface, you'll need to specify the path to your OODAPI, such as `http://my-server/odyssey/oodapi`.

From there, you can either enter an `API Key` or a `Username` and `Password` to access your Odyssey system.

On-screen, you can now press the `Find` button. It will either login as the specified user and generate an APIKey, or it will use the specified APIKey. It will perform the SQL Query that is currently entered and show its results in a grid at the bottom of the screen.


# About
[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](blinfo-small.png)](https://www.blinfo.com)  