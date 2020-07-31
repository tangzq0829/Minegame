using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    public partial class UnitLogic
    {
		public bool AccumulateTimeSlot()
        {
            var formulaMng = GameManagers.Get<FormulaManager>();
            this.m_timeSlot = formulaMng.AccumulateTimeSlot(this.m_timeSlot, this.ActualSpeed);
            return formulaMng.IsFullTimeSlot(this.m_timeSlot);
        }

		public void ReleaseTimeSlot()
        {
            var formulaMng = GameManagers.Get<FormulaManager>();
            this.m_timeSlot = formulaMng.ReleaseTimeSlot(this.m_timeSlot);
        }


		public bool IsAlive()
        {
            return this.ActualHealth > 0;
        }

        public bool IsPlayerControlled()
        {
            return this.isPlayerControlled;
        }
    }
}
