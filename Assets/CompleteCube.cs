using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCube : MonoBehaviour {

    [SerializeField] private GameObject nextStageUI = null;
    [SerializeField] private Player player = null;

	[SerializeField] private GameObject EndUI =null;

    private bool clearedCube = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !clearedCube) {
            Debug.Log("Game Comeplete");
			player.level++;
			if(player.level<3){
            nextStageUI.gameObject.SetActive(true);
            
            Debug.Log("Player Level:" + player.level);
            clearedCube = true;
			}
			else{
				EndUI.SetActive(true);
			}
        }
    }

    public void Next() {
        switch (player.level) {
            case 0:
                player.transform.position = new Vector3(5, 3, 5);
                break;
            case 1:
                player.transform.position = new Vector3(55, 3, 5);
                break;
            case 2:
                player.transform.position = new Vector3(105, 3, 5);
                break;
            default:
                Debug.Log("Game is Cleared");
                break;
        }

    }
}
