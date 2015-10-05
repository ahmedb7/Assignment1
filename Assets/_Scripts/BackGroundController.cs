/* Author: Benzir Ahmed */
/* File: BackgroundController.cs */
/* Creation Date: Sept 28, 2015 */
/* Description: This script controls the background and resets it everytime */
/*, Date last Modified: Sept 29: added boundaries*/
using UnityEngine;
using System.Collections;

public class BackGroundController : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		this._Reset();
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = new Vector2 (0.0f, 0.0f);
		currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.x -= speed;

		gameObject.GetComponent<Transform> ().position = currentPosition;

		if (currentPosition.x <= -785)//due to the background being non symmetric, the vales on the reset and current position is different
		{
			this._Reset(); 
		}
	
	}
	//resets game object
	private void _Reset(){
		Vector2 resetPosition = new Vector2 (930f, 0.0f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
}
}
