using System;
using System.Collections.Generic;
using System.Text;

namespace TappancsHotel.Models
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name, "Macska", "🐱") { }

        public override string Speak()
        {
            return "Miau! Kutya vagyok";
        }

        public override string Play()
        {
            //A macska kevesebbet játszik, de kevésbé fárad el
            ChangeStats(-8, 20, -10);
            return $"{Name} a fonalgombolyaggal játszott!! + 20 jókedv";
        }
    }
}
