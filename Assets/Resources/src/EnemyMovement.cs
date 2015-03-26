using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	void Update() {
		if(GameManager.game_is_playing){
			transform.Translate(Vector3.back * GameManager.enemy_dificulty_velocity);

			if (transform.position.z <= -5) {
				GameManager.score += 1;
				Destroy(gameObject);
			}
		}
	}
}
