﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCaching : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<1000; i++)
        {
            GameObject.Find("Directional Light").GetComponent<Light>().intensity = 1;
        }
	}
}
