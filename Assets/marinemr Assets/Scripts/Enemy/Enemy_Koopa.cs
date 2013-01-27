using UnityEngine;
using System.Collections;

// Note: This file is essentially the same as "Enemy2.cs",
// but functions as the damage for the smoke.
public class Enemy_Koopa : MonoBehaviour {

	public bool jumpable;
	
	private bool exist = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// Moves a bit faster than regular enemies
		gameObject.GetComponent<Static_Planet_Movement>().movement(-0.007f);
		if(!exist){
			// delete this game object
			Destroy(this.gameObject);
		}
	}
	
	public bool jumped(){
		if(jumpable){
			exist = false;
			return true;
		}
		return false;
	}
	
	public int getDamage(){
		return 3;
	}
}
