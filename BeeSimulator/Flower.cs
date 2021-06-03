using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BeeSimulator
{
    [Serializable]
    class Flower
    {
        const int LifeSpanMin = 15000;
        const int LifeSpanMax = 30000;
        const double InitialNectar = 1.5;
        const double MaxNectar = 5.0;
        const double NectarAddedPerTurn = 0.01;
        const double NectarGatheredPerTurn = 0.03;
      
       public Point Location { get; private set; }
       public int Age { get; private set; }// возраст
       public bool Alive { get; private set; }// живой или нет
       public double Nectar { get; private set; }// кол-во нектара
       public double NectarHarvested { get; set; }// сколько нектара собрали
       private int lifespan { get; set; }// продолжительность жизни

       public Flower (Point Location, Random random)
        {
            this.Location = Location;
            Age = 0;
            Alive = true;
            Nectar = InitialNectar;
            NectarHarvested = 0;
            lifespan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }
       public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
            {
                return 0;
            }
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarHarvested;
            }
        }
        
        public void Go()
        {
            if (Age == lifespan)
            {
                Alive = false;
                System.Windows.Forms.MessageBox.Show("цветочек умер");
            }
            else
            {
                Age++;
                if (Nectar  < MaxNectar)
                {
                    Nectar += NectarAddedPerTurn;
                }
                else 
                {
                    Nectar = MaxNectar;
                }
            }
        }


    }
}
