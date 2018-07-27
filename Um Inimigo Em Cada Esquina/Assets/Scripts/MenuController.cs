using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewGame(){
		SceneManager.LoadScene ("Cena 01");
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
