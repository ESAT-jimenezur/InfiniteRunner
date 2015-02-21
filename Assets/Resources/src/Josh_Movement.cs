using UnityEngine;
using System.Collections;

public class Josh_Movement : MonoBehaviour {

	public float speed = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 imputDir = new Vector3 (Input.GetAxis ("Horizontal"), 0.0f, 0.0f);
		
		imputDir *= speed * Time.deltaTime;
		
		transform.Translate (imputDir, Space.World);
		
		/*if ((transform.position.x + imputDir.x) >= -3.5f && (transform.position.z + imputDir.z) <= 5.0f) { 
			
			transform.Translate (imputDir, Space.World);
			
		}*/

	}
}
