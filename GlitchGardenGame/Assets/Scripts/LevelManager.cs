using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAter;
	
	
	void Start(){
		if (autoLoadNextLevelAter <= 0){
			Debug.Log ("Level auto load disabled");
		} else {
			Invoke("LoadNextLevel", autoLoadNextLevelAter);
		}	
	}

	public void LoadLevel (string name) {
		Debug.Log ("New Level load: "+ name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequest () {
		Debug.Log ("Quit Requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
