using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Minegame.Core
{
    public static class UnitExtension
    {
        public static UnitEntity CreateUnit(string assetName)
        {
            throw new NotImplementedException();
        }

        public static UnitEntity CreateUnit(UnitData clone)
        {
            var unit = UnityEngine.Object.Instantiate(clone.model);
            var data = new UnitData()
            {
                attributes = clone.attributes.Clone(),
                model = unit,
            };
            #region  Debug
            data.attributes.health = 100;
            data.attributes.speed =  UnityEngine.Random.Range(1, 100);
            #endregion
            unit.Data = data;
            return unit;
        }
    }
}
