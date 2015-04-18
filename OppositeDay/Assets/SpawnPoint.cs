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
	private GameObject spawnObject;

	private int spawnFrequency;

	void Start()
	{
		spawnFrequency = startSpawnFrequency;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Time.fixedTime % spawnFrequency == 0) 
		{
			Instantiate(spawnObject, transform.localPosition, spawnObject.transform.rotation);
		}

		if ((Time.fixedTime % spawnMultiplierFrequency) == 0) 
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
