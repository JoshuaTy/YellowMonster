using UnityEngine;
using System.Collections;

public class EnemyGeneratorController : MonoBehaviour {
	public Transform enemy;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Generate",0,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Generate(){
		Instantiate (enemy, new Vector2(Random.Range(15,24),Random.Range(-4,4)), transform.rotation);
	}
}
