﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Engine : IEngine, IInformationAbout
    {
        private bool activityEngine;
        private readonly int maxpower;// так как мощность нельзя сменить

        public Engine(int maxpow)
        {
            this.maxpower = maxpow;
        }
        public bool ActivityEngine
        {
            get
            {
                return activityEngine;
            }
        }

        public int Maxpower
        {
            get
            {
                return maxpower;
            }
        }
        public void OnEngine()
        {
            activityEngine = true;
        }
        public void OffEngine()
        {
            activityEngine = false;
        }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это двигатель");
        }
    }
}
