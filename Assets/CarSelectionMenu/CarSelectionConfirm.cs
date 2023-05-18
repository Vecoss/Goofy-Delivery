using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionConfirm : MonoBehaviour
{
    public GameEvent gameEventToRaiseOnInteraction;
    public CarSelection CarSelection;

    public void Confirm()
    {
        gameEventToRaiseOnInteraction.Fire();
    }
}
