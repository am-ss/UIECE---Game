using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleScript : MonoBehaviour {
	private Animator anim;
	private Collider2D objCol;
	public bool bottleDown;
	// Use this for initialization
	void Start () {
		bottleDown = false;
		anim = gameObject.GetComponent<Animator> ();
		objCol = GetComponent<Collider2D> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			anim.SetTrigger ("BottleFall");
			objCol.isTrigger = true;
			bottleDown = true;
		}
	}
}
