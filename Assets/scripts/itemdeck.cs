using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDeck", menuName = "ItemDeck")]
public class itemdeck : ScriptableObject
{
    public item_card[] items;
}
