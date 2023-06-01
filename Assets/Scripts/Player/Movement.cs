using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IGameEventListener
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
    public GameEvent countdownStart;
    public intAmount canGo;

    public AudioSource carOff;
    public AudioSource carOn;
    public AudioSource carDriving;
    private int soundCheck = 0;
    private bool WPressCheck = false;
    private bool SPressCheck = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        countdownStart.RegisterListener(this);
    }
    void sounds()
    {
        if (WPressCheck == false && SPressCheck == false && soundCheck!=0)
        {
            carDriving.Stop();
            carOff.Play();
            soundCheck = 0;
        }
        

        if (Input.GetKeyDown(KeyCode.W) && soundCheck<=0)
        {
            carOn.Play();
             carDriving.Play();
            soundCheck = -1;
        }
        if (Input.GetKeyDown(KeyCode.S) && soundCheck>=0)
        { 
            carOn.Play();
            carDriving.Play();
            soundCheck = 1;

        }
        if (Input.GetKey(KeyCode.S))
        {
        SPressCheck = true;
        Debug.Log("S");
        }                 

        if (Input.GetKey(KeyCode.W))
        {
        WPressCheck = true;
        Debug.Log("W");
        }                   
        if (Input.GetKeyUp(KeyCode.S))
        {
            SPressCheck = false;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            WPressCheck = false;
        }
    }

    void Update()
    {   sounds();

        if (canGo.amount < 1)
            return;
        
       
        Brake();
        
        // if (Input.GetKeyDown(KeyCode.W) && soundCheck<=0)
        // {
        //     carOn.Play();
        //      carDriving.Play();
        //     soundCheck = -1;
        // }

        // if (Input.GetKeyUp(KeyCode.W)) //&& Input.GetKeyUp(KeyCode.S))
        // {
        //     carDriving.Stop();
        //     carOff.Play();
        //     soundCheck = 0;
        // }

        // if (Input.GetKeyDown(KeyCode.S) && soundCheck>=0)
        // { 
        //     carOn.Play();
        //     carDriving.Play();
        //     soundCheck = 1;
        // }
        // if (Input.GetKeyUp(KeyCode.S) && soundCheck>=0)
        // {
        //     carDriving.Stop();
        //     carOff.Play();
        // }

        //if (Input.GetKeyUp(KeyCode.S))
        //{ carDriving.Stop();
        //  carOff.Play();
        //    soundCheck = 0;
        //}
        

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
        if (canGo.amount < 1)
            return;

        if (gameObject.tag == "Building")
        {
            Debug.Log("1");
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.Sleep();
            isInBuilding = true;

        }
    }

    public void Notify()
    {
        
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

