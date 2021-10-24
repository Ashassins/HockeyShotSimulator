using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardScore : MonoBehaviour
{
    public TextMesh scoreText;
    // [SerializeField] private int score = Puck.score;
    //TextMesh textMesh = t.GetComponent(typeof(TextMesh)) as TextMesh;

    void Update()
    {
        scoreText.text = "Score: " + Puck.score.ToString();
    }
}
