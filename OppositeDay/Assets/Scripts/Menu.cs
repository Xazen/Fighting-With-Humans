using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame () 
	{
		GetComponent<AudioSource> ().Play ();
		Application.LoadLevel (1);
	}

	public void QuitGame ()
	{
		GetComponent<AudioSource> ().Play ();
		Application.Quit ();
	}
}
