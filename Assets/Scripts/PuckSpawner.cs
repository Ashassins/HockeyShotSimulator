using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PuckSpawner : MonoBehaviour
{
    // void Awake();
    // Start is called before the first frame update
    const int RinkCenter = 0;
    const int goalX = 89;
    const int goalY = 0;
    
    private int playerX;
    private int playerY;
    
    private int arenaAdjustedShotDistance;

    // Puck stuff
    public GameObject objectToSpawn;
    public GameObject parent;
    public int numPucks;
    public float spawnTimer;
    public float rate;
    public int limit = 20;
    public int puckHit = 0;
    public int puckDone = 0;
    
    void Start() {
        spawnTimer = rate;
        //playerX = getX();
        //playerY = getY();
        // set player coords
        // model player stick
        // select shot
        // render?? 
        if(parent.transform.childCount < limit) {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0f) {
                for (int i = 0; i < numPucks; i++) {
                    //PuckData puckData = new PuckDate(PickPuck());
                    Instantiate(objectToSpawn, new Vector3(
                        RinkCenter, //+ getXCoord(puckData),  // RinkCenter = 0
                        RinkCenter),// + getYCoord(puckData)),
                        Quaternion.identity,
                        parent.transform);
                }
                spawnTimer = rate;
            }
        }
    }

     // Update is called once per frame
    void Update() {
        while (puckHit == 0) {
            // display "Can you make this shot?" @ x, y, z coordinates;
        } // maybe run physics here? don't need to probably
        //hit wait
        //render hit
        //compare hit
        //load next shot
    }

    void FixedUpdate() {
        //while movement
        // after, run display "you made it!" + name of shooter
        // consider rendering the path the puck would have taken when hit by the shooter?
        while(puckDone == 0) {
            // this shot was made by _____
            // w/ an estimated xGoal % chance of making it!
        } //wait for user to be done with the puck
    }

    void LateUpdate() {
        //TP 
        /*
        if(parent.transform.childCount < limit) {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0f) {
                for (int i = 0; i < numPucks; i++) {
                    // PuckData puckData = PickPuck();
                    Instantiate(objectToSpawn, new Vector3(
                        RinkCenter, //+ getXCoord(puckData),  // RinkCenter = 0
                        RinkCenter), //+ getYCoord(puckData)),
                        Quaternion.identity,
                        parent.transform);
                }
                spawnTimer = rate;
            }
        }*/
    }

    /*
    
    //*/
}