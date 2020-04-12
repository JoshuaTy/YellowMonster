using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveRate = 0.2f;
	public float upperBoundary = 4;
	public float lowerBoundary = -4;
	public float rightBoundary = 5.5f;
	public float leftBoundary = -5.5f;
	public bool isDead = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isDead == false) {
			float inputX = Input.GetAxis("Horizontal");
			float inputY = Input.GetAxis("Vertical");

			transform.position = new Vector2(transform.position.x+inputX*moveRate, transform.position.y+inputY*moveRate);
			if(transform.position.x <= leftBoundary){
				transform.position = new Vector2(leftBoundary, transform.position.y);
			}
			if(transform.position.x >= rightBoundary){
				transform.position = new Vector2(rightBoundary, transform.position.y);
			}
			if(transform.position.y >= upperBoundary){
				transform.position = new Vector2(transform.position.x, upperBoundary);
			}
			if(transform.position.y <= lowerBoundary){
				transform.position = new Vector2(transform.position.x, lowerBoundary);
			}
		}
	}
}
