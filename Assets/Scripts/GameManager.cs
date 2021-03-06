using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public float restartDelay = 1f;
	public GameObject WinUI;

	public void EndGame () {
		Invoke("Restart", restartDelay);
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Win(){
		WinUI.SetActive (true);
	}
}
