using UnityEngine;
using System.Collections;

public class EnemyCollisionDetector : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag == "enemy"){
			//Finish Game
			GameManager.game_is_playing = false;
		}
	}
}
