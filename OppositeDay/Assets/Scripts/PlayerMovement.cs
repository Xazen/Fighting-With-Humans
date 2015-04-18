using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float jumpSpeed = 8.0f;
	[SerializeField]
	private float movementSpeed = 8.0f;
	[SerializeField]
	private int maxJump = 2;

	private PlayerBase _playerBase;

	private int _currentJumpCount;

	public void Start()
	{
		_playerBase = GetComponent<PlayerBase> ();
		_playerBase.PlayerInput.jump += Jump;
		_playerBase.PlayerInput.moveLeft += MoveLeft;
		_playerBase.PlayerInput.moveRight += MoveRight;
		_playerBase.PlayerInput.moveUp += MoveUp;
		_playerBase.PlayerInput.moveDown += MoveDown;

		_currentJumpCount = 0;
	}

	/// <summary>
	/// Character will Jump.
	/// </summary>
	public void Jump()
	{
		if (_currentJumpCount < maxJump) 
		{
			GetComponent<Rigidbody> ().AddForce (transform.forward * jumpSpeed, ForceMode.Impulse);
			_currentJumpCount++;
		}
	}

	public void MoveLeft()
	{
		if (_currentJumpCount == 0) 
		{
			GetComponent<Rigidbody> ().AddForce (-transform.up * movementSpeed, ForceMode.Impulse);
			GetComponent<Rigidbody> ().AddForce (transform.forward * 4.5f, ForceMode.Impulse);
			_currentJumpCount++;
		}
	}

	public void MoveRight()
	{
		if (_currentJumpCount == 0) 
		{
			GetComponent<Rigidbody> ().AddForce (transform.up * movementSpeed, ForceMode.Impulse);
			GetComponent<Rigidbody> ().AddForce (transform.forward * 4.5f, ForceMode.Impulse);
			_currentJumpCount++;
		}
	}

	public void MoveUp()
	{
	}

	public void MoveDown()
	{
	}

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log (collision.gameObject.tag);
		if (collision.gameObject.tag == Tag.FLOOR && _currentJumpCount > 0)
		{
			_currentJumpCount = 0;
		}
	}
}
