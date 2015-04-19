using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	[SerializeField]
	private float movementSpeed = 10.0f;
	[SerializeField]
	private AudioClip stoneJump;

	private float jumpSpeed = 3.0f;
	private float stepFrequency = 1.0f;

	private EnemyBase _enemyBase;
	private PlayerBase _playerBase;

	void Start()
	{
		_enemyBase = GetComponent<EnemyBase> ();
		_playerBase = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerBase>();
	}

	void FixedUpdate()
	{
		int directionMultiplicatorUp = (_playerBase.transform.position.x > transform.position.x) ? 1 : -1;
		int directionMultiplicatorRight = (_playerBase.transform.position.z > transform.position.z) ? 1 : -1;
		if (Time.fixedTime % stepFrequency == 0) 
		{
			GetComponent<AudioSource>().PlayOneShot(stoneJump);
			GetComponent<Rigidbody> ().AddForce (directionMultiplicatorUp * transform.up * movementSpeed, ForceMode.Impulse);
			GetComponent<Rigidbody> ().AddForce (directionMultiplicatorRight * transform.right * movementSpeed, ForceMode.Impulse);
			GetComponent<Rigidbody> ().AddForce (transform.forward * jumpSpeed, ForceMode.Impulse);
		}
	}
}
