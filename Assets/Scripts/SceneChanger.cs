﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown ("space")) {
			SceneManager.LoadScene ("Main");
		}
	}
}
