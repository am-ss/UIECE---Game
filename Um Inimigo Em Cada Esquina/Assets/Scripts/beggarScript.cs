using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beggarScript : MonoBehaviour {
	public float velocityMove;
	private Rigidbody2D rd;
	public GameObject bottle; 
	private BottleScript bottleSc;
	private Animator anim;
	public Transform newPosition;
	private float clock;
	private Collider2D objCol;
	private bool collWithPlayer;
	private float timer;
	// Use this for initialization
	void Start () {
		rd = gameObject.GetComponent<Rigidbody2D> ();
		bottleSc = bottle.GetComponent<BottleScript> ();
		anim = gameObject.GetComponent<Animator> ();
		objCol = GetComponent<Collider2D> ();
		collWithPlayer = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (bottleSc.bottleDown == true) {
			clock += Time.deltaTime;
			anim.SetBool ("BottleDown", true);
			anim.SetBool ("InRun", true);
			if (clock >= 1.1) {
				transform.position = new Vector3 ((transform.position.x + velocityMove * Time.deltaTime), newPosition.transform.position.y, 0);
				if (collWithPlayer == false) {
					objCol.isTrigger = false;
				} else {
					objCol.isTrigger = true;
				}
				rd.simulated = true;

				timer += Time.deltaTime;
			}
		}


		if (timer >= 10) {
			Destroy (gameObject);

		}

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			collWithPlayer = true;
			objCol.isTrigger = true;

		}
	}
}
