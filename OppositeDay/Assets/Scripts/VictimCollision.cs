using UnityEngine;
using System.Collections;

public class VictimCollision : MonoBehaviour {

	[SerializeField]
	private GameObject blood;
	[SerializeField]
	private AudioClip bloodClip;

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag != Tag.WEAPON) 
		{
			GetComponent<AudioSource>().PlayOneShot(bloodClip);
			GameObject bloodObject = (GameObject)Instantiate (blood, transform.localPosition, blood.transform.rotation);
		}
	}
}
