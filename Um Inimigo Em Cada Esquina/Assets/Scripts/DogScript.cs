using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour {
	private Rigidbody2D rb;
	public float velocidade; //velocidade  de movimento do cão
	private float timeInGame; //Tempo que o cão permanece em jogo
	public float timeLimit;  //Tempo limite para o cão ser deletado
	private bool collisionWithPlayer;
	private Collider2D objCol;

	// Use this for initialization
	void Start () {
		collisionWithPlayer = false;
	velocidade = -5f;
	rb = gameObject.GetComponent<Rigidbody2D> ();
		objCol = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		timeInGame += Time.deltaTime;
		if (timeInGame >= timeLimit) {
			Destroy (gameObject);
		}


		if(collisionWithPlayer == true){
			transform.Translate (velocidade*Time.deltaTime, 0, 0);
		}
	}

	void FixedUpdate() {
		rb.velocity = new Vector2 (velocidade, rb.velocity.y);
	}
		

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player") {
			objCol.isTrigger = true;
			rb.simulated = false;
			collisionWithPlayer = true;

		}
	}
}
