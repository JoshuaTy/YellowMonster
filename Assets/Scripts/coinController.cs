using UnityEngine;
using System.Collections;

public class coinController : MonoBehaviour {
	public float cSpeed = 0.1f;
	public string namecol;
	// Use this for initialization
	void Start () {
		cSpeed = Random.Range (0.05f, 0.2f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - cSpeed, transform.position.y);
		if(transform.position.x <= -15.5f){
			Destroy(transform.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D target){
		namecol = this.gameObject.tag;
		if (target.gameObject.tag == "Player" && namecol == "coin") {
			GameObject.Find("scoreText").GetComponent<scoreTextController>().AddScore(1);
		}else if(target.gameObject.tag == "Player" && namecol == "smalld"){
			GameObject.Find("scoreText").GetComponent<scoreTextController>().AddScore(5);
		}else{
			GameObject.Find("scoreText").GetComponent<scoreTextController>().AddScore(10);
		}
		Destroy(gameObject);
	}
}
