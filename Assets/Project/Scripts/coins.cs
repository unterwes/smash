using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coins : MonoBehaviour
{
     int money;  
    
     public Text moneyAmountText;
     public Button rerollbutton;
     public List<Card> discardPile = new List<Card>();
   
    void Start()
    {
       money = 11;  
    }

    // Update is called once per frame
    void Update()
    {
     moneyAmountText.text =  money.ToString(); 
     if (money == 0)
            
            rerollbutton.interactable = false; 
    }


    public void reroll(){
        money -= 1;
        Debug.Log("worked");
    }

    public void discard(){
        money += 1;
        Debug.Log("Moneten");
    }

    public void smash(){
        SceneManager.LoadScene ("SmashScene");
    }

}
