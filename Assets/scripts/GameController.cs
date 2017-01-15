using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void PauseGame()
    { 
         Time.timeScale = 0f; 
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;

    }

}
