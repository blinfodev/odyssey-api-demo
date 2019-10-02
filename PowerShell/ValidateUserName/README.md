# System/ValidateUsername Example

This example application shows how to query the `OODAPI` via the `System/ValidateUsername` method. This is a `PowerShell` script that you can run from a `PowerShell` terminal in Windows.

This information is intended for Odyssey administrators or developers who wish to understand how to use the `OODAPI`, and the `System/ValidateUsername` method, in `PowerShell` scripting.

# Requirements

* Windows PC with `PowerShell` version 5.1 or greater

# Setup

*  Open the file `ValidateUsername.ps1` in a text editor and place the URL to your `OODAPI` installation as well as a test Username and Password. Additionally, update the `X-API-Key` header with your `OODAPI` API Key.
*  Open a `PowerShell` terminal
*  Run `ValidateUsername.ps1` and note that it will print whether or not the supplied credentials were valid

# Details

In this example, we've made a simple script that demonstrates how to connect to the `OODAPI` with `PowerShell` using its `Invoke-RestMethod` procedure.

The notable components of this script are as follows:
*  Constructed a `JSON` body to send to the `OODAPI`
*  Added the `X-API-Key` header for authorization
*  Added the `Cache-Control` header to ensure that `PowerShell` doesn't cache repeated calls to the API
*  Called the `OODAPI` with the `Invoke-RestMethod` command by making a HTTP Request of type `POST`
*  Read its response and conditionally printed a valid or invalid message

# About
[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](Images/blinfo-small.png)](https://www.blinfo.com)  