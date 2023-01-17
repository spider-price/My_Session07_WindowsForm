namespace Sample01.FrameWork
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => $" first name({FirstName}),last name({LastName})";
    }
}
