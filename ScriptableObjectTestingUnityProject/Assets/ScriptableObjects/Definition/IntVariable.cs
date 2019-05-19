using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/IntVar")]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR
        public string developerDescription = "";
#endif
        public int value;

        public void SetValue(int valueParam)
        {
            value = valueParam;
        }

        public void SetValue(IntVariable valueParam)
        {
            value = valueParam.value;
        }

        public void ApplyChange(int amount)
        {
            value += amount;
        }

        public void ApplyChange(IntVariable amount)
        {
            value += amount.value;
        }
    }
}