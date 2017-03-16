using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class uimanager : MonoBehaviour {

    // Use this for initialization
    public Text sText;
    int score;
    void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1)
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
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
