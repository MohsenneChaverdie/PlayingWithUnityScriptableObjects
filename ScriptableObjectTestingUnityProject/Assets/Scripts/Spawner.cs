using UnityEngine;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// the prefab in this example we want to spawn
    /// </summary>
    public GameObject entityToSpawn;
    
    /// <summary>
    /// reference to our scriptableObject, so we can read its public values.
    /// </summary>
    public SpawnManagerScriptableObject spawnManagerValues;
    
    /// <summary>
    /// to have an incremental name for each instantiated prefab
    /// </summary>
    private int _instanceNumber = 1;

    private void Start()
    {
        SpawnEntities();
    }

    /// <summary>
    /// the method is responsible for based on scriptableObject values spawn a sample prefab.
    /// </summary>
    private void SpawnEntities()
    {
        var currentSpawnPointIndex = 0;

        for (var i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i++)
        {
            var currentEntity = Instantiate(entityToSpawn,
                spawnManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            currentEntity.name = spawnManagerValues.prefabName + _instanceNumber;

            // to make sure we are using the corresponding vector position from our scriptableObject
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;

            _instanceNumber++;
        }
    }
}