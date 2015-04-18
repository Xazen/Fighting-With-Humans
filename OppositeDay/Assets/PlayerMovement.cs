using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float jumpSpeed = 8.0f;
	[SerializeField]
	private float gravity = 20.0f;
	[SerializeField]
	private int maxJump = 2;

	private PlayerBase _playerBase;
	
	private Vector3 _moveDirection;
	private int _currentJumpCount;

	public void Start()
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += Jump;


		_moveDirection = Vector3.zero;
		_currentJumpCount = 0;
	}

	public void Update()
	{
		// Apply gravity
		_moveDirection.y -= gravity * Time.deltaTime;

		_playerBase.CharacterController.Move (_moveDirection * Time.deltaTime);

		// If the player is on the ground reset jump counter
		if (_playerBase.CharacterController.isGrounded && _currentJumpCount > 0) 
		{
			_currentJumpCount = 0;
		}
	}

	/// <summary>
	/// Character will Jump.
	/// </summary>
	public void Jump()
	{
		if (_currentJumpCount < maxJump) 
		{
			_moveDirection.y = jumpSpeed;
			_currentJumpCount++;
		}
	}
}
