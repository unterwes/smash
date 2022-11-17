using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "item")]
public class item_card : ScriptableObject {

	public Sprite artwork;

	public int coins;
	public int increase_attack;
	public int increase_health;
	public string info;


}