using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float enemySpeed = 0.07f;
	// Use this for initialization
	void Start () {
		enemySpeed = Random.Range (0.05f,0.2f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - enemySpeed, transform.position.y);
		
		if(transform.position.x <= -15.5f){
			Destroy(transform.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			Destroy(target.gameObject);	
			Application.LoadLevel("gameOver");
		}
	}
}
