using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public double maxHealth;
	private double health;
	
	private bool panic;
	public double panicCountDown;
	private double panicCount;
	
	private Texture2D[] heart;
	private bool increase;
	private int count;
	
	// Use this for initialization
	void Start () {
		health = maxHealth;
		panic = false;
		
		increase = true;
		count = 0;
		
		heart = new Texture2D[10];
		for(int i = 0; i < 10; i++){
			heart[i] = (Texture2D)Resources.LoadAssetAtPath("Assets\\_Heart\\_Heart " + (i + 1) + ".png", typeof(Texture2D));
		}
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		health -= Time.fixedDeltaTime;
		
		if(panic){
			health -= Time.fixedDeltaTime * 2;
			panicCount -= Time.fixedDeltaTime;
			
			if(panicCount <= 0){
				panic = false;
			}
		}
		else{
			Debug.Log("Not Panicking");
		}
		
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
		
		RaycastHit hit;
		float dist = 5;
		
		for(int i = 0; i < 10; i++){
			if(Physics.Raycast(transform.position, -1 * transform.right + transform.up * i, out hit, dist)) { // 5 is raycast distance
				if(hit.collider.gameObject.tag == "Enemy"){
					panic = true;
					panicCount = panicCountDown;
					Debug.Log("Panic!");
				}
			}
		}
		
		
	}
	
	void OnGUI(){
		GUI.DrawTexture(new Rect(50,Screen.height - 125, 50, 50), heart[count]);
		GUI.Label(new Rect(100, Screen.height - 100, 150, 50), (int)health + "");
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Enemy"){
			// change to whatever method gets damage
			health -= collision.gameObject.GetComponent<Enemy>().getDamage();
		}
		else if(collision.gameObject.tag == "Projectile"){
			// change to whatever method gets damage
			health -= collision.gameObject.GetComponent<Projectile>().getDamage();
		}
	}
}