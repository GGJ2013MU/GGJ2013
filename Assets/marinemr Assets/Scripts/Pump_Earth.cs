using UnityEngine;
using System.Collections;

public class Pump_Earth : MonoBehaviour {
	
	private int count;
	private bool pump;
	
	// Use this for initialization
	void Start () {
		pump = true;
		count = 0;
	}
	
	// Update is called once per frame
	/*void FixedUpdate () {
		if(pump){
			transform.localScale += new Vector3(0.1f, 0, 0.1f);
			count++;
			if(count > 50){
				pump = false;
			}
		}
		else{
			transform.localScale -= new Vector3(0.1f, 0, 0.1f);
			count--;
			if(count < 5){
				pump = true;
			}
			
		}
	}*/
}
