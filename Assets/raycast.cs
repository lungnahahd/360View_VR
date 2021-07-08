﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        raycasting();
    }


    void raycasting(){
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward *1000);
        if(Physics.Raycast(transform.position, forward, out hit)){
            hit.transform.GetComponent<Button>().onClick.Invoke();
            Debug.Log("HIT");
        }
        Debug.DrawRay(transform.position, forward, Color.blue);
    }
}