using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {
	
	public bool jumpable;
	
	private bool exist = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
