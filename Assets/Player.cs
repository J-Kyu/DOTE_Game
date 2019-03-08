using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private float m_Speed = 0.1f;
	[SerializeField]private GameObject gameOver = null;
    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update() {

        //keyboaard 값을 입력하여 움직이는 것
		if(this.transform.position.y<-1){
			GameOver();
		}
        Move();



    }

    private void Move() {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(new Vector3(0, 0, 1) * m_Speed);
        } 
		if (Input.GetKey(KeyCode.A)) {
            transform.Translate(new Vector3(-1, 0, 0) * m_Speed);

        }
		if (Input.GetKey(KeyCode.D)) {
            transform.Translate(new Vector3(1, 0, 0) * m_Speed);

        }
		if (Input.GetKey(KeyCode.S)) {
            transform.Translate(new Vector3(0, 0, -1) * m_Speed);

        }
    }

	void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy") ) {
            GameOver();
			//game oVer

        }
		
    }

	public void GameOver(){
	
			gameOver.SetActive(true);
		
	}

}
