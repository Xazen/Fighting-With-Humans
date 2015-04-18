using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour 
{
	public delegate void InputDelegate();

	private PlayerBase _playerBase;

	public InputDelegate jump;
	public InputDelegate attackLeft;
	public InputDelegate attackRight;

	void Update()
	{
		if (Input.GetButtonDown ("Jump")) 
		{
			if (jump != null)
			{
				jump();
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A))
		{
			if (attackLeft != null)
			{
				attackLeft();
			}
		}

		if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)) 
		{
			if (attackRight != null)
			{
				attackRight();
			}
		}
	}
}
