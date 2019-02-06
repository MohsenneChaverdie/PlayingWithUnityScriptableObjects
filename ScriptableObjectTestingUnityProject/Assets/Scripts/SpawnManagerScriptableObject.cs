using UnityEngine;


/// <inheritdoc />
/// <summary>
/// this class is a ScriptableObject. You can set its values in Editor and not in Runtime. It is very good for
/// Editor scripting and usage of plugins.
/// </summary>
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}