﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallCollector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D target)
    {
           
        if (target.tag == "ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
