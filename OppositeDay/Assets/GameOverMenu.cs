using UnityEngine;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

	// Use this for initialization
	public void Restart () 
	{
		Application.LoadLevel (1);
	}
	
	// Update is called once per frame
	public void Quit () 
	{
		Application.LoadLevel (0);
	}
}
