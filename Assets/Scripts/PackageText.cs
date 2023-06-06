using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PackageText : MonoBehaviour, IGameEventListener
{

    public GameEvent packageEvent;
    //public intAmount packageAmount;
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
