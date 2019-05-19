using UnityEngine;

namespace ScriptableObjects.Definition
{
    /// <summary>
    /// this scriptable object can have type of anything, it is completely dynamic
    /// </summary>
    [CreateAssetMenu(menuName = "MyScriptableObjects/RunTimeSet")]
    public class CounterRunTimeSet: CounterRunTimeDefinition<CounterItem>
    {
    }
}