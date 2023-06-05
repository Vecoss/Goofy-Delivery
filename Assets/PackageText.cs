using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PackageText : MonoBehaviour, IGameEventListener
{

    public GameEvent packageEvent;
    public intAmount packageAmount;
    public TextMeshProUGUI amount;

    public void Notify()
    {
        amount.text = "Packages Delivered: " + packageAmount.amount + "/3";
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
