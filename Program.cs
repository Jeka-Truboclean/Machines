using System.Xml.Linq;

namespace _05._03
{
    class Program
    {
        static void Main()
        {
            Helicopter helicopter = new Helicopter(3000, 10, "Apache", "Military", 1000);
            helicopter.GetInfo();

            Console.WriteLine();

            Jet jet = new Jet(1000, 12000, "Boeing", "Passenger", 2000);
            jet.GetInfo();
        }
        public class Machine
        {
            public Machine(string name, string type, decimal patrol)
            {
                Name = name;
                Type = type;
                Patrol = patrol;
            }

            public virtual string Name { get; set; }
            public virtual string Type { get; set; }
            public virtual decimal Patrol { get; set; }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Name: {Name}, Type: {Type}, Patrol: {Patrol}");
            }
        }

        public class AirMachine : Machine
        {
            public AirMachine(decimal height, string name, string type, decimal patrol) : base(name, type, patrol)
            {
                Height = height;
            }

            public decimal Height { get; set; }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Height: {Height}");
            }
        }

        public class Carryer : Machine
        {
            public Carryer(decimal weight, string name, string type, decimal patrol) : base(name, type, patrol)
            {
                Weight = weight;
            }
            public decimal Weight { get; set; }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Weight: {Weight}");
            }
        }

        public class Helicopter : AirMachine
        {
            public Helicopter(decimal height, int size, string name, string type, decimal patrol) : base(height, name, type, patrol)
            {
                Size = size;
            }
            public int Size { get; set; }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Size: {Size}");
            }
        }

        public class Jet : AirMachine
        {
            public Jet(int speed, decimal height, string name, string type, decimal patrol) : base(height, name, type, patrol)
            {
                Speed = speed;
            }
            public int Speed { get; set; }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Speed: {Speed}");
            }
        }
    }
}
