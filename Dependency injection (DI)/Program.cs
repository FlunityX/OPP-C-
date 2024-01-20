using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection__DI_
{
    public interface IEngine
    {
        void Start();
    }
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine started");
        }
    }
    public class Car
    {
        // _engine là 1 đối tg của interface
        private readonly IEngine _engine;

        // Constructor Injection
        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Car started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo 1 đối tg interface engine 
            IEngine engine = new GasolineEngine();
            Car myCar = new Car(engine);

            // Start the car
            myCar.Start();
            Console.ReadLine();
        }
    }
}
