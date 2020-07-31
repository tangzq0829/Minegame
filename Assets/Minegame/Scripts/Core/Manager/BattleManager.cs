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
        private void StartBattle()
        {
            NextTurn();
        }

        private UnitEntity _activedUnit = null;
        private void NextTurn()
        {
            if(_activedUnit != null)
            {
                _activedUnit.ReleaseTimeSlot();
            }

            var allUnits = GetAllUnits().ToList();
            allUnits = allUnits.OrderByDescending(u => u.ActualSpeed).ToList();

            var maxTimeSlot = float.MinValue;
            foreach (var unit in allUnits)
            {
                if (unit.IsAlive())
                {
                    unit.AccumulateTimeSlot();
                    if(maxTimeSlot < unit.TimeSlot)
                    {
                        maxTimeSlot = unit.TimeSlot;
                        _activedUnit = unit;
                    }
                }
            }
            this.NotifyBeginAction(_activedUnit);
            
            //if (IsPlayerController(activedUnit) && true != this.IsAutoPlay)
            //{

            //}
            //else
            //{
            //    activedUnit.AutomaticAction();
            //}


            //activedUnit.ReleaseTimeSlot();
        }
        #region Battle Extension
        public void NotifyBeginAction(UnitEntity unit)
        {
            unit.IsSelected = true;
        }
        public void NotifyEndAction(UnitEntity unit)
        {
            unit.ReleaseTimeSlot();
            this.NextTurn();
        }

        private UnitEntity[] GetAllUnits()
        {
            var allUnits = new List<UnitEntity>();
            allUnits.AddRange(playerFormation.UnitGroup);
            allUnits.AddRange(enemyForamtion.UnitGroup);
            return allUnits.ToArray();
        }
        private bool IsPlayerController(UnitEntity unit)
        {
            return unit.Team == this.playerFormation.team;
        }
        private UnitEntity[] GetEnemies(UnitEntity unit)
        {
            if(unit.Team == this.playerFormation.team)
            {
                return this.enemyForamtion.UnitGroup;
            }
            else
            {
                return this.playerFormation.UnitGroup;
            }
        }
        private UnitEntity[] GetAllies(UnitEntity unit)
        {
            if (unit.Team == this.playerFormation.team)
            {
                return this.playerFormation.UnitGroup;
            }
            else
            {
                return this.enemyForamtion.UnitGroup;
            }
        }
        #endregion

        private void Start()
        {
            this.playerFormation.SpwanUnits();
            this.enemyForamtion.SpwanUnits();

            this.StartBattle();
        }
        #endregion
    }
}
