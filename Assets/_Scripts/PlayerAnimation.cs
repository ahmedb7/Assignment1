/* Author: Benzir Ahmed */
/* File: PlayerAnimation.cs */
/* Creation Date: OCT 3, 2015 */
/* Description: This script animates the player game object*/
using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {
	//INSTANCE VAR PUBLIC
	public Sprite[] sprites;
	public float framesPerSecond;
	//INSTANCE VAR PRIVATE
	private SpriteRenderer _spriteRenderer;

	// Use this for initialization
	void Start () {
		this._spriteRenderer = gameObject.GetComponent<SpriteRenderer> () as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.timeSinceLevelLoad * this.framesPerSecond);
		index %=(this.sprites.Length - 1);
		this._spriteRenderer.sprite = this.sprites [index];
	}
}
