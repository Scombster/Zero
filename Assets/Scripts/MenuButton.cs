using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	public string menuChoice;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		Application.LoadLevel(menuChoice);
	}
}
