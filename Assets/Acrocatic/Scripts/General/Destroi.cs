using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour {

    public float tempo = 2f;

	void Start () {
        
        Destroy(gameObject, tempo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
