﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarpetCollider : MonoBehaviour {

	public GameObject player;


	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update(){
		if (player.GetComponent<BoxCollider2D> ().IsTouching (gameObject.GetComponent<BoxCollider2D> ()) && (player.GetComponent<SpriteRenderer> ().sprite.name == "South_0" ||player.GetComponent<SpriteRenderer> ().sprite.name == "South_1" ||player.GetComponent<SpriteRenderer> ().sprite.name == "South_2")) {
			string currentScene = SceneManager.GetActiveScene ().name;
			PlayerPrefs.SetString ("LastScene", currentScene);
			PlayerPrefs.Save ();


			SceneManager.LoadScene ("MainGame");
		}

	}
	
}
