using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//[System.Serializable]
public class Puck : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public static int goal_scored = 0;
    public static int score = 0;
    public static int yeet_urself = 0;
    public static Vector3 last_position = new Vector3(0f,0f,0f);
    public static string curr_name = "Can you make this shot?";
    public static double curr_chance = 0;
    private float[] x = {0.925f,0.93f,0.92f,0.085f,0.915f,0.81f,0.105f,0.87f,0.91f,0.77f,0.24f,0.675f,0.805f,0.89f,0.67f,0.15f,0.91f,0.175f,0.11f,0.82f,0.9f,0.07f,0.795f,0.91f,0.345f,0.16f,0.92f,0.925f,0.06f,0.82f};
    private float[] y = {0.48823529411764705f,0.5f,0.5235294117647059f,0.4294117647058823f,0.5588235294117647f,0.2411764705882353f,0.5941176470588235f,0.5235294117647059f,0.5588235294117647f,0.8058823529411765f,0.7470588235294118f,0.2411764705882353f,0.7f,0.4176470588235294f,0.4294117647058823f,0.4411764705882353f,0.5470588235294118f,0.3588235294117647f,0.4647058823529412f,0.7823529411764706f,0.6176470588235294f,0.4411764705882353f,0.14705882352941177f,0.5235294117647059f,0.37058823529411766f,0.5470588235294118f,0.5352941176470588f,0.5588235294117647f,0.5470588235294118f,0.48823529411764705f};
    private string[] name = {"Brady Tkachuk","Frederik Gauthier","Trevor Moore","Scott Sabourin","Auston Matthews","Auston Matthews","Ilya Mikheyev","Bobby Ryan","Sammy Blais","Alex Pietrangelo","Alex Ovechkin","Dmitry Orlov","Jakub Vrana","Leon Draisaitl","Alexander Edler","Tanner Pearson","Connor McDavid","Mark Stone","Reilly Smith","Marcus Sorensen","Cody Glass","Reilly Smith","Nikita Kucherov","Mike Hoffman","Kevin Shattenkirk","Vincent Trocheck","Ondrej Palat","Pat Maroon","Marc Staal","Mark Scheifele"};
    private double[] chance = {0.225045,0.707903,0.41008,0.128113,0.215509,0.0861766,0.0787564,0.436082,0.126827,0.0528998,0.0388645,0.435406,0.0491455,0.111962,0.0252802,0.213091,0.260303,0.121942,0.14707,0.0240936,0.0953382,0.180699,0.083332,0.162336,0.0183917,0.117558,0.546923,0.247039,0.0510157,0.184296};

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goal_scored == 1) {
            goal_scored = 0;
            reset_puck();
        }
        if (yeet_urself == 1) {
            transform.position = new Vector3(-1000f,-1000f,-1000f);
            curr_name = "TIMER OVER!";
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            transform.position = last_position;
            rb.velocity = new Vector3(0,0,0);
        }
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            //transform.position = last_position;
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        }
    }

    public void reset_puck() {
        int i = Random.Range(0,chance.Length);
        curr_name = name[i];
        curr_chance = chance[i];
        last_position = new Vector3((float) (-28.57 + (57.67 * x[i])),-0.239f, (float)(-16.64 + (35.64 * y[i])));
        transform.position = last_position;
        transform.rotation = Quaternion.Euler(0,0,0);
        rb.velocity = new Vector3(0,0,0);
        // player.transform.position = new Vector3(0f,0f,0f);
    }
}
