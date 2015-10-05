using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

	// initialization
	public Speed speed;
	public Drift drift;
	public Boundary boundary;
	
	private float _CurrentSpeed;
	private float _CurrentDrift;
	
	void Start () {
		this._Reset();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = new Vector2 (0.0f, 0.0f);
		currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y += this._CurrentDrift;
		currentPosition.x -= this._CurrentSpeed;
		
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		if (currentPosition.x <= boundary.xMin) {
			this._Reset(); 
		}
		
	}
	//resets game object
	private void _Reset(){
		this._CurrentSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		this._CurrentDrift = Random.Range (drift.minDrift, drift.maxDrift);
		Vector2 resetPosition = new Vector2 (boundary.xMax, Random.Range(boundary.yMin,boundary.yMax));
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
