using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardProbability : MonoBehaviour
{
    public TextMesh probabilityText;

    // Update is called once per frame
    void Update()
    {
        probabilityText.text = "Chance: " + (Puck.curr_chance * 100).ToString("N1") + "%";
    }
}
