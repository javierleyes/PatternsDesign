using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var genericCar = new CarBuilder("AE451ER")
                  .Build();

            var customCar = new CarBuilder("AD581AA")
                .WithNumberDoors(5)
                .WithEngine("Nafta")
                .Build(); // .Build() isn't necessary because there is an implicit operator

            Console.WriteLine("Generic car");
            Console.WriteLine(genericCar.ToString());
            Console.WriteLine();
            Console.WriteLine("Custom car");
            Console.WriteLine(customCar.ToString());
        }
    }

    public class Car
    {
        private readonly string _Patent, _Engine;
        private readonly int _NumberDoors;

        public Car(string patent, int doors, string engine)
        {
            _Patent = patent;
            _NumberDoors = doors;
            _Engine = engine;
        }

        public override string ToString() => $"Patent: {_Patent}, Number of doors: {_NumberDoors}, Engine: {_Engine}";
    }

    // TEST DATA BUILDER

    //internal: Access is limited to the current assembly.
    internal class CarBuilder
    {
        private string _patent { get; set; }
        private int _numberDoors { get; set; }
        private string _engine { get; set; }

        internal CarBuilder(string patent)
        {
            _patent = patent;
            _numberDoors = 4;
            _engine = "Diesel";
        }

        internal CarBuilder WithNumberDoors(int numberDoors)
        {
            _numberDoors = numberDoors;
            return this;
        }

        internal CarBuilder WithEngine(string engine)
        {
            _engine = engine;
            return this;
        }

        internal Car Build() => new Car(_patent, _numberDoors, _engine);

        public static implicit operator Car(CarBuilder builder) => builder.Build();
    }

}
