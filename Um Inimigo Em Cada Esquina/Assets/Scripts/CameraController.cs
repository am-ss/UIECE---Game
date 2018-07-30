using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform playerPosition;
	public Transform LimitPosition;
	public float distance;
	public bool canFollow;
	// Use this for initialization
	void Start () {
		canFollow = false;
	}
	
	// Update is called once per frame
	void Update () {
		distance = (playerPosition.position.x - LimitPosition.position.x);
		if (Mathf.Abs(distance) <= 0.4f ) {
			canFollow = true;

		}

		if (canFollow == true) {
			transform.position = new Vector3 (playerPosition.position.x, transform.position.y, transform.position.z);
		}
	}
}
