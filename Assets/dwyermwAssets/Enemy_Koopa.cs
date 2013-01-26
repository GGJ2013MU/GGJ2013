using UnityEngine;
using System.Collections;

public class Enemy_Koopa : MonoBehaviour, Enemy {

	public double HP;
	public double speed;
	
	// Not sure how cooldown will work for Koopa
	public double MAX_COOLDOWN; // Longest cooldown time
	public double cooldownTimer; // Update for cooldown
	
	// Use this for initialization
	void Start () {
	
	}
	
	virtual public void movement()
	{
		/*
			if(player is in range)
				Start moving forward at "speed"
				
			Create smoke cloud behind enemy
		*/	
	}
	
	virtual public void collision()
	{
		/*
			* if(enemy collides with terrain object)
		 * 		speed *= -1;
		 */ 
	}
	
	virtual public void attacked()
	{
		//* if(Player collides with top of enemy)
		// 		HP -= 10;
		// 	if(enemy collides with fireball)
			// HP -= fireball strength
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
