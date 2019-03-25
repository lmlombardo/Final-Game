using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int points;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        timer = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!MenuPause.GameIsPaused)
        {
            timer += Time.deltaTime;
            if(timer > 2)
            {
                timer = 0;
                points++;
            }
        }
        RefreshScore();
    }

    public void RefreshScore()
    {
        score.text = "Score: " + points;
    }
}
