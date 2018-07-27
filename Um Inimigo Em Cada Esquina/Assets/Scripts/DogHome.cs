using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogHome : MonoBehaviour {
	public Transform player;
	public GameObject dog;
	private bool dogIsHere;
	public int distanceToPlayer;
	// Use this for initialization
	void Start () {
		dogIsHere = false;
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector2.Distance (transform.position, player.transform.position);
		if (distance <= distanceToPlayer && dogIsHere == false) {
			dogIsHere = true;
			Instantiate (dog, transform.position, transform.rotation);

		}


	}
}
