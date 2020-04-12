using UnityEngine;
using System.Collections;

public class pressEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Return)){
			Application.LoadLevel ("MainScene");
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}
}
