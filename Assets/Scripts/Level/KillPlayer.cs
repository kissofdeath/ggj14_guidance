﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public GameObject playerOne;
	public GameObject playerTwo;

	private IKillable playerOneKill;
	private IKillable playerTwoKill;

	//public LevelController Controller;


	void Start () 
	{
		//Get the script of players that does the Killing
		playerOneKill = (IKillable)playerOne.GetComponent(typeof(IKillable));
		playerTwoKill = (IKillable)playerTwo.GetComponent(typeof(IKillable));
	}


	void Update () 
	{

	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject == playerOne)
		{
			playerOneKill.Kill();
		}
		if (collider.gameObject == playerTwo)
		{
			playerTwoKill.Kill();
		}
	}
}
