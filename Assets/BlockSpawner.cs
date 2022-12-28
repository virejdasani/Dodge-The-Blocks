using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject[] blocks;

	public float timeBetweenWaves = 1f;

	private float timeToSpawn = 2f;

	void Update () {

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}

	}

	void SpawnBlocks ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

		int randomBlock = Random.Range(1, 8);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex != i)
			{
				Instantiate(blocks[Random.Range(0, blocks.Length)], spawnPoints[i].position, Quaternion.identity);
			}
		}
	}
	
}
