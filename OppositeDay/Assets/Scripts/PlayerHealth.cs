using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : ActorHealth {

	private Image healthBar;

	// Use this for initialization
	void Start () 
	{
		base.Start ();
		healthBar = GameObject.FindGameObjectWithTag (Tag.HEALTHBAR).GetComponent<Image> ();
	}
	
	public override void decreaseHealth(float value)
	{
		base.decreaseHealth(value);
		healthBar.fillAmount = Health/maxHealth;
	}
}
