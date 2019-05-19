using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjects.Definition
{
    public class MyEventListener : MonoBehaviour
    {
        // event to register with
        public MyEvent Event;

        // response to invoke when event is raised
        // it will be filled in editor
        public UnityEvent response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            response.Invoke();
        }
    }
}