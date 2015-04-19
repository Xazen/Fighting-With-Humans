using UnityEngine;
using System.Collections;

public class VictimSound : MonoBehaviour {

	[SerializeField]
	private AudioClip[] moanSounds;
	[SerializeField]
	private int moanFrequency = 3;

	// Update is called once per frame
	void FixedUpdate () 
	{
		AudioSource audioSource = GetComponent<AudioSource> ();
		if (!audioSource.isPlaying && (Time.fixedTime % 3 == 0))
		{
			audioSource.PlayOneShot(moanSounds[(int)Random.Range(0f, 3f)]);
		}
	}
}
