using UnityEngine;
using System.Collections;

public class BloodDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		ParticleSystem particleSystem = GetComponent<ParticleSystem> ();
		Invoke ("Destruct", particleSystem.duration);
	}

	public void Destruct()
	{
		GameObject.DestroyObject (gameObject);
	}
}
