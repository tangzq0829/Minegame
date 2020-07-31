using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    [Serializable]
    public class UnitAttributes
    {
        public string name;

        public float health;
        public float mana;
        public float attack;
        public float defense;
        public float magicAttack;
        public float magicDefense;
        public float speed;
        public float evasion;
        public float accuracy;
        public float criticalChance;
        public float criticalDamageRate;
    }

}
