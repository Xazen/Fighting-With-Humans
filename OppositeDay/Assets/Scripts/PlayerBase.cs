using UnityEngine;
using System.Collections;

public class PlayerBase : MonoBehaviour {

	private PlayerInput _playerInput;
	public PlayerInput PlayerInput
	{
		get
		{
			if (_playerInput == null)
			{
				_playerInput = GetComponent<PlayerInput>();
			}
			return _playerInput;
		}
	}

	private PlayerCollision _playerCollision;
	public PlayerCollision PlayerCollision
	{
		get
		{
			if (_playerCollision == null)
			{
				_playerCollision = GetComponent<PlayerCollision>();
			}
			return _playerCollision;
		}
	}

	private PlayerVisual _playerVisual;
	public PlayerVisual PlayerVisual
	{
		get
		{
			if (_playerVisual == null)
			{
				_playerVisual = GetComponent<PlayerVisual>();
			}
			return _playerVisual;
		}
	}

	private PlayerHealth _playerHealth;
	public PlayerHealth PlayerHealth
	{
		get
		{
			if (_playerHealth == null)
			{
				_playerHealth = GetComponent<PlayerHealth>();
			}
			return _playerHealth;
		}
	}

	private CharacterController _characterController;
	public CharacterController CharacterController
	{
		get
		{
			if (_characterController == null)
			{
				_characterController = GetComponent<CharacterController>();
			}
			return _characterController;
		}
	}
}
