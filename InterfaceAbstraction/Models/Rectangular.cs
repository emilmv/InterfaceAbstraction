﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstraction.Models
{
    internal class Rectangular
    {
        private double _width;
        private double _length;
        public double Width
        {
            get => _width;
            set
            {
                if (value < 0) return;
                _width = value;
            }
        }
        public double Length
        {
            get => _length;
            set
            {
                if(value < 0) return;
                _length = value;
            }
        }
        public Rectangular(double width, double length)
        {
            Width= width;
            Length= length;
        }
    }
}