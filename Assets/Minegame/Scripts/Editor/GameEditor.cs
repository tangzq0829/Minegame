using Minegame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

namespace Minegame.Editor
{
    class EndNameEdit : EndNameEditAction
    {
        public override void Action(int instanceId, string pathName, string resourceFile)
        {
            AssetDatabase.CreateAsset(EditorUtility.InstanceIDToObject(instanceId), AssetDatabase.GenerateUniqueAssetPath(pathName));
        }
    }
    public class GameEditor
    {
        [MenuItem("Assets/Create/Minegame/Unit")]
        public static void CreateUnit()
        {
            var t = typeof(UnitData);
            var asset = ScriptableObject.CreateInstance(t);
            var filename = "U000" + ".asset";
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(asset.GetInstanceID(), ScriptableObject.CreateInstance<EndNameEdit>(), filename, AssetPreview.GetMiniThumbnail(asset), null);
        }
    }
}
