using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class ColorCal : MonoBehaviour
    {
//        public ColorVariable theColor;

        public UnityEvent blueSphereDisable;
        public UnityEvent blueSphereEnable;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<ObjectColorHolder>().color.colorValueName == "MyRed")
            {
                blueSphereDisable.Invoke();
            }
            else if (other.GetComponent<ObjectColorHolder>().color.colorValueName == "MyGreen")
            {
                blueSphereEnable.Invoke();
            }
        }
    }
}