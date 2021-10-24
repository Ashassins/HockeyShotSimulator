using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // public GameObject goal1;
    // public GameObject goal2;
    // private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c) {
        //despawn / teleport puck
        if (c.gameObject.name=="Puck") {
            Puck.goal_scored = 1;
            // Puck.score = Puck.score + 1;
            //Puck.score += (int)(10 * Puck.curr_chance);
            // scaling score to look fancy smancy
        }
    }
}
