﻿using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {

    GameObject player;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            gameObject.GetComponent<Transform>().position -= new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.D))
            gameObject.GetComponent<Transform>().position += new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.W))
            gameObject.GetComponent<Transform>().position += new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.S))
            gameObject.GetComponent<Transform>().position -= new Vector3(0, 0, 1);
    }
}