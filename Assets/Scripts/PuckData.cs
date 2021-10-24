using System.Collections;
using System.Linq;
using System.Collections.Generic;
using static System.Random;
using UnityEngine;
//using Microsoft.VisualBasic.FileIO.TextFieldParser;

// public class Puck {
//     private int shotID;
//     private int arenaAdjustedShotDistance;
//     private float arenaAdjustedXCord;
//     private float arenaAdjustedYCord;
//     private double shotAngle;
//     private double shotAngleAdjusted;
//     private int shotRebound;
//     private int shotOnEmptyNet;
//     private int shooterPlayerId;
//     private string shooterName;
//     private int goalieIdForShot;
//     private string goalieNameForShot;
//     private int timeSinceLastEvent;
//     private double speedFromLastEvent;
//     private double xGoal;
//     private string shotType;
//     private string eventType;
//     private char shooterLeftRight;
// }
// public class Puck {
//     public float arenaAdjustedXCord;
//     public float arenaAdjustedYCord;
//     public string goalieNameForShot;
//     public double xGoal;
//     Puck(float _arenaAdjustedXCord,float  _arenaAdjustedYCord,string _goalieNameForShot,double _xGoal) {
//         arenaAdjustedXCord = _arenaAdjustedXCord;
//         arenaAdjustedYCord = _arenaAdjustedYCord;
//         goalieNameForShot = _goalieNameForShot;
//         xGoal = _xGoal;
//     }
// }

public class PuckData
{
    private float[] x = {85,86,84,-83,83,62,-79,74,82,54,-52,35,61,78,34,-70,82,-65,-78,64,80,-86,59,82,-31,-68,84,85,-88,64};
    private float[] y = {-1,0,2,-6,5,-22,8,2,5,26,21,-22,17,-7,-6,-5,4,-12,-3,24,10,-5,-30,2,-11,4,3,5,4,-1};
    private string[] name = {"Brady Tkachuk","Frederik Gauthier","Trevor Moore","Scott Sabourin","Auston Matthews","Auston Matthews","Ilya Mikheyev","Bobby Ryan","Sammy Blais","Alex Pietrangelo","Alex Ovechkin","Dmitry Orlov","Jakub Vrana","Leon Draisaitl","Alexander Edler","Tanner Pearson","Connor McDavid","Mark Stone","Reilly Smith","Marcus Sorensen","Cody Glass","Reilly Smith","Nikita Kucherov","Mike Hoffman","Kevin Shattenkirk","Vincent Trocheck","Ondrej Palat","Pat Maroon","Marc Staal","Mark Scheifele"};
    private double[] chance = {0.225045,0.707903,0.41008,0.128113,0.215509,0.0861766,0.0787564,0.436082,0.126827,0.0528998,0.0388645,0.435406,0.0491455,0.111962,0.0252802,0.213091,0.260303,0.121942,0.14707,0.0240936,0.0953382,0.180699,0.083332,0.162336,0.0183917,0.117558,0.546923,0.247039,0.0510157,0.184296};

    // public PuckData(
    //     int _shotID,
    //     int _arenaAdjustedShotDistance,
    //     float _arenaAdjustedXCord,
    //     float _arenaAdjustedYCord,
    //     double _shotAngle,
    //     double _shotAngleAdjusted,
    //     int _shotRebound,
    //     int _shotOnEmptyNet,
    //     int _shooterPlayerId,
    //     string _shooterName,
    //     int _goalieIdForShot,
    //     string _goalieNameForShot,
    //     int _timeSinceLastEvent,
    //     double _speedFromLastEvent,
    //     double _xGoal,
    //     string _shotType,
    //     string _eventType,
    //     char _shooterLeftRight
    //     ){
    //     shotID = _shotID;
    //     arenaAdjustedShotDistance = _arenaAdjustedShotDistance;
    //     arenaAdjustedXCord = _arenaAdjustedXCord;
    //     arenaAdjustedYCord = _arenaAdjustedYCord;
    //     shotAngle = _shotAngle;
    //     shotAngleAdjusted = _shotAngleAdjusted;
    //     shotRebound = _shotRebound;
    //     shotOnEmptyNet = _shotOnEmptyNet;
    //     shooterPlayerId = _shooterPlayerId;
    //     shooterName = _shooterName;
    //     goalieIdForShot = _goalieIdForShot;
    //     goalieNameForShot = _goalieNameForShot;
    //     timeSinceLastEvent = _timeSinceLastEvent;
    //     speedFromLastEvent = _speedFromLastEvent;
    //     xGoal = _xGoal;
    //     shotType = _shotType;
    //     eventType = _eventType;
    //     shooterLeftRight = _shooterLeftRight;
    // }

