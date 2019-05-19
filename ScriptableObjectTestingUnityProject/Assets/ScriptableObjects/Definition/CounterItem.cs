using UnityEngine;

namespace ScriptableObjects.Definition
{
    // a helper class that give us a hand to count some cubes. It accept an scriptable object.
    public class CounterItem : MonoBehaviour
    {
        public CounterRunTimeSet runTimeSet;

        // OnEnable it will add of them to a list, so we can count them in our CounterRunTimeSet
        private void OnEnable()
        {
            runTimeSet.Add(this);
        }

        private void OnDisable()
        {
            runTimeSet.Remove(this);
        }
    }
}