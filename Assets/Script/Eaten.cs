using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaten : MonoBehaviour
{   
    public GameObject eatenScreen;
    public bool wasEaten = false;

    void Start()
    {
        eatenScreen.SetActive(false);
    }

    void Update()
    {
        if(wasEaten){
            eatenScreen.SetActive(true);
        }else{
            eatenScreen.SetActive(false);
        }
    }
}
