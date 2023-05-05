using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] public Transform target;
    private bool isFPC = false;

    private void Awake()
    {
        FPC();

    }

    void Update()
    {
        FPC();
        TPC();
    }

    private void FPC()
    {
        if (Input.GetKeyDown(KeyCode.C) && !isFPC)
        {
            gameObject.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(target.transform.rotation.x, target.transform.rotation.y, target.transform.rotation.z);
            isFPC = true;
        }
    }

    private void TPC()
    {
        if (Input.GetKeyDown(KeyCode.C) && isFPC)
        {
            gameObject.transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 2f, target.transform.position.z - 3.5f);
            gameObject.transform.rotation = Quaternion.Euler(target.transform.rotation.x + 15, target.transform.rotation.y, target.transform.rotation.z);
            isFPC = false;
        }
    }
}
