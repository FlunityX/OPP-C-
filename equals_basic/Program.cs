namespace equals_basic
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override bool Equals(object? obj)
        {
            // nếu obj = null và obj khác kiểu dữ liệu của dối tg 
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            // ép kiểu object về class 
            Person otherPerson = (Person)obj;
            return Name == otherPerson.Name && Id == otherPerson.Id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "John", Id = 30 };
            Person person2 = new Person { Name = "John", Id = 30 };
            bool areEqual = person1.Equals(person2);
            Console.WriteLine("Two persons are equal: " + areEqual);
        }
    }
}
