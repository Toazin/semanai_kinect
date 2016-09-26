using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPref : MonoBehaviour {

    public int enemySpeed;
    //public List<GameObject> objectives; //objetivo final
    public List<GameObject> arm;
    public List<GameObject> objectives;
    private GameObject player;

    public GameObject explosion;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("CubeMan");
        foreach (Transform child in player.transform)
        {
            if (child.name.Contains("Elbow") || child.name.Contains("Wrist") || child.name.Contains("Hand"))
            {
                arm.Add(child.gameObject);
            }
            else
            {
                objectives.Add(child.gameObject);
            }

        }
        /*
        foreach (GameObject name in objectives)
        {
            Debug.Log("OBJECTIVE: " + name.name);
        }
        foreach (GameObject name in arm)
        {
            Debug.Log("ARM: " + name.name);
        }
        */
        GameObject tempObjective = objectives[Random.RandomRange(0, objectives.Count)].gameObject;
        Debug.Log("OBJECTIVO ACTUAL: " + tempObjective.name);
        player = tempObjective;


    }

    // Update is called once per frame
    void Update() {
        //Debug.Log(objectives[Random.RandomRange(1, 15)].name);
        transform.LookAt(player.transform);
        transform.Translate(transform.forward * Time.deltaTime * enemySpeed, Space.World);
    }

    void OnCollisionEnter(Collision c)
    {
        Instantiate(explosion, c.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
