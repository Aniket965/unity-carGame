using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class uimanager : MonoBehaviour {

    // Use this for initialization
    public Text sText;
    public Button[] buttons;
    int score;
   bool isOver;
    void Start () {
        score = 0;
        isOver = false;
	}
    public void GameOver()
    {
        isOver = true;
       foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1 && isOver==false)
        {
            score += 1;
            sText.text = "Score: " + score;
        }
	}
    public void Play()
    {

        Application.LoadLevel("level1");
    }
   public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
            }

        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Replay()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
