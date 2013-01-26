using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	private GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
		transform.rotation = Quaternion.Euler(90, 0, 0);
		// player.transform.rotation.y
		// transform.rotation.x
	}
}
