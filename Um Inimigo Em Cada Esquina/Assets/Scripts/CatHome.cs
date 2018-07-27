using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHome : MonoBehaviour {
	public Transform startPosition;
	public Transform endPosition;
	private bool detectPlayer;
	private bool itIsHere; //Detecta se o evento do gato sair da lixeira é verdadeiro
	public GameObject cat;
	private Animator anim;
	// Use this for initialization
	void Start () {
		detectPlayer = false;
		itIsHere = false;
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (startPosition.transform.position, endPosition.transform.position, Color.green);
		detectPlayer = Physics2D.Linecast (startPosition.transform.position, endPosition.transform.position, 1 << LayerMask.NameToLayer("Player"));
		if (detectPlayer && itIsHere == false) {
			anim.SetTrigger ("ItsOpen");
			Instantiate (cat, new Vector3 (transform.position.x, (transform.position.y + 0.8f), transform.position.z), transform.rotation);
			itIsHere = true;
	}
}
}
