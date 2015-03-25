using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	private float lastSpawn = 0;
	private float nextSpawn = 0;
	private int total_enemy_types = 3; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > lastSpawn + nextSpawn){
			GenerateEnemy(getRandomEnemyNumber()+1);
			lastSpawn = Time.time;  
			nextSpawn = Random.Range(1, 3); 
		}


	}

	private int getRandomEnemyNumber(){
		return Random.Range (0, total_enemy_types);
	}

	/*
	private void GenerateEnemy(int enemy_type){

		switch (enemy_type) {
		case 1:
			GenerateEnemy(1);
			break;
		}
		case 2:
			GenerateEnemy(2);
			break;
		}

	}*/

	private void GenerateEnemy(int enemy_type){
		//Vector3 rot = transform.rotation.eulerAngles;
		//Vector3 pos = transform.position;
		//rot = new Vector3(rot.x, rot.y, rot.z + 180);
		//pos = new Vector3 (pos.x, pos.y, 100.0f);
		GameObject enemy = Instantiate(Resources.Load("prefab/enemy" + enemy_type, typeof(GameObject)))as GameObject;
	}

}
