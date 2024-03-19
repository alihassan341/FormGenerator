using System.Text.Json.Serialization;

namespace FormGenerator.Model
{
    public class InputModel
    {
        private IList<InputModel> options;

        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";
        public string? Type { get; set; } = "";
        public string? Class { get; set; } = "";
        public bool Actions { get; set; } = true;
        public string? FieldType { get; set; } = "";
        public int min { get; set; } = 0;
        public int step { get; set; } = 1;
        public int max { get; set; } = 100;       
    }

    public class JsonCls
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "input";

        [JsonPropertyName("label")]
        public string Label { get; set; } = "Cellphone";

        [JsonPropertyName("icon")]
        public string Icon { get; set; } = "cellphone";

        [JsonPropertyName("key")]
        public string Key { get; set; } = "input_KwA-nxsnczH0t3OM170V2";

        [JsonPropertyName("id")]
        public string Id { get; set; } = "KwA-nxsnczH0t3OM170V2";

        [JsonPropertyName("options")]
        public InputOptions Options { get; set; } = new InputOptions();

        [JsonPropertyName("style")]
        public InputStyle Style { get; set; } = new InputStyle();
    }

        public class InputOptions
        {
            [JsonPropertyName("clearable")]
            public bool Clearable { get; set; } = false;

        [JsonPropertyName("renderType")]
            public int RenderType { get; set; } = 4;

            [JsonPropertyName("disabled")]
            public bool Disabled { get; set; } = false;

            [JsonPropertyName("showPassword")]
            public bool ShowPassword { get; set; } = false;

            [JsonPropertyName("defaultValue")]
            public string DefaultValue { get; set; } = "";

            [JsonPropertyName("placeholder")]
            public string Placeholder { get; set; } = "Please enter";

            [JsonPropertyName("labelWidth")]
            public int LabelWidth { get; set; } = 105;

        [JsonPropertyName("isShowLabel")]
            public bool IsShowLabel { get; set; } = false;            

            [JsonPropertyName("required")]
            public bool Required { get; set; } = false;

        [JsonPropertyName("isShowTrim")]
            public bool IsShowTrim { get; set; } = false;
    }

        public class InputStyle
        {
            [JsonPropertyName("width")]
            public WidthStyle Width { get; set; } = new WidthStyle();
        }

        public class WidthStyle
    {
        [JsonPropertyName("pc")]
        public string PC { get; set; } = "50%";

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; } = "100%";
    }
    
}


