using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Minegame.Core
{
    public class Formation : BehaviourBase
    {
        public Transform[] containers;

        public UnitLogic[] UnitGroup
        {
            get
            {
                return this.m_listOfUnits.ToArray();
            }
        }

        public UnitData Target;

        private List<UnitLogic> m_listOfUnits;

        public void Spwan()
        {
            foreach (var pos in this.containers)
            {
                var unit = Instantiate(Target.model);
                unit.transform.SetParent(pos);
                unit.transform.localPosition = Vector3.zero;
                unit.transform.localEulerAngles = Vector3.zero;
            }
        }

    }
}
