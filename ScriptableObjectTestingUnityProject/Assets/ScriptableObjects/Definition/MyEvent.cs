using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Definition
{
    [CreateAssetMenu(menuName = "MyScriptableObjects/MyEvent")]
    public class MyEvent: ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline] public string description = "";
#endif
        
        private readonly List<MyEventListener> _eventListeners = new List<MyEventListener>();

        public void Raise()
        {
            for (var i = _eventListeners.Count - 1; i >= 0; i--)
            {
                _eventListeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(MyEventListener listener)
        {
            if (!_eventListeners.Contains(listener))
            {
                _eventListeners.Add(listener);
            }
        }
        
        public void UnregisterListener(MyEventListener listener)
        {
            if (_eventListeners.Contains(listener))
            {
                _eventListeners.Remove(listener);
            }
        }
    }
}