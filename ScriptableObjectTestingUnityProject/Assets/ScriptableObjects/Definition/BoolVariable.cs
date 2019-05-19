using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/BoolVar")]
    public class BoolVariable : ScriptableObject
    {
#if UNITY_EDITOR
        public string developerDescription = "";
#endif
        public bool value;

        public void SetValue(bool valueParam)
        {
            value = valueParam;
        }

        public void SetValue(BoolVariable valueParam)
        {
            value = valueParam.value;
        }
    }
}