using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	[SerializeField]
	private int startSpawnFrequency = 10;
	[SerializeField]
	private int minSpawnFrequency = 3;
	[SerializeField]
	private float spawnMultiplier = 0.9f;
	[SerializeField]
	private float spawnMultiplierFrequency = 20f;
	[SerializeField]
	private int firstSpawn = 10;
	[SerializeField]
	private GameObject spawnObject;

	private int spawnFrequency;

	void Start()
	{
		spawnFrequency = startSpawnFrequency;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if ((Time.fixedTime-firstSpawn) % spawnFrequency == 0 && Time.fixedTime >= firstSpawn) 
		{
			Instantiate(spawnObject, transform.localPosition, spawnObject.transform.rotation);
		}

		if (((Time.fixedTime - firstSpawn) % spawnMultiplierFrequency) == 0) 
		{
			if ((spawnFrequency * spawnMultiplier) > minSpawnFrequency) 
			{
				Debug.Log ("Increased difficulty");
				spawnFrequency = (int)(spawnFrequency * spawnMultiplier);
			} 
			else 
			{
				Debug.Log ("Max difficulty");
				spawnFrequency = minSpawnFrequency;
			}
		}
	}
}
