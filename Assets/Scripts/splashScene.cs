using UnityEngine;
using System.Collections;

public class splashScene : MonoBehaviour {
	public float enemySpeed = 0.07f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - enemySpeed, transform.position.y);
		
		if(transform.position.x <= -10.5f){
			transform.position = new Vector2 (9,transform.position.y);
		}
	}

}
