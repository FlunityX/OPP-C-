namespace rút_ngắn_constructor
{
    /* public class User
     {
         /* cách 1 :
         public int age { get; set;}
         public string name { get; set;}
         public User(string  name, int age)
         {
             this.age= age;
             this.name = name;
         }
        }
     cách 2:*/
    public class User(string name , string lastName)
    {
        public string FirstName { get; } = name;
        public string LastName { get; } = lastName;
        public void print()
        {
            Console.WriteLine($"My Firts Name is {name} and Last name is  {LastName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nguyen","manh");
            user.print();
            Console.ReadLine();

        }
    }
}
