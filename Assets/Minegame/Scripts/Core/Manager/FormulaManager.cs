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
        public float AccumulateTimeSlot(float value, float speed)
        {
            float result = 0f;
            result = value + speed;
            return result;
        }

        public float ReleaseTimeSlot(float value)
        {
            return 0f;
        }


        #endregion

        private void Start()
        {
            
        }
    }
}
