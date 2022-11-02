﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Start() => "Engine start";

        public string Stop() => "Breaaak!";

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{Color} {GetType().Name} {Model}");
            stringBuilder.AppendLine(Start());
            stringBuilder.AppendLine(Stop());

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
