using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/Custom/AttackElement")]
    public class AttackElement : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline] public string description = "";
#endif
        public List<AttackElement> DefeatedElements = new List<AttackElement>();
    }
}