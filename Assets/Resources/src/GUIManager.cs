using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	private Rect score_position = new Rect(Screen.width - 150, 35, 200, 80);
	private Rect level_position = new Rect(Screen.width - 150, 75, 200, 80);
	private GUIStyle gui_style = new GUIStyle();
	private Font caviar_dreams;
	private string gui_score_text, gui_level_text;

	void Awake(){
		caviar_dreams = Resources.Load("fonts/CaviarDreams") as Font;
		gui_style.fontSize  = 25;
		gui_style.font = caviar_dreams;
		gui_style.normal.textColor = Color.white;
	}


	void OnGUI(){
		gui_score_text =  "Score: " + GameManager.score.ToString();
		gui_level_text =  "Level: " + GameManager.difficulty_level.ToString();

		//Show Score
		GUI.Label(score_position, gui_score_text, gui_style);
		GUI.Label(level_position, gui_level_text, gui_style);

		if(GameManager.game_is_playing == false){
			ShowDeathMenu();
		}
	}

	void ShowDeathMenu(){
		if (GUI.Button(new Rect(Screen.width / 2 - 20, Screen.height / 2 - 20, 75, 30), "Restart")){
			GameManager.Restart();
		}
	}
}
