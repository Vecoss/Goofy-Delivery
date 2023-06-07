using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Here we count delivered Packages :)

public class PackageText : MonoBehaviour, IGameEventListener
{

    public GameEvent packageEvent;
    int packageA=0;
    public TextMeshProUGUI amount;

    public void Notify()
    {
        packageA++;
        amount.text = "Packages Delivered: " + (packageA/2) + "/3";
    }
    

    private void Start()
    {
        packageEvent.RegisterListener(this);
    }
    private void OnDestroy()
    {
        packageEvent.UnregisterListener(this);
    }
}
