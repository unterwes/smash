using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class putCards : MonoBehaviour
{
    public Deck cardSet; // array of SO cards
    public GameObject cardPanel; // prefab card panel for cloning
    public GameObject selectionPanel; // display panel on game canvas


    void PlaceCard(Card card)
    {
        if (selectionPanel != null)
        {
              
            GameObject i = Instantiate(cardPanel,selectionPanel.transform);
                i.GetComponent<cardDisplay>().card = card;
            
        }
    }

  public void PlaceRandom()
{    
    foreach (Transform child in selectionPanel.transform)
    {
        Destroy(child.gameObject);
    }
    for (int cnt = 0; cnt < 4; cnt++)
    {
        int randIndex = Random.Range(0, cardSet.cards.Length);
        PlaceCard(cardSet.cards[randIndex]);
        }
    }
}