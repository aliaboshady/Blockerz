using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform playerTransform;
	public Text text;
	int initPos = 0;

	private void Start()
	{
		initPos = (int)playerTransform.position.z;
	}

	void Update(){
		text.text = (playerTransform.position.z - initPos).ToString("0");
	}
}
