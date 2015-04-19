using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour 
{
	public delegate void InputDelegate();
	
	private PlayerBase _playerBase;

	public InputDelegate jump;
	public InputDelegate attackLeft;
	public InputDelegate attackRight;
	public InputDelegate moveLeft;
	public InputDelegate moveRight;
	public InputDelegate moveUp;
	public InputDelegate moveDown;

	void Update()
	{
		if (Input.GetButtonDown ("Jump")) 
		{
			if (jump != null)
			{
				jump();
			}
		}

		if (Input.GetKeyDown (KeyCode.Mouse0))
		{
			if (attackLeft != null)
			{
				attackLeft();
			}
		}

		if (Input.GetKeyDown (KeyCode.Mouse1)) 
		{
			if (attackRight != null)
			{
				attackRight();
			}
		}

		if (Input.GetKeyDown (KeyCode.W))
		{
			if (moveUp != null)
			{
				moveUp();
			}
		}
		
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			if (moveLeft != null)
			{
				moveLeft();
			}
		}
		
		if (Input.GetKeyDown (KeyCode.S))
		{
			if (moveDown != null)
			{
				moveDown();
			}
		}
		
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			if (moveRight != null)
			{
				moveRight();
			}
		}
	}
}
