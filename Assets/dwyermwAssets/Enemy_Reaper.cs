using UnityEngine;
using System.Collections;

public class Enemy_Reaper : MonoBehaviour, Enemy {

	public double HP;
	public double speed;
	
	public double MAX_COOLDOWN; // Longest cooldown time
	public double cooldownTimer; // Update for cooldown
	
	// Use this for initialization
	void Start () {
	
	}
	
	virtual public void movement()
	{
		/*
			if(player is in range)
				Start moving toward player at "speed"
				
			Start throwing ammo in same direction
		*/	
	}
	
	virtual public void collision()
	{
		/*
			* if(enemy collides with terrain object)
		 * 		speed == 0; // Stays and shoots
		 */ 
	}
	
	virtual public void attacked()
	{
		//* if(enemy collides with fireball)
		// 		HP -= fireball strength
	}
	
	public void attack()
	{
		//Attack!
		// Shoot class is half made; the video apparently didn't have compiler problems
	}
	
	virtual public bool isDead()
	{
		// if(HP <=0)
			//Display enemy death animation
			//return true
		// else 
		return false;
	}
	
	// Update is called once per frame
	virtual public void FixedUpdate () {
		
		
		movement();
		collision();
		attacked();
		if(isDead ());
			//Remove enemy from ArrayList

	
	}
}
