using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	[SerializeField]
	private GameObject gameOverMenu;
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

			if (_playerBase.PlayerHealth.Health <= 0)
			{
				GameObject.Destroy(gameObject);
				gameOverMenu.SetActive(true);
			}
		}
	}
}
