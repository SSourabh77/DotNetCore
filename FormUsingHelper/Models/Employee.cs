namespace FormUsingHelper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public string Degination { get; set; }

        public string Married { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
