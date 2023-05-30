using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessDisplay : MonoBehaviour
{
  //  public TMP_Text pickupthepackage;
   public bool mode = true;
    public TMP_Text pickupdeliverthepackage;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {       
            pickupdeliverthepackage.text = "Pick up the Package";
            counter=1;
    }

    // Update is called once per frame

void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package")  && (counter==1))
        {
            pickupdeliverthepackage.text = "Deliver the Package";
          //  mode=false;
      //  pickupthepackage.SetActive(false);
       // deliverthepackage.SetActive(true);
        Debug.Log("jeden");
        counter=0;}
        else if (collision.gameObject.CompareTag("Package")  && (counter==0)) 
        { //  mode=true;
        pickupdeliverthepackage.text = "Pick up the Package";
        //    pickupthepackage.SetActive(true);
        //    deliverthepackage.SetActive(false);
        Debug.Log("dwa");
            counter=1;
        }
    }
    }

