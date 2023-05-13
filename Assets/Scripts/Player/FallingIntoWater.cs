using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingIntoWater : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);

            SceneManager.LoadScene("LoseScene");
        }
    }
}
