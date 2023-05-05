using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float backSpeed = 3;
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float drag = 1;
    [SerializeField] private float breakForce = 2;
    private bool isInBuilding = false;
    private float yRotation = 0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }


    void Update()
    {
       
        Brake();
        
        if (Input.GetKey(KeyCode.W) && !isInBuilding && rb.velocity.magnitude <= maxSpeed)
        {
            rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
            drag = rb.drag;
            
        }
        if (Input.GetKey(KeyCode.S) && !isInBuilding && rb.velocity.magnitude <= maxSpeed)
        {
            rb.AddForce(-transform.forward * backSpeed);
            drag = rb.drag;

        }
        if (((Input.GetKey(KeyCode.W) && !isInBuilding) || Input.GetKey(KeyCode.S)) && Input.GetKey(KeyCode.D) && rb.angularVelocity.magnitude <= 1)
        {

            
            yRotation += rotationSpeed * Time.deltaTime;
            yRotation = Mathf.Clamp(yRotation, 0f, 90);
            Quaternion deltarotation = Quaternion.Euler(0f, yRotation * Time.deltaTime, 0f);
            rb.MoveRotation(rb.rotation * deltarotation);
        }
        if (((Input.GetKey(KeyCode.W) && !isInBuilding) || Input.GetKey(KeyCode.S)) && Input.GetKey(KeyCode.A) && rb.angularVelocity.magnitude <= 1)
        {

            yRotation += rotationSpeed * Time.deltaTime;
            yRotation = Mathf.Clamp(yRotation, 0f, 90);
            Quaternion deltarotation = Quaternion.Euler(0f, -yRotation * Time.deltaTime, 0f);
            rb.MoveRotation(rb.rotation * deltarotation);
        }

    }

    void Brake()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            drag *= breakForce;           
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (gameObject.tag == "Building")
        {
            Debug.Log("1");
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.Sleep();
            isInBuilding = true;

        }
    }
   /* private void OnCollisionExit(Collision collision)
    {

        if (gameObject.tag == "Building")
        {
            isInBuilding = false;
        }
    }*/
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (gameObject.tag == "Building")
    //    {
    //        Debug.Log("1");
    //        Rigidbody rb = GetComponent<Rigidbody>();
    //        rb.Sleep();
    //        isInBuilding = true;

    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (gameObject.tag == "Building")
    //    {
    //        isInBuilding = false;
    //    }
    //}

}

