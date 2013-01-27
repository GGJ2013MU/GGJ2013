using UnityEngine;
using System.Collections;

public class Static_Planet_Movement : MonoBehaviour {
	
	private float gravityAccel = 0.2f;
	public float maxSpeed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// FixedUpdate is called every set time frame
	void FixedUpdate () {
		rotationAdj();
		
		Vector3 direction = new Vector3(0,0,0) - transform.position;
		rigidbody.velocity += (direction.normalized * gravityAccel);
		
		rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, maxSpeed);
		
	}
	
	void rotationAdj(){
		//Quaternion rot = Quaternion.LookRotation((new Vector3(0,transform.position.y,0) - transform.position).normalized);// * new Quaternion(0,0,0,0);
		//transform.rotation = rot;
		transform.LookAt(new Vector3(0,transform.position.y, 0));
		transform.Rotate(new Vector3(-90,0,0));
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Platform"){
			//grounded = true;
			rigidbody.velocity += transform.up.normalized * 2;
		}
		
		if(collision.gameObject.tag == "Player")
		{
			///collision.gameObject.
		}
			 //call method jumped for EnemyInterface
				
		//	if(collision.gameObject.GetComponent<Enemy2>().jumped()){
				
		//		Vector3 direction = new Vector3(0,0,0) - transform.position;
		//		rigidbody.velocity -= direction.normalized;
					
				//Destroy(collision.gameObject);
			//}
	//	}
	}
	
	// movement
	public void movement(float x){
		float delta = x / Time.fixedDeltaTime;
		rigidbody.velocity += transform.right * delta;
	}
}
