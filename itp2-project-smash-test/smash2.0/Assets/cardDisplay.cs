using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardDisplay : MonoBehaviour {

	public Card card;


	public Image artworkImage;

	public Text attackText;
	public Text healthText;

	// Use this for initialization
	void Start () {
		artworkImage.sprite = card.artwork;

		attackText.text = card.attack.ToString();
		healthText.text = card.health.ToString();
	}

}