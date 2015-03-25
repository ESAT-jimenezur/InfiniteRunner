using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	void Update() {
		transform.Translate(Vector3.forward);
	}
}
