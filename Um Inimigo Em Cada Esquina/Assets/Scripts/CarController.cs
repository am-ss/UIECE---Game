using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	public GameObject car1;
	public GameObject car2;
	public GameObject car3;
	public GameObject car4;
	public GameObject car5;
	public GameObject car6;
	public GameObject bus;
	public float value;
	public float Timer;
	public Transform playerPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer >= 5) {
			value = Random.value * 100;
			if (value >= 0 && value < 14.28f) {
				Instantiate (car1, transform.position, transform.rotation);
			}
			if (value >= 14.28f && value < 28.57f) {
				Instantiate (car2, transform.position, transform.rotation);
			}
			if (value >= 28.57f && value < 42.85f) {
				Instantiate (car3, transform.position, transform.rotation);
			}
			if (value >= 42.85f && value < 57.13f) {
				Instantiate (car4, transform.position, transform.rotation);
			}
			if (value >= 57.13f && value < 71.41f) {
				Instantiate (car5, transform.position, transform.rotation);
			}
			if (value >= 71.41f && value < 85.69f) {
				Instantiate (car6, transform.position, transform.rotation);
			}
			if (value >= 85.69f && value < 100) {
				Instantiate (bus, transform.position, transform.rotation);
			}
			Timer = 0;
		}

		transform.position = new Vector3 ((playerPosition.position.x + 45.01f), -4.72f, 0);
	}
}
