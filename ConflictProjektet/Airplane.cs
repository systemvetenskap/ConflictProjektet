﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConflictProjektet
{
    public class Airplane
    {
        public int Altitude { get; }
        public int NumberOfPassengers { get; }
        public int NumberOfBags { get; }

        public string TypeName => "Flygplan";

        public double Speed => 1;
        public double Fuel => 1;
        public void Fly()
        {

        }
        public void CalculateFuelConsumption()
        {

        }
    }
}
