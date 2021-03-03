using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        Debug.Log("alien?");
        if(other.tag == "Alien")
        { 
            Debug.Log("yep");
            GetComponent<Eaten>().wasEaten = true;
            transform.gameObject.tag = "Ghost";

        }
    }
}
