using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    public GameObject Car1;
    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        Car1.GetComponent<Movement>().enabled = false;

        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;

        }

        countdownDisplay.text = "GO";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

        Car1.GetComponent<Movement>().enabled = true;
    }

}

  

