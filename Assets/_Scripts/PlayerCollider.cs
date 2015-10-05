/* Author: Benzir Ahmed */
/* File: PlayerCollider.cs */
/* Creation Date: OCT 1, 2015 */
/* Description: This script controls player collions and sound effects*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

	//public instance var
	public Text scoreLabel;
	public Text livesLabel;
	public Text restartLabel;
	public Text gameOverLabel;
	public Text finalScoreLbel;
	public int scoreValue = 0;
	public int livesValue = 5;

	//Audio instance varibles
	private AudioSource[] _audioSources;
	private AudioSource _coinAudioSources, _pigAudioSources, _backAudioSource, _endAudioSource, _heatlhAudioSource;
	private bool _isColliding;





	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource>();//audio soucres for game objects 
		this._coinAudioSources = this._audioSources [0];
		this._pigAudioSources = this._audioSources [1];
		this._backAudioSource = this._audioSources [2];
		this._endAudioSource = this._audioSources [3];
		this._heatlhAudioSource = this._audioSources [4];
		this._isColliding = false;
		this._SetScore ();
		this.gameOverLabel.enabled = false;//disabled the game over text in the begaining od the game
		this.finalScoreLbel.enabled = false;
		this.restartLabel.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter2D(Collider2D otherGameObject){//2D collider for player colliding with coin
			if (otherGameObject.tag == "Coin") {
				this._coinAudioSources.Play ();
				this._isColliding = true;
				this.scoreValue +=100;//score counter, adds scores

			}
			if (otherGameObject.tag == "Pigs") {
			this._pigAudioSources.Play ();
			this._isColliding = true;
			this.livesValue --;//life counter, removes lives with impact
		}
		if (otherGameObject.tag == "Health") {
			this._heatlhAudioSource.Play ();
			this._isColliding = true;
			this.livesValue ++;//life counter, adds lives with impact
		}
			if(this.livesValue <= 0){
				this._Endgame();
				this._endAudioSource.Play ();
			}
			
		this._SetScore ();//call score method

		}
	void OnTriggerExit2D(Collider2D otherGameObject){
		this._isColliding = false;
	}
	private void _SetScore(){//score method
		this.scoreLabel.text = "Score: " + this.scoreValue;
		this.livesLabel.text = "Lives: " + this.livesValue;
	}
	private void _Endgame(){//end game method: object killing or showing objects
		Destroy(gameObject);
		this.scoreLabel.enabled = false;
		this.livesLabel.enabled = false;
		this.restartLabel.enabled = true;
		this.gameOverLabel.enabled = true;
		this.finalScoreLbel.enabled = true;
		this.finalScoreLbel.text = "Score: " + this.scoreValue;


	}

}
