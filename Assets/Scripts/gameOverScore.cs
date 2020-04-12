using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOverScore : MonoBehaviour {
	public int currentScore=0;
	// Use this for initialization
	void Start () {
		currentScore = PlayerPrefs.GetInt("CurrentScore");
		GameObject.Find ("score").GetComponent<Text>().text = "Current Score: "+ currentScore.ToString ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
