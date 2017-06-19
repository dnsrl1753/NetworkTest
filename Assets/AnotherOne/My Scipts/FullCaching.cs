using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullCaching : MonoBehaviour {

    private Light directionalLight;

	// Use this for initialization
	void Start () {
        directionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<1000; i++)
        {
            directionalLight.intensity = 1;
        }
	}
}
