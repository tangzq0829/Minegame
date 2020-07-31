using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Minegame.Core
{
    public partial class UnitEntity : LogicObject
    {
        #region VARIABLES
        private float _timeSlot = 0;
        #endregion

        #region PROPERTIES
        public float TimeSlot
        {
            get { return this._timeSlot; }
            set { this._timeSlot = value; }
        }
        public bool IsSelected { get; set; }
        public int Team { get; set; }
        public UnitData Data { get; set; }
        public float ActualSpeed
        {
            get
            {
                return Data.attributes.speed;
            }
        }

        public float ActualHealth
        {
            get
            {
                return Data.attributes.health;
            }
        }

        #endregion

        #region METHODS
        private void Awake()
        {
            _timeSlot = 0;
        }
        #endregion
    }
}
