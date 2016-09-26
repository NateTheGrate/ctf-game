﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float moveForce = 1000;

    public float flyForce = 600;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Fixed Update is called for every physics operation (not frame dependent)
    void FixedUpdate() {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //apply forces on x and z axis
        rb.AddForce(movement * moveForce * Time.deltaTime);

        //jetpack
        if (Input.GetButton("Jump")) {
            Vector3 jetPack = new Vector3(0.0f, flyForce, 0.0f); //add force only on y axis
            rb.AddForce(jetPack * Time.deltaTime);
        }
        
    }
}
