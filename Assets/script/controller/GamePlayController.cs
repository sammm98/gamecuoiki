using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
	public static GamePlayController instance;
	void Awake() {
		MakeInstance();
	}
	void MakeInstance () {
		if (instance == null) {
			instance = this;
		}
	}
	[SerializeField]
	private GameObject pausePanel, gameOverPanel;
	public void PauseGameButton () {
		pausePanel.SetActive(true);
		Time.timeScale = 0f;
	}
	public void ResumeButton() {
		pausePanel.SetActive(false);
		Time.timeScale = 1f;
	}
	public void RestartButton () {
		gameOverPanel.SetActive(false);
		Application.LoadLevel("GamePlay");
	}
	public void OptionButton() {
		Application.LoadLevel("MainMenu");	
	}
	public void PlaneDiedShowPanel() {
		gameOverPanel.SetActive(true);
	}
	public void HighScore() {
		// Time.timeScale = 0f;
		Application.LoadLevel("ScoreHigh");	
	}
	// public void QuitButton () {
	// 	Application.LoadLevel("MainMenu");
	// }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
