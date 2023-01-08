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
		artworkImage.rectTransform.sizeDelta = new Vector2(200, 200);

		attackText.text = card.attack.ToString();
		//attackText.transform.position = new Vector3(-75,80, 0);
		healthText.text = card.health.ToString();
		//healthText.transform.position = new Vector3(80,80, 0);
	}

}