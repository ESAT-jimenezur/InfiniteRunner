using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	private float velocity = 2.5f;
	private float acceleration = 0.0f;

	private GameObject player, cube1, cube2;


	void Start(){
		//If we need this later
		player = GameObject.Find ("Player");
		cube1 = GameObject.Find ("c1");
		cube2 = GameObject.Find ("c2");
	}


	void Update () {
		if(GameManager.game_is_playing){
			Control ();
	
		}
	}

	private void Control(){

		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(-Vector3.up * (velocity*100) * Time.deltaTime);
		}else if(Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.up * (velocity*100) * Time.deltaTime);
		}

	}


}