    //*
    // public int randomInt() {
    //     int num = Random.Range(0,x.length-1);
    //     return num;
    // }//*/
    // public PuckData[] ParsePucks() {
    //     PuckData[] Pucks; // Initialize
    
    //     for(int i = 0; i < x.length; i++) {
    //         Pucks[i].arenaAdjustedXCord = x[i];
    //         Pucks[i].arenaAdjustedYCord = y[i];
    //         Pucks[i].goalieNameForShot = name[i];
    //         Pucks[i].xGoal = chance[i];
    //     }
    //     return Pucks;
    // }
    
    // public PuckData getPuck(PuckData[] parsedPucks, int index) {
    //     return parsedPucks[index];
    // }

    // public Puck PickPuck(PuckData[] parsedPucks) {
    //     int i = randomInt();
    //     Puck ret_puck = new Puck(x[i], y[i], name[i], chance[i]);
    //     return ret_puck;
    // }//*/

    // public int getShotID(PuckData puckData) {
    //     int shotId = puckData.shotID;
    //     return shotId;
    // }

    // public int getAdjustedDistance (PuckData puckData) {
    //     int adjustedDistance = puckData.arenaAdjustedShotDistance;
    //     return adjustedDistance;
    // }

    // public float getXCoord(PuckData puckData) {
    //     float modifier = puckData.arenaAdjustedXCord; // this still has to be set 
    //     return modifier;
    // }

    // public float getYCoord(PuckData puckData) {
    //     float modifier = puckData.arenaAdjustedYCord; // this still has to be set 
    //     return modifier;
    // }

    // public double getAngle(PuckData puckData) {
    //     double angle = puckData.shotAngle;
    //     return angle;
    // }

    // public double getAdjAngle(PuckData puckData) {
    //     double angleAdj = puckData.shotAngleAdjusted;
    //     return angleAdj;
    // }

    // public int isRebound(PuckData puckData) {
    //     int isRebound = puckData.shotRebound;
    //     return isRebound;
    // } 
    
    // public int isEmptyNet(PuckData puckData) {
    //     int isNetEmpty = puckData.shotOnEmptyNet;
    //     return isNetEmpty;
    // } 

    // public int getShooterId(PuckData puckData) {
    //     int shooterId = puckData.shooterPlayerId;
    //     return shooterId;
    // }

    // public string getShooterName(PuckData puckData) {
    //     string name = puckData.shooterName;
    //     return name;
    // }

    // public int getGoalieId(PuckData puckData) {
    //     int shooterId = puckData.goalieIdForShot;
    //     return shooterId;
    // }

    // public string getGoalieName(PuckData puckData) {
    //     string name = puckData.goalieNameForShot;
    //     return name;
    // }

    // public int getTimeToShoot(PuckData puckData) {
    //     int time = puckData.timeSinceLastEvent;
    //     return time;
    // }

    // public double speedFromLast(PuckData puckData) {
    //     double speed = puckData.speedFromLastEvent;
    //     return speed;
    // }

    // public double getProbability(PuckData puckData) {
    //     double prob = puckData.xGoal;
    //     return prob;
    // }
    
    // public string getShotType(PuckData puckData) {
    //     string type = puckData.shotType;
    //     return type;
    // }

    // public string getEventType(PuckData puckData) {
    //     string eventType = puckData.eventType;
    //     return eventType;
    // }

    // public char getHandedness(PuckData puckData) {
    //     char handedness = puckData.shooterLeftRight;
    //     return handedness;
    // }
}
