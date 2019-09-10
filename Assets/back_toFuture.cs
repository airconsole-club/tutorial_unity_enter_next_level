using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//for moving into another scene
public class back_toFuture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.Q)){
				print("enter lv1,keypad");
				SceneManager.LoadScene(0);		
		}
		
		if(Input.GetKey(KeyCode.W)){
				print("enter lv2,keypad");
				SceneManager.LoadScene("level_2");	
		}
	}
}
