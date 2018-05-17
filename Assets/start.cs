using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonDown (0)){ 
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray,out hit,100.0f)) {
				SceneManager.LoadScene("planet berputar v2", LoadSceneMode.Additive);
			}
		}*/
	}

	public void StartGame(){
		SceneManager.LoadScene("menu", LoadSceneMode.Single);
	}
}
