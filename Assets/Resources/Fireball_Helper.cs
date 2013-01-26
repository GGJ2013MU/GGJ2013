using UnityEngine;
using System.Collections;

public class Fireball_Helper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		gameObject.GetComponent<Static_Planet_Movement>().movement(-0.01f);
	}
}
