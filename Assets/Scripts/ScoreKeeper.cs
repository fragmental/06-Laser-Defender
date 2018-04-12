using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public static int score = 0;
    private Text myText;

    private void Start()
    {
        myText = GetComponent<Text>();
        Reset();
    }
    
    public static void Reset()
    {
        score = 0;
        //myText.text = score.ToString();
    }

    public void Score(int points)
    {
 //       Debug.Log("Scored Point");
        score += points;
        myText.text = score.ToString();
    }
}
