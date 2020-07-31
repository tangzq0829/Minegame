using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minegame.Core
{
    public partial class GameManagers : BehaviourBase
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}
