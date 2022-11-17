using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class putItems : MonoBehaviour
{
    public itemdeck itemSet; // array of SO items
    public GameObject itemPanel; // prefab item panel for cloning
    public GameObject selectionItemPanel; // display panel on game canvas


    void PlaceItem(item_card item)
    {
        if (selectionItemPanel != null)
        {
              
            GameObject i = Instantiate(itemPanel,selectionItemPanel.transform);
                i.GetComponent<itemDisplay>().item = item;
            
        }
    }

  public void PlaceRandom()
{    
    foreach (Transform child in selectionItemPanel.transform)
    {
        Destroy(child.gameObject);
    }
    for (int cnt = 0; cnt < 2; cnt++)
    {
        int randIndex = Random.Range(0, itemSet.items.Length);
        PlaceItem(itemSet.items[randIndex]);
        }
    }
}