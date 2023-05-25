using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    public GameEvent countdownStart;
    public intAmount canGo;
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {

        countdownStart.Fire();
        canGo.amount = 0;
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;

        }

        countdownDisplay.text = "GO";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        canGo.amount = 1;
        countdownStart.Fire();
    }

}

  

