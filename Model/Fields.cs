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

}
