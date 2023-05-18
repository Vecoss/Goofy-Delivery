using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int packages = 0;

    [SerializeField] private TextMeshProUGUI packagesText;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
            packages++;
            packagesText.text = "Packages: " + packages;
            Destroy(collision.gameObject);
        }
    }
}
