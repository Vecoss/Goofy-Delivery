using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinningListener : MonoBehaviour, IGameEventListener
{
    //public intAmount packages;
   // public Movement movement;
    private int winCondition = 0;
    public GameEvent gameEventToListen;
    public GameEvent packageDeliveredEvent;
    public GameEvent packagePickedUpEvent;

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
        SceneManager.LoadScene("VictoryScene");
         Destroy(gameObject);
         if (winCondition%2==1)
         {packagePickedUpEvent.Fire();}
         else {packageDeliveredEvent.Fire();}
       // win.enabled = true; 
     //   movement.enabled = false;
        }
    }
    

    private void OnDisable()
    {
        gameEventToListen.UnregisterListener(this);
    }
}