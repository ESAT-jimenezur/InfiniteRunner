using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	private static GameManager _instance;
	private static bool debug = false;
	public static float enemy_dificulty_velocity = 0.2f;
	
	public static GameManager instance{
		get{
			
			if(_instance == null){
				_instance = GameObject.FindObjectOfType<GameManager>();
			}
			return _instance;
		}
	}
	
	public static void init(){
		
		//Add player to the map
		//GameObject player = Instantiate(Resources.Load("prefabs/Player"), new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity) as GameObject;
	}
	
	void Awake () {
		if(_instance == null){
			_instance = this;
			init ();
		}else{
			Destroy(gameObject);
		}
	}
	
	
	void Update(){

	}
	
}