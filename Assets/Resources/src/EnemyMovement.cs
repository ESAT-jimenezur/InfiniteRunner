using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	void Update() {
		transform.Translate(Vector3.back);

		if (transform.position.z <= -100) {
			Destroy(gameObject);
		}

	}
}
