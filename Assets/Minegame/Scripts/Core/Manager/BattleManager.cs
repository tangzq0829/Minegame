using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    public class BattleManager : ManagerBase
    {
        #region VARIABLES
        public Formation playerFormation;
        public Formation enemyForamtion;
        #endregion

        #region PROPERTIES
        public bool IsAutoPlay { get; set; }
        #endregion

        #region METHODS
        private void StartTurn()
        {
           
        }

        private void NextTurn()
        {
            var allUnits = new List<UnitLogic>();
            allUnits.AddRange(playerFormation.UnitGroup);
            allUnits.AddRange(enemyForamtion.UnitGroup);
            allUnits = allUnits.OrderByDescending(u => u.ActualSpeed).ToList();

            UnitLogic activedUnit = null;
            foreach (var unit in allUnits)
            {
                if (unit.IsAlive() && unit.AccumulateTimeSlot())
                {
                    activedUnit = unit;
                    break;
                }
            }

            if (activedUnit.IsPlayerControlled() && true != this.IsAutoPlay)
            {

            }
            else
            {
                activedUnit.AutomaticAction();
            }

            activedUnit.ReleaseTimeSlot();
        }

        private void Awake()
        {
            
        }

        private void Start()
        {
            this.playerFormation.Spwan();
            this.enemyForamtion.Spwan();
        }
        #endregion
    }
}
