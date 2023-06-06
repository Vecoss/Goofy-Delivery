using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Delivery : MonoBehaviour
{

    public GameEvent anyPackageEvent;
    int soundChecker = 0;
    public AudioSource collect;
    public AudioSource deliver;


    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Package"))
        {
            soundChecker++;
            collect.Play();
            anyPackageEvent.Fire();

            
        }
        if ((collision.gameObject.CompareTag("Package"))&&(soundChecker%2==0))
            {deliver.Play();}
        if ((collision.gameObject.CompareTag("Package"))&&(soundChecker%6==0))
            {SceneManager.LoadScene("VictoryScene");
             Destroy(gameObject);}
    }


}
