using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float backSpeed = 1;
    [SerializeField] private float rotationSpeed = 0.1f;
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
        
        if (Input.GetKey(KeyCode.W) && !isInBuilding && speed <= maxSpeed)
        {
            rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
            drag = rb.drag;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * backSpeed);
            drag = rb.drag;

        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !isInBuilding && speed <= maxSpeed || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            yRotation += rotationSpeed * Time.deltaTime;
            yRotation = Mathf.Clamp(yRotation, 0f, 90);
            transform.Rotate (0, yRotation, 0);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && !isInBuilding && speed <= maxSpeed || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {

            yRotation += rotationSpeed * Time.deltaTime;
            yRotation = Mathf.Clamp(yRotation, 0f, 90);
            transform.Rotate(0, -yRotation, 0);
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
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.Sleep();
            isInBuilding = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            isInBuilding = false;
        }
    }

}

