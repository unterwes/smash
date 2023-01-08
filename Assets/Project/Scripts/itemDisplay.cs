using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemDisplay : MonoBehaviour {

	public item_card item;


	public Image artworkImage;

	public Text info;

	// Use this for initialization
	void Start () {
		artworkImage.sprite = item.artwork;

		info.text = item.info.ToString();
	}

}