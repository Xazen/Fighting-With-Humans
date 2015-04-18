﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyCollision : MonoBehaviour 
{
	private ActorBase _actorBase;
	private PlayerBase _playerBase;
	private Text _scoreText;

	[SerializeField]
	private float setback = 6;

	void Start()
	{
		_actorBase = GetComponent<ActorBase> ();
		_playerBase = GameObject.FindGameObjectWithTag (Tag.PLAYER).GetComponent<PlayerBase>();
		_scoreText = GameObject.FindGameObjectWithTag (Tag.SCORE).GetComponent<Text> ();
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tag.WEAPON) 
		{
			_actorBase.ActorHealth.decreaseHealth(10);

			if(_actorBase.ActorHealth.Health <= 0)
			{
				GameObject.Destroy(this.gameObject);
				int currentScore = int.Parse(_scoreText.text);
				currentScore+=100;
				_scoreText.text = currentScore.ToString();

			} else {
				int directionMultiplicator = (_playerBase.transform.position.x > transform.position.x) ? 1 : -1;
               	GetComponent<Rigidbody> ().AddForce (-directionMultiplicator * transform.up * setback, ForceMode.Impulse);
				GetComponent<Rigidbody> ().AddForce (transform.forward * setback, ForceMode.Impulse);
			}
		}
	}
}