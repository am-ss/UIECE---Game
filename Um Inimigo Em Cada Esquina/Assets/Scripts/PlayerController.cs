using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	private Animator anim;
	public float velocidade;
	private bool faceRight;
	public float jumpForce;
	public Transform groundCheck;
	private bool onGround;
	private bool canJump;
	public int playerLife;
	private bool getDamage;
	public Text countLife;
	private bool canRun;
	// Use this for initialization
	void Start () {
		velocidade = 10f;
		rb = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
		faceRight = true;
		canJump = true;
		getDamage = false;
		canRun = true;
	}
	
	// Update is called once per frame
	void Update () {
		countLife.text = "x" + playerLife.ToString();
		print (playerLife);
		PlayerDamage();
		PlayerOff ();
	}
	void FixedUpdate(){
		float move;
		move = Input.GetAxisRaw ("Horizontal");
		if (canRun) {
			rb.velocity = new Vector2 (move * velocidade, rb.velocity.y);
		} 
		anim.SetFloat ("Velocidade", Mathf.Abs (move));

		if (faceRight && move < 0) {
			Flip ();
		} 
		else if (faceRight == false && move > 0) {
			Flip ();
		}

		if (Input.GetButtonDown ("Jump")) {
			if (canJump) {
				Jump ();
			}

		}

		onGround = Physics2D.Linecast (transform.position, groundCheck.transform.position, 1 << LayerMask.NameToLayer ("Ground"));
		if (onGround == false) {
			canJump = false;
			//anim.SetBool ("Pulando", false);
		} 
		else if(onGround == true && playerLife > 0) {
			canJump = true;
		}
			
		if (onGround) {
			anim.SetBool ("Pulando", false);
		}
		else{
			anim.SetBool ("Pulando", true);
		}
	}



	void Flip(){
		faceRight = !faceRight;
		Vector3 Scale = transform.localScale;
		Scale.x *= -1;
		transform.localScale = Scale;
	}

	void Jump(){
		anim.SetBool ("Pulando", true);
		rb.AddForce (new Vector2 (0, jumpForce));

	}
		
	void PlayerDamage(){
		if (getDamage) {
			playerLife = playerLife - 1;
			getDamage = false;
		}

	}


	void PlayerOff(){
		if (playerLife <= 0) {
			anim.SetTrigger ("PlayerDead");
			velocidade = 0;
			canJump = false;
		}
	}


	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Inimigo") {
			getDamage = true;
		}
		if (coll.gameObject.tag == "Wall") {
			canRun = false;
		
		} 
		else {
			canRun = true;
		}
	}
}
