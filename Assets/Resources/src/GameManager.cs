using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private static GameManager _instance;
	private static bool debug = false;
	public static int score = 0;
	public static int difficulty_level = 1;
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
		difficulty_level = 1;
		game_is_playing = true;
		enemy_dificulty_velocity = enemy_start_dificulty_velocity;
		Application.LoadLevel(0);
	}
	
	
    void Update(){
		checkLevel ();
		handleDifficulty ();
	}

	void checkLevel(){
		if (score >= 1 && score < 5) {
			difficulty_level = 2;
		} else if (score >= 5 && score < 20) {
			difficulty_level = 3;
		} else if (score >= 20 && score < 50) {
			difficulty_level = 4;
		} else if (score >= 50) {
			difficulty_level = 5;
		}
	}


	void handleDifficulty(){
		switch (difficulty_level) {
		case 1:
			enemy_dificulty_velocity = enemy_start_dificulty_velocity;
			break;
		case 2:
			enemy_dificulty_velocity = enemy_start_dificulty_velocity + 0.04f;
			break;
		case 3:
			enemy_dificulty_velocity = enemy_start_dificulty_velocity + 0.09f;
			break;
		case 4:
			enemy_dificulty_velocity = enemy_start_dificulty_velocity + 0.12f;
			break;
		case 5:
			enemy_dificulty_velocity = enemy_start_dificulty_velocity + 0.16f;
			break;
		default:
			break;
		}
	
	}

}