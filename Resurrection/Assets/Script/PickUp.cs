using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    bool hasKey = false;
    bool hasBattery = false;

    public GameObject light;
    public GameObject key;
    public GameObject battery;
    // Start is called before the first frame update
    void Start() {
        light.SetActive(false);
        key.SetActive(false);
        battery.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        //if player touches flashlight
       if(collision.gameObject.CompareTag("light")) {
           light.SetActive(true);
           collision.gameObject.SetActive(false);
       }

        //when player collects key
       if(collision.gameObject.CompareTag("key")) {
           key.SetActive(true);
           hasKey = true;
           collision.gameObject.SetActive(false);
       }
        
        //when player touches door
       if(collision.gameObject.CompareTag("door")) {
           if(hasKey) {
               collision.gameObject.SetActive(false);
           }
       }
        //when player collect battery
       if(collision.gameObject.CompareTag("battery")) {
           hasBattery = true;
           collision.gameObject.SetActive(false);
       }
    }
}
