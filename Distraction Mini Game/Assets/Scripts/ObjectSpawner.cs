using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;         // An array of spawn points positions
    public GameObject[] cubePrefab;         // An array of cube prefabs
    public float spawnRate = 3.5f;

    private void Awake()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true) // Loop forever
        {
            yield return new WaitForSeconds(spawnRate);

            int randomIndex = Random.Range(0, spawnPoints.Length);
            // Loop through the length of the spawnpoint array - e.g 4 times
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                int randomColour = Random.Range(0, spawnPoints.Length);

                if (randomIndex != i)
                {
                    // Spawn the prefab[i] at position[i] with no rotation
                    Instantiate(cubePrefab[randomColour], spawnPoints[i].position, transform.rotation);
                }

            }
        }
    }
}
