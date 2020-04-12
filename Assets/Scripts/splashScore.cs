using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class splashScore : MonoBehaviour {
	public int gameHighScore=0;
	// Use this for initialization
	void Start () {
		gameHighScore = PlayerPrefs.GetInt("highScore");
		GameObject.Find ("score").GetComponent<Text>().text = "Highscore: " + gameHighScore.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
