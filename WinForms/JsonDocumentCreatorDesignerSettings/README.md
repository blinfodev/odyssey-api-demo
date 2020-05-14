# JSON Document Creator With Designer Settings

This is a **proprietary** helper utility that allows you to query a table using FetchData/DataView, FetchData/SQL, or FetchData/ABL. Then, based on the response, it will create a JSON document in the format that /Record/Add and /Record/Update require, in the Key/Value format, and in a special "designer settings" format.

*Example /Add JSON Document Format*

This is the format that /Record/Add requires to create a record in Odyssey. This is quite a bit different from the format that data is returned (below).

```
{
  "TableName": "sample string 1",
  "ListOfFieldValues": [
    {
      "Key": "sample string 1",
      "Value": "sample string 2"
    },
    {
      "Key": "sample string 1",
      "Value": "sample string 2"
    }
  ],
  "APIKey": "sample string 4",
  "CompanyID": "sample string 5",
  "Broker": "sample string 6"
}
```

*Example /FetchData Response Format*

```
{
    "DataSetOut": {
        "maindb_products": [
            {
                "z_internal_sequence": 1,
                "z_internal_groupid": 0,
                "z_internal_colorbg": 15461355,
                "z_internal_colorfg": 0,
                "z_internal_error": false,
                "z_internal_errorstring": "",
                "z_internal_formulafieldlist": "",
                "maindb_products_active": true,
                "maindb_products_product": "R4512"
            }
        ]
    },
    "RecordCount": 1,
    "Success": true,
    "ErrorMessage": ""
}
```

This tool will take the response, and create a JSON document from it.

# Versions

Only one version of this application has been produced. It will only run on Windows with .NET 4.6 or greater installed.

You can download the ZIP file containing `JsonDocumentCreator.exe` here [DebugBuild/JsonDocumentCreatorDesignerSettings_0.1.0.zip](./DebugBuild/JsonDocumentCreatorDesignerSettings_0.1.0.zip)

# Requirements to Build

-  Windows Operating System
-  .NET 4.6

# Target Audience

This information is intended for Odyssey administrators or developers who wish to understand how to use the `Odyssey API`.

# About

[support@blinfo.com](support@blinfo.com)  
[B&L Information Systems](https://www.blinfo.com)  
[![B&L Information Systems Logo](../../Images/blinfo-small.png)](https://www.blinfo.com)  