using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour {
	public GameObject npc1;
	public GameObject npc2;
	public GameObject npc3;
	public GameObject npc4;
	public GameObject npc5;
	public GameObject npc6;
	public GameObject npc7;
	public GameObject npc8;
	public GameObject npc9;
	public GameObject npc10;
	public float value;
	public float Timer;
	public Transform playerPosition;
	public float timeLimit;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer >= timeLimit) {
			value = Random.value * 100;
			if (value >= 0 && value < 10) {
				Instantiate (npc1, transform.position, transform.rotation);
			}
			if (value >= 10 && value < 20) {
				Instantiate (npc2, transform.position, transform.rotation);
			}
			if (value >= 20 && value < 30) {
				Instantiate (npc3, transform.position, transform.rotation);
			}
			if (value >= 30 && value < 40) {
				Instantiate (npc4, transform.position, transform.rotation);
			}
			if (value >= 40 && value < 50) {
				Instantiate (npc5, transform.position, transform.rotation);
			}
			if (value >= 50 && value < 60) {
				Instantiate (npc6, transform.position, transform.rotation);
			}
			if (value >= 60 && value < 70) {
				Instantiate (npc7, transform.position, transform.rotation);
			}
			if (value >= 70 && value < 80) {
				Instantiate (npc8, transform.position, transform.rotation);
			}
			if (value >= 80 && value < 90) {
				Instantiate (npc9, transform.position, transform.rotation);
			}
			if (value >= 90 && value < 100) {
				Instantiate (npc10, transform.position, transform.rotation);
			}
			Timer = 0;
		}

		transform.position = new Vector3 ((playerPosition.position.x + 45.01f), transform.position.y, transform.position.z);
	}

}
