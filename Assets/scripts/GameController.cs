using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController instance;


    [SerializeField]
    private GameObject pausePanel;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    void Awake()
    {
        MakeSingleton();
      
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
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
        Time.timeScale = 1f;

    }

}
