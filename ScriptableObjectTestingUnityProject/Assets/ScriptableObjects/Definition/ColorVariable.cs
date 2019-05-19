using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/ColorVar")]
    public class ColorVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline] public string description = "";
#endif
        public string colorValueName;
        public Color colorValue;

        public void SetColor(Color colorParam)
        {
            colorValue = colorParam;
        }
    }
}