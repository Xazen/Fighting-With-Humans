using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	[SerializeField]
	private float movementSpeed = 10.0f;
	private float jumpSpeed = 3.0f;
	private float stepFrequency = 1.0f;

	private EnemyBase _enemyBase;
	private PlayerBase _playerBase;

	void Start()
	{
		_enemyBase = GetComponent<EnemyBase> ();
		_playerBase = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerBase>();
	}

	void Update()
	{
		int directionMultiplicator = (_playerBase.transform.position.x > transform.position.x) ? 1 : -1;
		if (Time.fixedTime % stepFrequency == 0) 
		{
			GetComponent<Rigidbody> ().AddForce (directionMultiplicator * transform.up * movementSpeed, ForceMode.Impulse);
			GetComponent<Rigidbody> ().AddForce (transform.forward * jumpSpeed, ForceMode.Impulse);
		}
	}
}
