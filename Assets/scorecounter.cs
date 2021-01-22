using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
    public Text scoreboard;
    public GameObject ball;

    int padonescore = 0;
    int padtwoscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 10)
        {
            padonescore++;
        }
        if (this.transform.position.x <= -10)
        {
            padtwoscore++;
        }

        scoreboard.text = padonescore.ToString() + "-" + padtwoscore.ToString();

        print(padonescore + "-" + padtwoscore);
    }
}
