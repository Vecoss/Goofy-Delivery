using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionConfirm : MonoBehaviour
{
    public GameEvent gameEventToRaiseOnInteraction;
    public intAmount CarSelection;

    public void Confirm()
    {
        gameEventToRaiseOnInteraction.Fire();
    }
}
