using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;         // An array of spawn points positions
    public GameObject[] cubePrefab;         // An array of cube prefabs
	public float spawnRate = 3.5f;

    private void Awake()
    {
        StartCoroutine(SpawnBlocks());
    }

    IEnumerator SpawnBlocks()
    {
        while (true) // Loop forever
        {
            yield return new WaitForSeconds(spawnRate);

            // Loop through for the length of the spawnpoint array - e.g 4 times
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                // Spawn the prefab[i] at position[i] with no rotation
                Instantiate(cubePrefab[i], spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
