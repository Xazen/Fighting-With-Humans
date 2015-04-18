using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	private PlayerBase _playerBase;

	void Start()
	{
		_playerBase = GetComponent<PlayerBase> ();
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == Tag.ENEMY)
		{
			_playerBase.PlayerHealth.decreaseHealth(10);
		}
	}
}
