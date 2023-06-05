using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextChanges : MonoBehaviour, IGameEventListener
{
    //public intAmount packages;
   // public Movement movement;
    private int winCondition = 0;
    public GameEvent gameEventToListen;

    private void OnEnable() 
    {
        if (gameEventToListen != null) gameEventToListen.RegisterListener(this);
    }

    public void Notify()
    {
        winCondition++;
        Debug.Log("+1");
        if (winCondition==2) 
        {
        Debug.Log("Wygrana");
        SceneManager.LoadScene("LoseScene");
         Destroy(gameObject);
       // win.enabled = true; 
     //   movement.enabled = false;
        }
    }
    

    private void OnDisable()
    {
        gameEventToListen.UnregisterListener(this);
    }
}