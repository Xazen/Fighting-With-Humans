using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tag.WEAPON) 
		{
			GameObject.Destroy(this.gameObject);
		}
	}
}
