using UnityEngine;
using System.Collections;

public class EnvironmentMovement : MonoBehaviour {
	
	public float speed, gravityAccel, earthRadius, jumpStrength, maxSpeed;
	
	private bool grounded;
	//public float gSpeed;
	
	// Use this for initialization
	void Start () {
		//speed /= Time.fixedDeltaTime;
		//gSpeed = 0;
		grounded = false;
	}
	
	// Update is called once per frame
	void Update(){
		
	}
	
	void FixedUpdate() {
		if(Input.GetKey("a")){
			movement(speed);
		}
		else if(Input.GetKey("d")){
			movement(-speed);
		}
		
		rotationAdj();
		
		if(Input.GetKey("w")){
			jump();
		}
		
		
		
		Vector3 direction = new Vector3(0,0,0) - transform.position;
		rigidbody.velocity += (direction.normalized * gravityAccel);
		
		rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, maxSpeed);
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Platform"){
			grounded = true;
			rigidbody.velocity += transform.up.normalized * 2;
		}
		
		if(collision.gameObject.tag == "Enemy"){
			// call method jumped for EnemyInterface
			if(collision.gameObject.GetComponent<Enemy2>().jumped()){
				
				Vector3 direction = new Vector3(0,0,0) - transform.position;
				rigidbody.velocity -= direction.normalized;
					
				//Destroy(collision.gameObject);
			}
		}
	}
	
	// public set variables
	public void setSpeed(float s){
		speed = s;
	}
	
	// public set gravity effect
	public void setGravity(float g){
		gravityAccel = g;
	}
	
	// movement
	public void movement(float x){
		float delta = x / Time.fixedDeltaTime;
		rigidbody.velocity += transform.right * delta;
		//transform.position += new Vector3(delta,0,0);
	}
	
	void jump(){
		RaycastHit hit;
		float dist = 1;
		int angle = 90;
		int numTests = 5;
		
		if(grounded){
			rigidbody.velocity = transform.up * jumpStrength;
			grounded = false;
		}
	}
	
	
	void rotationAdj(){
		//Quaternion rot = Quaternion.LookRotation((new Vector3(0,transform.position.y,0) - transform.position).normalized);// * new Quaternion(0,0,0,0);
		//transform.rotation = rot;
		transform.LookAt(new Vector3(0,transform.position.y, 0));
		transform.Rotate(new Vector3(-90,0,0));
	}
}
