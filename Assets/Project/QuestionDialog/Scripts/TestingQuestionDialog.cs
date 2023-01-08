using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class TestingQuestionDialog : MonoBehaviour {


     public void quitMessage(){
            QuestionDialogUI.Instance.ShowQuestion("Willst du deinen ganzen Fortschritt verlieren?", () => {
                
                     SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
                 
                  
             
            }, () => {
                // Do nothing on No
            });
        }
    }