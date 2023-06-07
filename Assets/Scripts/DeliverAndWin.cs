using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DeliverAndWin : MonoBehaviour
{
    // this one ended up triggering sounds and win con

    public GameEvent anyPackageEvent;
    
int soundAndWinChecker = 0;
    public AudioSource collect;
    public AudioSource deliver;


    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Package"))
        {
            soundAndWinChecker++;
            collect.Play();
            anyPackageEvent.Fire();

            
        }
        if ((collision.gameObject.CompareTag("Package"))&&(soundAndWinChecker%2==0))
            {deliver.Play();}
        if ((collision.gameObject.CompareTag("Package"))&&(soundAndWinChecker%6==0))
            {SceneManager.LoadScene("VictoryScene");
             Destroy(gameObject);}
    }


}
