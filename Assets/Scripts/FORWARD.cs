using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FORWARD : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}


    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Assets.Scripts.Global.speed, Camera.main.transform);
    }
}

