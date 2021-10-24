using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardPlayer : MonoBehaviour
{
    public TextMesh playerText;

    // Update is called once per frame
    void Update()
    {
        playerText.text = "Original Player:\n" + Puck.curr_name;
    }
}
