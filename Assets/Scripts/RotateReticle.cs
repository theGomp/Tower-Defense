﻿using UnityEngine;
using System.Collections;

public class RotateReticle : MonoBehaviour {

    public GameObject camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.rotation = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0);
	}
}
