﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgSoundScript : MonoBehaviour {

	public AudioClip townClip;
	public AudioClip routeClip;

	// Use this for initialization
	void Start () {
		
	}

	//play global
	private static BgSoundScript instance = null;
	public static BgSoundScript Instance
	{
		get { return instance; }
	}


	void Awake()
	{
		if (instance != null && instance != this) {

			Destroy (this.gameObject);
			return;

		} else {

			instance = this;
		}

		DontDestroyOnLoad (this.gameObject);

	}
	//play global end
	
	// Update is called once per frame
	void OnLevelWasLoaded () {

		if (SceneManager.GetActiveScene().name == "PlayerHouseTop") 
		{
			gameObject.GetComponent<AudioSource> ().clip = townClip;
			gameObject.GetComponent<AudioSource> ().Play ();
		}
			
	}
}
