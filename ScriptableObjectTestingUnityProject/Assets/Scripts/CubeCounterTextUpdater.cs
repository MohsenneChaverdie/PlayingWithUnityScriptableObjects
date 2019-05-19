using ScriptableObjects.Definition;
using TMPro;
using UnityEngine;

public class CubeCounterTextUpdater : MonoBehaviour
{
    [SerializeField] private CounterRunTimeSet runTimeSet;

    private TextMeshProUGUI _textToUpdate;
    private int _counterCache;

    private void Awake()
    {
        _textToUpdate = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (_counterCache == runTimeSet.items.Count) return;
        _textToUpdate.text = runTimeSet.items.Count.ToString();
        _counterCache = runTimeSet.items.Count;
    }
}