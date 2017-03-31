using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour {
    public float Delay = 3f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, Delay);	
	}

}
