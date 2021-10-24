using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int score;
    private int posX;
    private int posY;
    public Player (int _score, int _posX, int _posY){
        score = _score;
        posX = _posX;
        posY = _posY;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (goalScored) {
            updatescore();
        }*/
    }

    /*public int updateScore(int score) {
        return score++;
        //can scale score w xGoal later
    }*/
}
