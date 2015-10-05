/* Author: Benzir Ahmed */
/* File: CoinController.cs */
/* Creation Date: Sept 29, 2015 */
/* Description: This script controls the coin reset of gameObject's movement */
using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	public float speed;
	void Start () {
		this._Reset();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = new Vector2 (0.0f, 0.0f);
		currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.x -= speed;
		
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		if (currentPosition.x <= -1789) {
			this._Reset(); 
		}
		
	}
	/*void OnTriggerEnter2D(Collider2D collect){
		if (collect.gameObject.tag == "Player") {
			Destroy(gameObject);//destrys game object, not in use due no respwaning
		}
	}*/
	//resets game object
	private void _Reset(){
		Vector2 resetPosition = new Vector2 (1789, Random.Range(-480f,480f));
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
