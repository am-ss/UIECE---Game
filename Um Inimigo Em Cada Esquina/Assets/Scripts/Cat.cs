using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {
	public float velocityMove; //velocidade de movimento
	private Rigidbody2D rb;
	private float timeInGame; //Tempo que o cão permanece em jogo
	public float timeLimit;  //Tempo limite para o cão ser deletado
	private Collider2D objCol;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		objCol = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		timeInGame += Time.deltaTime;
		rb.velocity = new Vector2 (velocityMove, 0.1f);
		if (timeInGame >= timeLimit) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player") {
			objCol.isTrigger = true;

		}
	}
}
