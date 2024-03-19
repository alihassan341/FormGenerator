namespace FormGenerator.Model
{
    public class Panel
    {
        public string? id { get; set; }
        public string? title{ get; set; }
        public string? content { get; set; }
        public string PC { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string placeholder { get; set; } = string.Empty;
        public int? width { get; set; }
        public string defaultValue { get; set; } = string.Empty;
        public bool isshowlable { get; set; } = false;
        public bool showpassword { get; set; } = false;
        public int labelWidth { get; set; } = 0;
        public bool trim { get; set; } = false;
        public bool required { get; set; } = false;
        public bool disabled { get; set; } = false;
        public bool clearable { get; set; } = false;

    }
}
