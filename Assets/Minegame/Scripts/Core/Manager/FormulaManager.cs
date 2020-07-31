using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    public class FormulaManager : ManagerBase
    {
        #region TimeSlot
        public float maxTimeSlot = 100f;
        public float AccumulateTimeSlot(float value, float speed)
        {
            float result = 0f;
            result = value + speed;
            return result;
        }

        public float ReleaseTimeSlot(float value)
        {
            float result = 0f;
            result = value - this.maxTimeSlot;
            if (result < 0) result = 0;
            return result;
        }

        public bool IsFullTimeSlot(float value)
        {
            return value > this.maxTimeSlot;
        }

        #endregion
    }
}
