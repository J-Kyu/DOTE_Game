using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCube : MonoBehaviour {

	[SerializeField] private GameObject nextStageUI =  null;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			Debug.Log("Game Comeplete");
			nextStageUI.gameObject.SetActive(true);
		}
	}
}
