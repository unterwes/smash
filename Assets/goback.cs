using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goback : MonoBehaviour
{


 public void backFromGame () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
 }
  
public void backFromShop () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
 }



}

