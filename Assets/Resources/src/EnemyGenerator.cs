using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	private int total_enemy_types = 1; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			GenerateEnemy(1);
		}
	}



	private void GenerateEnemy(int enemy_type){

		switch (enemy_type) {
		case 1:
			Debug.Log ("1 Pressed");
			GenerateEnemy1();
			break;
		}

	}


	/*	Enemy Type
		__---__
	*/
	private void GenerateEnemy1(){
		GameObject enemy = Instantiate(Resources.Load("prefab/Player", typeof(GameObject)))as GameObject;
	}

}
