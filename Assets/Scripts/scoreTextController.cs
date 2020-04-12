using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreTextController : MonoBehaviour {
	public int gameCurrentScore;
	public int gameHighScore;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("highScore")){
			gameHighScore = PlayerPrefs.GetInt("highScore");
			GameObject.Find("highText").GetComponent<Text>().text = "Highscore: " + gameHighScore.ToString ();
		}else{
			PlayerPrefs.SetInt("highScore",0);
		}
		
	}
	public void AddScore(int x){
		
		GetComponent<AudioSource> ().Play ();
		gameCurrentScore += x;
		PlayerPrefs.SetInt ("CurrentScore", gameCurrentScore);
		if (gameCurrentScore > gameHighScore){
			GameObject.Find("highText").GetComponent<Text>().text = "Highscore: " + gameCurrentScore.ToString ();
			PlayerPrefs.SetInt("highScore",gameCurrentScore);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject.Find("scoreText").GetComponent<Text>().text = gameCurrentScore.ToString ();
	}
}
