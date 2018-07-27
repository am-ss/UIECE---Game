using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	private Animator anim;
	public float velocidade;
	// Use this for initialization
	void Start () {
		velocidade = 10f;
		rb = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate(){
		float move = Input.GetAxisRaw ("Horizontal");
		rb.velocity = new Vector2 (move*velocidade, rb.velocity.y);
		anim.SetFloat ("Velocity", Mathf.Abs (move));
	}
}
