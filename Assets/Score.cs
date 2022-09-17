using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int num;
    //private GameObject canvas;
    private Text currentScore;

    // Start is called before the first frame update
    void Start()
    {
        //canvas = GameObject.Find("ScoreOverlay");
        currentScore = GameObject.Find("ScoreOverlay").GetComponent<Text>();
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        num = num + 1;
        currentScore.text = "Score: " + num;
    }
}
