using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			Application.LoadLevel ("MainScene");
			//GameObject.Find("score").GetComponent<Text>().text = "you scored:" + gameHighscore.ToString();
		} else if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
