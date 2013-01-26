using System;
using UnityEngine;
using System.Collections;

	public interface Enemy
	{
		// Use this for initialization
		//void Start ();	
		void movement();
	
		void collision();
		void attacked();
	
		bool isDead();
		void FixedUpdate ();
		
		
	}

