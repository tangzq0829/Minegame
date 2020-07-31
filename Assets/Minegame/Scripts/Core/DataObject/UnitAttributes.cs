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

        public UnitAttributes Clone()
        {
            var clone = new UnitAttributes();
            clone.name = this.name;
            clone.health = this.health;
            clone.mana = this.mana;
            clone.attack = this.attack;
            clone.defense = this.defense;
            clone.magicAttack = this.magicAttack;
            clone.magicDefense = this.magicDefense;
            clone.speed = this.speed;
            clone.evasion = this.evasion;
            clone.accuracy = this.accuracy;
            clone.criticalChance = this.criticalChance;
            clone.criticalDamageRate = this.criticalDamageRate;
            return clone;
        }
    }

}
