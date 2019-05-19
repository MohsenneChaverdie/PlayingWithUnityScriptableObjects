using System;
using ScriptableObjects.Definition;
using UnityEngine;

namespace Player
{
    [Serializable]
    public class MoveCal : MonoBehaviour
    {
        public StringVariable speedString;

        private void Update()
        {
            var horizontalMovement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            transform.position += Time.deltaTime * float.Parse(speedString.value) * horizontalMovement;
        }
    }
}