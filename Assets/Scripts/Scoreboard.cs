using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private GameObject scoreboard;
    // [SerializeField] private int score = Puck.score;
    //TextMesh textMesh = t.GetComponent(typeof(TextMesh)) as TextMesh;

    // Start is called before the first frame update
    void Awake() {
        scoreboard.SetActive(false);
    }

    void Start()
    {
        scoreboard.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //textMesh.text = (string)Puck.score;
        //ShowScore(Puck.score.ToString());
    }
    /*
    public void ShowScore(string scoreText) {
        if(scoreboard) {
            //GameObject prefab = Instantiate(scoreboardPrefab, transform.position, Quaternion.identity);
            scoreboard.GetComponent<TextMesh>().text = "Hi";///scoreText;
        }
    }//*/
}
