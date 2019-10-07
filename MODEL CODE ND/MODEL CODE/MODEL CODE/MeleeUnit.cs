using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MODEL_CODE
{
    class MeleeUnit : Unit
    {
        public MeleeUnit(int x, int y, /*int health, int maxHealth, int speed, int attack, int attackRange, char symbol,*/ string faction/*, string nameUnit*/)
               : base(x, y, 7, 7, 1, 4, 1, 'M', faction, "Melee") { } //use the base keyword

        public MeleeUnit(string values) : base(values) { } //shortened due to unit class having these fused



        public override string SaveGame()
        {
            return string.Format(
                $"Melee, {x}, {y}, {health}, {maxHealth}, {speed}, {attack}, {attackRange}, " + $"{faction}, {symbol}, {nameUnit}, {IsDestroyed}");
        }
    }
}
