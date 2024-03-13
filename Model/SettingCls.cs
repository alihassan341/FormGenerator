namespace FormGenerator.Model
{
    public class Panel
    {
        public string? id { get; set; }
        public string? title{ get; set; }
        public string? content { get; set; }
        public string? placeholder { get; set; }
        public int? width { get; set; }
        public bool? trim { get; set; }
        public bool? required { get; set; }
        public bool? disabled { get; set; }
        public bool? clearable { get; set; }

    }
}
