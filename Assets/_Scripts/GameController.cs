/* Author: Benzir Ahmed */
/* File: GameController.cs */
/* Creation Date: OCT 01, 2015 */
/* Description: This script controls the spwan of coins and pigs */
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//Public variables
	public int pigCount;//pig counter per frame
	public GameObject pig;
	public int coinCount;//coin counter per frame
	public GameObject coin;
	public int heatlhCount;
	public GameObject health;

	// Use this for initialization
	void Start () {
		this._GeneratePigs ();//spwans pigs
		this._GenerateCoins ();//spwans coins
		this._GenerateHealth ();//spwans Health objects
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {  
			Application.LoadLevel (0); //restarts the game 
		} 
	
	}
	private void _GeneratePigs(){
		for(int count=0; count < this.pigCount; count++){
			Instantiate(pig);
		}
	}
	private void _GenerateCoins(){
		for(int count=0; count < this.coinCount; count++){
			Instantiate(coin);
		}
	}
	private void _GenerateHealth(){
		for(int count=0; count < this.heatlhCount; count++){
			Instantiate(health);
		}
	}
}
