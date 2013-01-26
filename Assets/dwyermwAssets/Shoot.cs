using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	Transform prefabBullet;
	public float shootForce;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			GameObject instance = (GameObject)Instantiate(Resources.Load("Fireball"));
			instance.transform.rotation = Quaternion.identity;
			instance.transform.position = transform.position;
			//gameObject.GetComponent<Static_Planet_Movement>().movement(0.02f);
			//instance.rigidbody.AddForce(transform.forward * shootForce);
		}

	}
}
