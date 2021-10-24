using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private GameObject scoreboardPrefab;
    // [SerializeField] private int score = Puck.score;
    //TextMesh textMesh = t.GetComponent(typeof(TextMesh)) as TextMesh;

    // Start is called before the first frame update
    void Awake() {
        scoreboardPrefab.SetActive(false);
    }

    void Start()
    {
        scoreboardPrefab.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //textMesh.text = (string)Puck.score;
        ShowScore(Puck.score.ToString());
    }

    public void ShowScore(string text) {
        if(scoreboardPrefab) {
            GameObject prefab = Instantiate(scoreboardPrefab, transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = text;
        }
    }
}
