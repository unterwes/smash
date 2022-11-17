using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDeck", menuName = "Deck")]
public class Deck : ScriptableObject
{
    public Card[] cards;
}
