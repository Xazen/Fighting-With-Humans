using UnityEngine;
using System.Collections;

public class VictimCollision : MonoBehaviour {

	[SerializeField]
	private GameObject blood;

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag != Tag.WEAPON) 
		{
			GameObject bloodObject = (GameObject)Instantiate (blood, transform.localPosition, blood.transform.rotation);
		}
	}
}
