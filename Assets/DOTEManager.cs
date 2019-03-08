using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTEManager : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private GameObject gameOverUI = null;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




	public void Retry(){
		//장애물 새로 만들기
		//원위치
		gameOverUI.SetActive(false);

	}

	public void BackToMenu(){
		//Menu 로 돌아가기....maybe Scene 바꾸기
		gameOverUI.SetActive(false);

	}
}
