using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    #region Manager Of Managers
    public partial class GameManagers
    {
        public static T Get<T>() where T : ManagerBase
        {
            ManagerBase manager = null;
            m_managerMap.TryGetValue(typeof(T), out manager);
            return manager as T;
        }

        #region INTERNALS
        internal static void Register<T>(T manager) where T : ManagerBase
        {
            m_managerMap[manager.GetType()] = manager;
        }
        private static Dictionary<Type, ManagerBase> m_managerMap = new Dictionary<Type, ManagerBase>();
        #endregion
    }
    #endregion
}
