using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	void Update() {
		transform.Translate(Vector3.back * GameManager.enemy_dificulty_velocity);

		if (transform.position.z <= -50) {
			Destroy(gameObject);
		}

	}
}
