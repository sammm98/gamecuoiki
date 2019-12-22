using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
	public void PlayGameButton() {
		Application.LoadLevel("GamePlay");
        Score.scoreValue = 0;
	}
	public void QuitGameButton() {
		Application.Quit();
	}
    public void HighScore() {
		// Time.timeScale = 0f;
		Application.LoadLevel("ScoreHigh");	
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
