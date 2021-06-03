using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BeeSimulator
{
    [Serializable]
    class Hive
    {
        const int InitialBees = 6;
        const double InitialHoney = 3.2;
        const double MaximumHoney = 15.00;
        const double NectarHoneyRatio = 0.25;
        const int MaximumBees = 8;
        const double MinimumHoneyForCreationBees = 4.00;
        public double Honey { get; private set; }

        private Dictionary<string, Point> locations;

        private int beeCount = 0;

        [NonSerialized]
        public BeeMessage MessageSender;

        private World world;
        public Hive(World world, BeeMessage MessageSender)
        {
            this.MessageSender = MessageSender;
            beeCount = InitialBees;
            Honey = InitialHoney;
            InitializeLocations();
            Random random = new Random();
            this.world = world;
            for (int i = 0; i < InitialBees; i++)
            {
                AddBee(random, world);
            }
        }

        void InitializeLocations()
        {
            locations = new Dictionary<string, Point>();
            locations.Add("Вход", new Point(600, 200));
            locations.Add("Питомник", new Point(124, 293));
            locations.Add("Фабрика", new Point(244, 145));
            locations.Add("Выход", new Point(256, 356));
        }
        public bool AddHoney(double Nectar)
        {
            double nectar = Nectar * NectarHoneyRatio;
            if (nectar + Honey > MaximumHoney)
            {
                return false;
            }
            Honey += nectar;
            return true;
        }
        
        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
            {
                return false;
            }
            Honey -= amount;
            return true;
        }
        void AddBee(Random random, World world)
        {
            
            beeCount++;
            int r1 = random.Next(100) - 50;
            int r2 = random.Next(100) - 50;
            Point startPoint = new Point(locations["Питомник"].X + r1, locations["Питомник"].Y + r2);
            Bee newBee = new Bee(beeCount, startPoint,this,world);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);

        }
        public void Go(Random random)
        {
            if (Honey > MinimumHoneyForCreationBees && random.Next(10) == 1 && world.Bees.Count()< MaximumBees)
            {
                AddBee(random, world);
            }
        }
        public Point GetLocation(string location)
        {
           if (locations.ContainsKey(location))
            {
                Point point = new Point();
                point = locations[location];
                return point;
            }
            else
            {
                throw new ArgumentException("Неизвестная локация улья: " + location);
            }
        }

    }
}
