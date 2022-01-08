using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour {
	
	//variables visible in the inspector
	public string Scene;
	public bool OnTrigger;
	
	//open scene using UI button and typing scene name
	public void openScene(string scene){
	SceneManager.LoadScene(scene);	
	}
	
	void OnTriggerEnter(){
	//open scene on trigger enter
	if(OnTrigger){
	SceneManager.LoadScene(Scene);	
	}	
	}
}
