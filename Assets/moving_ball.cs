using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//for moving into another scene

public class moving_ball : MonoBehaviour {

		Transform ball_t;
	// Use this for initialization
	void Start () {
		ball_t = GetComponent<Transform>();
	}
	
	void OnCollisionEnter(Collision collision){
        switch(collision.gameObject.tag){
			case "_enter_lv1":
				print("enter lv1");
				SceneManager.LoadScene(0);
				break;
			case "_enter_lv2":
				print("enter lv2");
				SceneManager.LoadScene("level_2");
				break;
			default:
				print("qwer fuck you ufkc fuckfuckfuckcufkfhf fdudmf");
				break;
		}
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.S)){
			ball_t.localPosition += new Vector3(0,0,1);
		}
		
		if(Input.GetKey(KeyCode.A)){
			ball_t.localPosition += new Vector3(0,0,-1);
		}
		if(Input.GetKey(KeyCode.Keypad1)){
				print("enter lv1,keypad");
				SceneManager.LoadScene(0);		
		}
		
		if(Input.GetKey(KeyCode.Keypad2)){
				print("enter lv2,keypad");
				SceneManager.LoadScene("level_2");	
		}
		
	}
}
