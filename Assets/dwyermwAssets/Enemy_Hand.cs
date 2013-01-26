using UnityEngine;
using System.Collections;

public class Enemy_Hand : MonoBehaviour {

	public double HP;
	public double speed;
	
	public double aboveTimer; // Time above ground
	public double belowTimer; // Time below ground
	
	public bool above;
	
	// Use this for initialization
	void Start () {
	
	}
	
	virtual public void movement()
	{
		// if(enemy is in range && !above)
			//start belowTimer
		//else if(above && aboveTimer == 0)
			// move below
			// start belowTimer
			// reset aboveTimer
		//else if(!above && belowTimer == 0)
			// move above
			// start aboveTimer
			// reset belowTimer
	}
	
	virtual public void collision()
	{
		//if(enemy is hit by fireball)
			//HP -= strengh of fireball
	}
	
	virtual public void attacked()
	{
		//* if(fireball collides with enemy)
		// 		HP -= fireball damage;
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
	virtual public void FixedUpdate () 
	{
		
		
		movement();
		collision();
		attacked();
		if(isDead ());
			//Remove enemy from ArrayList
	}
}
