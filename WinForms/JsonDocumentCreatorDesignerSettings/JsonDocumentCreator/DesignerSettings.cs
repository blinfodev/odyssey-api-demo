using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator
{
    public class DesignerSettings
    {
        public int DocumentType { get; set; } = 0;

        public List<DesignerSettingsDesign> Design { get; set; } = new List<DesignerSettingsDesign>();

        public DesignerSettingsComponentProperties ComponentProperties { get; set; } = new DesignerSettingsComponentProperties();

        public List<DesignerSettingsInput> Inputs { get; set; } = new List<DesignerSettingsInput>();
    }

    public class DesignerSettingsDesign
    {
        public int NodeType { get; set; } = 2;
        public string SourceType { get; set; } = "Input";
        public string InputOrColulmnName { get; set; } = "Root";
        public List<DesingerSettingsDesignChild> Children { get; set; } = new List<DesingerSettingsDesignChild>();
    }

    public class DesingerSettingsDesignChild
    {
        public string NodeName { get; set; } = String.Empty;

        /// <summary>
        /// 3 - TableName, SourceType:Static, NodeWriteSettings:Employess
        /// 3 - CompanyID, SourceType:Static, NodeWriteSettings:OCIW
        /// 3 - Broker, SourceType:Static, NodeWriteSettings:
        /// 1 - ListOfFieldValues, SourceType:None
        /// </summary>
        public int NodeType { get; set; } = 0;

        public string SourceType { get; set; } = String.Empty;

        public string NodeWriteSettings { get; set; } = String.Empty;

        public List<DesignChildChildren> Children { get; set; } = new List<DesignChildChildren>();
    }

    public class DesignChildChildren
    {
        /// <summary>
        /// NodeType:2 - SourceType:None
        /// </summary>
        public int NodeType { get; set; } = 0;

        /// <summary>
        /// None
        /// </summary>
        public string SourceType { get; set; } = String.Empty;

        public List<ChildrenChild> Children { get; set; } = new List<ChildrenChild>();
    }

    public class ChildrenChild
    {
        /// <summary>
        /// The name of the node, 'Key' for the key defintion, 'Value' for the value defintion
        /// </summary>
        public string NodeName { get; set; } = String.Empty;

        /// <summary>
        /// 3 seems to be the only one used
        /// </summary>
        public int NodeType { get; set; } = 3;

        /// <summary>
        /// Static for the static, key def
        /// Column for the dynamic, value def
        /// </summary>
        public string SourceType { get; set; } = String.Empty;

        /// <summary>
        /// Then name of the field goes here
        /// </summary>
        public string InputOrColumnName { get; set; } = String.Empty;

        public string NodeWriteSettings { get; set; } = String.Empty;
    }

    public class DesignerSettingsComponentProperties
    {
        public string LocalFilePath { get; set; } = "{\"IsExpression\":false,\"Value\":\"\"}";
        public string HttpMethod { get; set; } = "POST";
        public int BatchSize { get; set; } = 1000;
        public string IsRepeatedTextQualifier { get; set; } = "Double-Quote ( \" )";
        public string RequestBody { get; set; } = "{\"IsExpression\":false,\"Value\":\"@[MergedJson]\"}";
        public int NullMode { get; set; } = 1;
        public string ItemKey { get; set; } = "{\"IsExpression\":false,\"Value\":\"\"}";
        public string BasePath { get; set; } = "{\"IsExpression\":false,\"Value\":\"\"}";
        public int MergeMode { get; set; } = 0;
        public int Encoding { get; set; } = 1252;
        public string LocalFileEncoding { get; set; } = "Unicode (UTF-8)";
        public List<string> RequestQueryStringParameters { get; set; } = new List<string>();
        public string RequestHeaders { get; set; } = "[{\"Key\":\"X-API-KEY\",\"Value\":{\"IsExpression\":false,\"Value\":\"ed165591-6cda-eeb2-5f14-36d3bce18708\"}}]";
        public bool PrettyPrint { get; set; } = true;
        public string IsRepeatedTextDelimiter { get; set; } = "Comma ( , )";
        public string RelativePath { get; set; } = "{\"IsExpression\":false,\"Value\":\"Record/Add\"}";
    }

    public class DesignerSettingsInput
    {
        public string Name { get; set; } = "Root";

        public List<DesignerSettingsInputColumn> Columns { get; set; } = new List<DesignerSettingsInputColumn>();
    }

    public class DesignerSettingsInputColumn
    {
        /// <summary>
        /// The name of the field
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// 130 = String
        /// </summary>
        public int DataType { get; set; } = 130;

        public int Length { get; set; } = 255;

        public int Precision { get; set; } = 0;

        public int Scale { get; set; } = 0;

        public int CodePage { get; set; } = 0;
    }
}

