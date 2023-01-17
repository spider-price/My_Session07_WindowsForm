namespace Sample01.LifeCycle
{
    public class TrainingClass
    {
        public TrainingClass()
        {
            Manager = new Manager();
            Students = new List<Student>();
            Teacher= new Teacher();
        }

        public Manager Manager { get; private set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}
