using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController instance;


    [SerializeField]
    private GameObject pausePanel,startPanel;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    void Awake()
    {

        MakeInstance();
        startPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PauseGame()
    { 
         Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        startPanel.SetActive(false);
        Time.timeScale = 1f;

    }


}
