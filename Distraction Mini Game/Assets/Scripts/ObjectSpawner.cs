using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
	public Transform[] spawnPoints;
	public GameObject[] cubePrefab;
	public float spawnRate = 3.5f;

    private void Awake()
    {
        StartCoroutine(SpawnBlocks());
    }

    IEnumerator SpawnBlocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                Instantiate(cubePrefab[i], spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
