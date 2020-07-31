using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Minegame.Core
{
    public partial class UnitEntity
    {
        private BattleManager _battleManger;
        private BattleManager BattleManager
        {
            get
            {
                if(_battleManger ==null)
                {
                    _battleManger = GameManagers.Get<BattleManager>();
                }
                return _battleManger;
            }
        }

        private void OnGUI()
        {
            if (this.Data == null) return;
            var name = $"{this.ActualSpeed}: {this.TimeSlot}";
            var camera = Camera.main;
            //得到NPC头顶在3D世界中的坐标  
            Vector3 worldPosition = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            //根据NPC头顶的3D坐标换算成它在2D屏幕中的坐标  
            Vector2 position = camera.WorldToScreenPoint(worldPosition);
            //得到真实NPC头顶的2D坐标  
            position = new Vector2(position.x, Screen.height - position.y);
            //计算NPC名称的宽高  
            Vector2 nameSize = GUI.skin.label.CalcSize(new GUIContent(name));
            //设置显示颜色为黄色  
            GUI.color = Color.yellow;
            //绘制NPC名称  
            GUI.Label(new Rect(position.x - (nameSize.x / 2), position.y - nameSize.y, nameSize.x, nameSize.y), name);

            if(IsSelected && GUI.Button(new Rect(position.x, position.y, 100, 30), "ACTION"))
            {
                IsSelected = false;
                BattleManager.NotifyEndAction(this);
            }
        }
    }
}
