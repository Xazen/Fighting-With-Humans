using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame () 
	{
		Application.LoadLevel (1);
	}

	public void QuitGame ()
	{
		Application.Quit ();
	}
}
