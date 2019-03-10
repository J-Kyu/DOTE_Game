using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    private float m_Speed = 0.1f;
    private bool isJump = false;
    private bool isFakeTile =false;

    public bool isControl = true;

    private float jumpTime = 1.0f;
	[SerializeField]private GameObject gameOver = null;

    public int level = 0;
	//Level 1: x-> 5, z->-65
	//Level 2: x-> 55, z //

    // Use this for initialization
    void Start() {

        
    }

    // Update is called once per frame
    void Update() {

        //keyboaard 값을 입력하여 움직이는 것
		if(this.transform.position.y<-10){
			GameOver();
		}

        if(isControl){
             Move();
        }
       

        if(isJump==true){
        Debug.Log("JUMP");
        transform.Translate(new Vector3(0, 1, 0)*m_Speed);

            jumpTime-=Time.deltaTime;
            if(jumpTime<0){
                jumpTime = 1.0f;
                isJump =false;
            }

        }
        if(isFakeTile==true){
        Debug.Log("Fake    JUMP");
        isControl =false ;
        transform.Translate(new Vector3(0, 1, 5)*5*m_Speed);

            jumpTime-=Time.deltaTime;
            if(jumpTime<0){
                jumpTime = 1.0f;
                isFakeTile =false;
                isControl = true;
            }

        }



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
            isControl = false;
			//game oVer
        }
		else if(other.gameObject.CompareTag("Jump"))
        {
           isJump=true;
        }
        else if(other.gameObject.CompareTag("FakeJumpTile"))
        {
           isFakeTile=true;
        }
    }

	public void GameOver(){
	
			gameOver.SetActive(true);
		
	}

}
