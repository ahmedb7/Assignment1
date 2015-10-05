/* Author: Benzir Ahmed */
/* File: PlayerController.cs */
/* Creation Date: Sept 28, 2015 */
/* Description: This script allows the player to move in different directions(up,down,left/back,right/forward)*/
/*, Date last Modified: Sept 29: added boundary check*/
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
		public float speed;
	public Boundary boundary;
	
	public Camera camera;
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();
	}
	
	private void _CheckInput() {
		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position
		
		//movement by keyboard
		if (Input.GetAxis ("Horizontal") > 0) {
			this._newPosition.x += this.speed; // add move value to current position(right/forward)
		}
		
		if (Input.GetAxis ("Horizontal") < 0) {
			this._newPosition.x -= this.speed; // subtract move value to current position(left/back)
		}
		if (Input.GetAxis ("Vertical") > 0) {
			this._newPosition.y += this.speed; // subtract move value to current position(up)
		}
		if (Input.GetAxis ("Vertical") < 0) {
			this._newPosition.y -= this.speed; // subtract move value to current position(down)
		}

		
		this._BoundaryCheck ();
		
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}
	
	private void _BoundaryCheck() {
		if (this._newPosition.x < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
		}
		
		if (this._newPosition.x > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
		}
		if (this._newPosition.y > this.boundary.yMax) {
			this._newPosition.y = this.boundary.yMax;
		}
		if (this._newPosition.y < this.boundary.yMin) {
			this._newPosition.y = this.boundary.yMin;
		}
	}
}
