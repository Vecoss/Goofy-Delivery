using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// This code is no longer used, it how win condition looked

public class PackageWin : MonoBehaviour
{

    public intAmount packages;
    public Movement movement;
    public TextMeshProUGUI win;
    private int winCondition = 6;

    private void Awake()
    {
        win.enabled = false;
    } 
    void Update()
    {
        if(packages.amount == winCondition)
        {
            win.enabled = true;
            movement.enabled = false;

        }
    }
}
