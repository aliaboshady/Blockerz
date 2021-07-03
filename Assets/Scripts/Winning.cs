using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour {
	public GameManager gameManager;

	void OnTriggerEnter(){
		gameManager.Win ();
	}
}