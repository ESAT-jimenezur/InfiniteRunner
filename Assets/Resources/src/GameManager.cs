using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private static GameManager _instance;
	private static bool debug = false;
	public static int score = 0;
	public static bool game_is_playing = true;
	public static float enemy_start_dificulty_velocity = 0.2f;
	public static float enemy_dificulty_velocity = enemy_start_dificulty_velocity;
	
	public static GameManager instance{
		get{
			
			if(_instance == null){
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){

	}
	
	void Awake () {
		if(_instance == null){
			_instance = this;
			init ();
		}else{
			Destroy(gameObject);
		}
	}

	public static void Restart(){
		score = 0;
		game_is_playing = true;
		enemy_dificulty_velocity = enemy_start_dificulty_velocity;
		Application.LoadLevel(0);
	}
	
	
	void Update(){
		if(score >= 10){
			enemy_dificulty_velocity += 0.1f;
		}else if(score >= 25){
			enemy_dificulty_velocity += 0.15f;
		}

	}
	
}