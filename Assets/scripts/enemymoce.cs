﻿using UnityEngine;
using System.Collections;

public class enemymoce : MonoBehaviour {

    public float speed = 5f;
	void Start () {
	
	}

	void Update () {
        transform.Translate(new Vector3(0,1*speed*Time.deltaTime,0));
	}
}
