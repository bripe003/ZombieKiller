using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }


    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
    void addPoint()
    {
        scoreValue += 1;    
    }
}
