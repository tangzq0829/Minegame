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
        public int team;

        public Transform[] containers;

        public UnitEntity[] UnitGroup
        {
            get
            {
                return this.m_listOfUnits.ToArray();
            }
        }

        public UnitData target;

        private List<UnitEntity> m_listOfUnits;

        private void Awake()
        {
            m_listOfUnits = new List<UnitEntity>();
        }

        public void SpwanUnits()
        {
            foreach (var pos in this.containers)
            {
                var unit = UnitExtension.CreateUnit(this.target);
                unit.Team = this.team;
                unit.transform.SetParent(pos);
                unit.transform.localPosition = Vector3.zero;
                unit.transform.localEulerAngles = Vector3.zero;
                m_listOfUnits.Add(unit);
            }
        }

    }
}
