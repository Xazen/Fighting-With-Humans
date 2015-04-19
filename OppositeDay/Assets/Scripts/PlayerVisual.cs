using UnityEngine;
using System.Collections;

public class PlayerVisual : MonoBehaviour 
{
	[SerializeField]
	private AudioClip attackSound;

	private PlayerBase _playerBase;

	void Start()
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.attackLeft += AttackLeft;
		_playerBase.PlayerInput.attackRight += AttackRight;
	}

	private void AttackLeft()
	{
		Debug.Log ("Attack left");
		GetComponent<AudioSource>().PlayOneShot(attackSound);
		_playerBase.Animator.SetTrigger ("AttackLeft");
	}

	private void AttackRight()
	{
		Debug.Log ("Attack right");
		GetComponent<AudioSource>().PlayOneShot(attackSound);
		_playerBase.Animator.SetTrigger ("AttackRight");
	}
}
