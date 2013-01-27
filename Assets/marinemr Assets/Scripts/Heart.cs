using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour {
	
	public Texture2D[] heart;
	private int count;
	private bool increase;
	
	// Use this for initialization
	void Start () {
		heart = new Texture2D[10];
		
		count = 0;
		increase = true;
		
		for(int i = 0; i < 10; i++){
			heart[i] = (Texture2D)Resources.LoadAssetAtPath("Assets\\_Heart\\_Heart " + (i + 1) + ".png", typeof(Texture2D));
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(increase){
			if(count < 9){
				count++;
			}
			else{
				increase = false;
			}
		}
		else {
			if(count > 0){
				count--;
			}
			else{
				increase = true;
			}
		}
		
		//count = 0;
	}
	
	void OnGUI() {
		GUI.DrawTexture(new Rect(0,Screen.height - 400, Screen.width, Screen.width), heart[count]);
	}
}
