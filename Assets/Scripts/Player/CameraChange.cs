using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private Transform FPCPoint;
    [SerializeField] private Transform TPCPoint;
    private bool isFPC = true;

    private void Awake()
    {
        CamerChange();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && isFPC)
        {
            isFPC = false;
        }
        else if (Input.GetKeyDown(KeyCode.C) && !isFPC)
        {
            isFPC = true;
        }
        CamerChange();
    }


    private void CamerChange()
    {
        if (isFPC)
        {
            gameObject.transform.position = new Vector3(FPCPoint.transform.position.x, FPCPoint.transform.position.y, FPCPoint.transform.position.z);
           
        }
        else
        {
            gameObject.transform.position = new Vector3(TPCPoint.transform.position.x, TPCPoint.transform.position.y, TPCPoint.transform.position.z);

        }
    }
}
