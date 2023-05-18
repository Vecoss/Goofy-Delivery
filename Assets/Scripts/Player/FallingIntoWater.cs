using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingIntoWater : MonoBehaviour
{
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 4)
        {
            SceneManager.LoadScene("LoseScene");
            Destroy(gameObject);
        }
    }

}
