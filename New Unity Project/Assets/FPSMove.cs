﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update ()
    {
		if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;  
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }










    }
}
