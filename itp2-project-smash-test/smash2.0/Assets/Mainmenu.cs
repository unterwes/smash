using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
     public void PlayGame () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
 }

 public void Shop () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
 }
 
public void Options () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 3);
 }

 public void QuitGame ()
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }
  
}

