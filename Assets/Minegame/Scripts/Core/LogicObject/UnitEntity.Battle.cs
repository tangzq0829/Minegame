using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    public partial class UnitEntity
    {


		public void AccumulateTimeSlot()
        {
            var formulaMng = GameManagers.Get<FormulaManager>();
            this.TimeSlot = formulaMng.AccumulateTimeSlot(this.TimeSlot, this.ActualSpeed);
        }

		public void ReleaseTimeSlot()
        {
            var formulaMng = GameManagers.Get<FormulaManager>();
            this.TimeSlot = formulaMng.ReleaseTimeSlot(this.TimeSlot);
        }


		public bool IsAlive()
        {
            return this.ActualHealth > 0;
        }

    }
}
