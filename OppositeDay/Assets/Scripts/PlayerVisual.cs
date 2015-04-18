using UnityEngine;
using System.Collections;

public class PlayerVisual : MonoBehaviour 
{
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
		_playerBase.Animator.SetTrigger ("AttackLeft");
	}

	private void AttackRight()
	{
		Debug.Log ("Attack right");
		_playerBase.Animator.SetTrigger ("AttackRight");
	}
}
