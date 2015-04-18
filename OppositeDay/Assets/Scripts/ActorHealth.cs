using UnityEngine;
using System.Collections;

public class ActorHealth : MonoBehaviour {
	
	public float maxHealth = 100f;
	
	public float Health {get; set;}

	// Use this for initialization
	public void Start () 
	{
		Health = maxHealth;
	}
	
	public virtual void decreaseHealth(float value)
	{
		Health -= value;
	}

	public void increaseHealth(float value)
	{
		Health += value;
	}

	public void setHealth(float value)
	{
		Health = value;
	}
}
