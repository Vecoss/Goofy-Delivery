using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseGameEventListener : MonoBehaviour, IGameEventListener
{
    public GameEvent gameEventToListen;
    public UnityEvent response;

    private void OnEnable()
    {
        gameEventToListen.RegisterListener(this);
    }

    public void Notify()
    {
        response?.Invoke();
    }

    private void OnDisable()
    {
        gameEventToListen.UnregisterListener(this);
    }
}
