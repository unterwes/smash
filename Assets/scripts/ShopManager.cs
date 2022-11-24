using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{

public int coins;
public int coins2;
public int coins3;
public int coins4;
public int coins5;
public int coins6;
public int coins7;
public TMP_Text coinUI;
public TMP_Text coinUI2;
public TMP_Text coinUI3;
public TMP_Text coinUI4;
public TMP_Text coinUI5;
public TMP_Text coinUI6;
public TMP_Text coinUI7;

public int price = 0;


void Start(){
    coinUI.text =  coins.ToString();
    coinUI2.text =  coins.ToString();
    coinUI3.text =  coins.ToString();
    coinUI4.text =  coins.ToString();
    coinUI5.text =  coins.ToString();
    coinUI6.text =  coins.ToString();
    coinUI7.text =  coins.ToString();
}


// public void AddCoins(){
//     coins = price ++;
//     coinUI.text =   coins.ToString();

//   //  CheckPurchaseable();
    

// }

public void AddCoins2(){

    coins2 = price + 10 ;
    price = price + 10 ;
    coinUI2.text =  coins2.ToString();
  //  CheckPurchaseable();
    

}

public void AddCoins3(){

    coins3 = price + 30 ;
    price = price + 30;
    coinUI3.text =  coins3.ToString();
  //  CheckPurchaseable();
    

}

public void AddCoins4(){

    coins4 = price + 60 ;
    price = price + 60;
    coinUI4.text =  coins4.ToString();
  //  CheckPurchaseable();
    

}

public void AddCoins5(){

    coins5 = price + 100 ;
    price = price + 100;
    coinUI5.text =  coins5.ToString();
  //  CheckPurchaseable();
    

}

public void AddCoins6(){

    coins6 = price + 250 ;
    price = price + 250;
    coinUI6.text =  coins6.ToString();
  //  CheckPurchaseable();
    

}

public void AddCoins7(){

    coins7 = price - 10 ;
    price = price - 10;
    coinUI7.text =  coins7.ToString();
  //  CheckPurchaseable();
    

}
}
