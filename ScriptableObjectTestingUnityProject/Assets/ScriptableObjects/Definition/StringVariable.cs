using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/StringVar")]
    public class StringVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline] public string description = "";
#endif
        public string value;

        public void SetValue(string valueParam)
        {
            value = valueParam;
        }
        
        public void SetValue(StringVariable valueParam)
        {
            value = valueParam.value;
        }
    }
}