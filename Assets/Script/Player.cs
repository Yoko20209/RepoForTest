using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        Debug.Log("Alien?");
        if(other.tag == "Alien")
        { 
            Debug.Log("YES");
            GetComponent<Eaten>().wasEaten = true;
            transform.gameObject.tag = "Ghost";

        }
    }
}
