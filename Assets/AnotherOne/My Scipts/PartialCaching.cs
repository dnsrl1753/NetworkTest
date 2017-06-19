using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartialCaching : MonoBehaviour {

    private GameObject directionalLight;

	// Use this for initialization
	void Start () {
        directionalLight = GameObject.Find("Directional Light");
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<1000; i++)
        {
            directionalLight.GetComponent<Light>().intensity = 1;
        }
	}
}
