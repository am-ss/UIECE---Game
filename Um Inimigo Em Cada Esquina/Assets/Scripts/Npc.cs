﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour {
	public float velocidade;
	private float timerToDelete;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timerToDelete += Time.deltaTime;
		transform.Translate (-velocidade * Time.deltaTime, 0, 0);
		if (timerToDelete >= 40) {
			Destroy (gameObject);
		}
	}
}

