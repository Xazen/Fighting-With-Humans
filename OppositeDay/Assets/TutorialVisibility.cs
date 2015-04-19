using UnityEngine;
using System.Collections;

public class TutorialVisibility : MonoBehaviour {

	GameObject tutorial;

	// Use this for initialization
	void Start () 
	{
		tutorial = GameObject.FindGameObjectWithTag (Tag.TUTORIAL);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.H)) 
		{
			Debug.Log(tutorial);
			tutorial.SetActive(!tutorial.activeInHierarchy);
		}
	
	}
}
