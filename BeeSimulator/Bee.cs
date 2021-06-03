﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BeeSimulator
{
    [Serializable]
    class Bee
    {
        const double HoneyConsumed = 0.5;
        const int MoveRate = 3;
        const double MinimumFlowerNectar = 1.5;
        const int CareerSpan = 1000;
        [NonSerialized]
        public BeeMessage MessageSender;

        public BeeState CurrentState { get; private set; }
        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }

        private Point location;
        public Point Location { get { return location; } }

        private Hive hive;
        private World world;

        private int ID;
        private Flower destinationFlower;

        public Bee(int id, Point location, Hive hive, World world)
        {
            this.ID = id;
            Age = 0;
            this.location = location;
            InsideHive = true;
            destinationFlower = null;
            NectarCollected = 0;
            CurrentState = BeeState.Idle;
            this.hive = hive;
            this.world = world;
        }

        public void Go(Random random)
        {
            Age++;
            BeeState oldState = CurrentState;
            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age> CareerSpan)
                    {
                        CurrentState = BeeState.Retired;
                    }
                    else if(world.Flowers.Count()>0 && hive.ConsumeHoney(HoneyConsumed))
                    {
                        Flower flower = world.Flowers[random.Next(world.Flowers.Count())];
                        if (flower.Nectar >=MinimumFlowerNectar && flower.Alive)
                        {
                            destinationFlower = flower;
                            CurrentState = BeeState.FlyingToFlower;
                        }
                    }
                    break;
                case BeeState.FlyingToFlower:
                    if (!world.Flowers.Contains(destinationFlower))
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }else if (InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Выход")))
                        {
                            InsideHive = false;
                            location = hive.GetLocation("Вход");
                        }
                    }else
                    {
                        if (MoveTowardsLocation(destinationFlower.Location))
                        {
                            CurrentState = BeeState.GatheringNectar;
                        }
                    }
                    break;
                case BeeState.GatheringNectar:
                    double nectar = destinationFlower.HarvestNectar();
                    if (nectar > 0)                   
                        NectarCollected += nectar;
                    else
                        CurrentState = BeeState.ReturningToHive;

                    break;
                case BeeState.ReturningToHive:
                    if (!InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Вход")))
                        {
                            InsideHive = true;
                            location = hive.GetLocation("Выход");
                        }
                    }else
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Фабрика")))
                        {
                            CurrentState = BeeState.MakingHoney;
                        }
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected<0.5 )
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }
                    else
                    {
                        if (hive.AddHoney(0.5))
                        {
                            NectarCollected -= 0.5;
                        }
                        else
                        {
                            NectarCollected = 0;
                        }
                    }
                    break;
                case BeeState.Retired:

                    break;
                default:
                    break;
            }
            if (oldState != CurrentState && MessageSender != null)
            {
                MessageSender(ID, CurrentState.ToString());
            }

        }

        private bool MoveTowardsLocation(Point destination)
        {
            if (Math.Abs(destination.X - location.X) <= MoveRate && Math.Abs(destination.Y - location.Y) <= MoveRate)
            {
                return true;
            }

            if (destination.X>location.X)
            {
                location.X += MoveRate;
            }
            else if(destination.X < location.X)
            {
                location.X -= MoveRate; 
            }

            if (destination.Y>location.Y)
            {
                location.Y += MoveRate;
            }
            else if (destination.Y < location.Y)
            {
                location.Y -= MoveRate;
            }

            return false;
        }

       
    }
}
