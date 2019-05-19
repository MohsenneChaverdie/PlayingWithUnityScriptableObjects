using ScriptableObjects.Definition;
using UnityEngine;

public class DisableAllLogic : MonoBehaviour
{
    public CounterRunTimeSet counterRunTimeSet;

    public void DisableAll()
    {
        for (int i = counterRunTimeSet.items.Count - 1; i >= 0; i--)
        {
            counterRunTimeSet.items[i].gameObject.SetActive(false);
        }
    }
}