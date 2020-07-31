using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Minegame.Core
{
    public partial class UnitLogic : LogicObject
    {
        #region VARIABLES
        private float m_timeSlot;


        [HideInInspector]
        public bool isPlayerControlled;

        [HideInInspector]
        public UnitData data;
        #endregion

        #region PROPERTIES
        public float ActualSpeed
        {
            get
            {
                return this.data.attributes.speed;
            }
        }

        public float ActualHealth
        {
            get
            {
                return this.data.attributes.health;
            }
        }

        #endregion

        #region METHODS
        private void Awake()
        {
            this.m_timeSlot = 0;
        }
        #endregion
    }
}
