namespace FormGenerator.Model
{
    public class InputModel
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Value { get; set; } = "";
        public string? Type { get; set; } = "";
        public string? Class { get; set; } = "";
        public bool Actions { get; set; } = true;
        public string? FieldType { get; set; } = "";
    }

}
