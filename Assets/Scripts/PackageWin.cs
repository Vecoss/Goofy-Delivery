using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PackageWin : MonoBehaviour
{

    public ItemCollector packages;
    public Movement movement;
    public TextMeshProUGUI win;
    private int winCondition = 10;

    private void Awake()
    {
        win.enabled = false;
    }
    void Update()
    {
        if(packages.packages == winCondition)
        {
            win.enabled = true;
            movement.enabled = false;

        }
    }
}