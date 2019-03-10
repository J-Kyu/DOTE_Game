using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour {

    // Use this for initialization
	[SerializeField] private Player player = null;
    [SerializeField] private GameObject[] dangerObstacle = null;
    [SerializeField] private GameObject[] safeObstacle = null;

	[SerializeField] private GameObject OriDangerObstacle = null;
    [SerializeField] private GameObject OriSafeObstacle = null;
    private List<Vector3> DObstacles = new List<Vector3>();
    private List<Vector3> SObstacles = new List<Vector3>();



    void Start() {
		 for (int i = 0; i < dangerObstacle.Length; i++) {
            DObstacles.Add(dangerObstacle[i].gameObject.transform.position);		
        }

        for (int i = 0; i < safeObstacle.Length; i++) {
            SObstacles.Add(safeObstacle[i].gameObject.transform.position);		
        }




    }

    // Update is called once per frame
    void Update() {

    }

    public void ResetObject() {

		player.isControl =true;

		Debug.Log("DObstacles size:"+DObstacles.Count);
		Debug.Log("dangerObstacle size:"+dangerObstacle.Length);

        for (int i = 0; i < dangerObstacle.Length; i++) {
			Destroy(dangerObstacle[i]);
			dangerObstacle[i]=(Instantiate(OriDangerObstacle,new Vector3(DObstacles[i].x,DObstacles[i].y,DObstacles[i].z),Quaternion.identity));

           
        }

        for (int i = 0; i < safeObstacle.Length; i++) {
           Destroy(safeObstacle[i]);
			safeObstacle[i]=(Instantiate(OriSafeObstacle,new Vector3(SObstacles[i].x,SObstacles[i].y,SObstacles[i].z),Quaternion.identity));

        }

    }
}
