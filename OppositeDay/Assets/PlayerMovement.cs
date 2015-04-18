using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float jumpSpeed = 8.0f;
	[SerializeField]
	private float gravity = 20.0f;

	private PlayerBase _playerBase;

	private CharacterController _characterController;
	private Vector3 _moveDirection;

	public void Start()
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += Jump;

		_characterController = GetComponent<CharacterController> ();
		_moveDirection = Vector3.zero;
	}

	public void Update()
	{
		_moveDirection.y -= gravity * Time.deltaTime;

		_characterController.Move (_moveDirection * Time.deltaTime);
	}

	public void Jump()
	{
		_moveDirection.y = jumpSpeed;
	}
}
