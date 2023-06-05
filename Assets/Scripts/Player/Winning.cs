using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    public int winCon = 0;
    void Update()
    {
        if (winCon>=3)
        {
        SceneManager.LoadScene("LoseScene");
         Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
            winCon++; 
            Debug.Log("lol+1 byq");
             

        }
    }

}