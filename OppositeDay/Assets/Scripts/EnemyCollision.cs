using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour 
{
	private ActorBase _actorBase;
	private PlayerBase _playerBase;

	[SerializeField]
	private float setback = 6;

	void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_playerBase = GameObject.FindGameObjectWithTag (Tag.PLAYER).GetComponent<PlayerBase>();
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tag.WEAPON) 
		{
			_actorBase.ActorHealth.decreaseHealth(10);

			if(_actorBase.ActorHealth.Health <= 0)
			{
				GameObject.Destroy(this.gameObject);
			} else {
				int directionMultiplicator = (_playerBase.transform.position.x > transform.position.x) ? 1 : -1;
               	GetComponent<Rigidbody> ().AddForce (-directionMultiplicator * transform.up * setback, ForceMode.Impulse);
				GetComponent<Rigidbody> ().AddForce (transform.forward * setback, ForceMode.Impulse);
			}
		}
	}
}
