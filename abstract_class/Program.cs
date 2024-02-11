

namespace abstract_class
{
    abstract class  animal {
        public  string name { get; set; }
        public int sum { get; set; }
      
        public bool bietbay { get; set; }
        public abstract int sochan();
        public abstract bool fly();
        public virtual void xuat()
        {
            Console.WriteLine("name :{0} , sum :{1} ,so chan:{2} , khả năng bay :{3}",name,sum,sochan(),fly()? "biết bay ":"ko biết bay");
        }

        }
    class bird:animal
    {
        public override int sochan()
        {
            return 2;
        }
        public override bool fly()
        {
           return true;
        }
        public override void xuat()
        {
            base.xuat();
        }
    }
    class lion : animal
    {
        public override int sochan()
        {
            return 4;
        }
        public override bool fly()
        {
            return false;
        }
        public override void xuat()
        {
            base.xuat();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            lion lion = new lion();
            lion.name = "lion";
            lion.sum = 5;
            lion.xuat();
           
            Console.ReadLine();
        }
    }
}
