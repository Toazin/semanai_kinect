using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private int life;
    private int score;
    public Text txtLife;
    public Text txtScore;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Life
    {
        get { return life; }
        set { life = value; }
    }

    void Start()
    {
        life = 1000;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(objectives[Random.RandomRange(1, 15)].name);
        transform.Translate(transform.forward * Time.deltaTime * 10, Space.World);
        txtLife.text = "Life: " + life;
        txtScore.text = "Score: " + score;
    }



}
