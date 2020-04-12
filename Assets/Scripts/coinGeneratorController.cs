using UnityEngine;
using System.Collections;

public class coinGeneratorController : MonoBehaviour {
	public Transform coinPrefab;
	public Transform smalldPrefab;
	public Transform bigdPrefab;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Generate",0,2);
		InvokeRepeating ("GeneratessD",0,5);
		InvokeRepeating ("GeneratesbD",0,10);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void Generate(){
		Instantiate (coinPrefab, new Vector2(Random.Range(15,24),Random.Range(-4,4)), transform.rotation);
	}
	void GeneratessD(){
		Instantiate (smalldPrefab, new Vector2(Random.Range(15,24),Random.Range(-4,4)), transform.rotation);
	}
	void GeneratesbD(){
		Instantiate (bigdPrefab, new Vector2(Random.Range(15,24),Random.Range(-4,4)), transform.rotation);
	}
}
