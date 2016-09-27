using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private int life;
    private int score;

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

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(objectives[Random.RandomRange(1, 15)].name);
    }



}
