using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {
	public float bgSpeed = .07f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - bgSpeed, transform.position.y);

		if(transform.position.x <= -27.51f){
			transform.position = new Vector2(
				27.51f, transform.position.y
				);
		}
	}
}
