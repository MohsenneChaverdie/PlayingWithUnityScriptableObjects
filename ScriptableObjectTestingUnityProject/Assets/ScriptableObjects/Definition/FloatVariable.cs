using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/FloatVar")]
    public class FloatVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline] public string description = "";
#endif
        public float value;

        public void SetValue(float valueParam)
        {
            value = valueParam;
        }

        public void SetValue(FloatVariable valueParam)
        {
            value = valueParam.value;
        }

        public void ApplyChange(float amount)
        {
            value += amount;
        }

        public void ApplyChange(FloatVariable amount)
        {
            value += amount.value;
        }
    }
}