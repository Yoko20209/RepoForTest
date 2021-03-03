using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaten : MonoBehaviour
{   
    public GameObject eatenScreen;
    public bool wasEaten = false;

    // Start is called before the first frame update
    void Start()
    {
        eatenScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(wasEaten){
            eatenScreen.SetActive(true);
        }else{
            eatenScreen.SetActive(false);
        }
    }
}
