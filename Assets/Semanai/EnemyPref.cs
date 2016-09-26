using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPref : MonoBehaviour {

    public int enemySpeed;
    //public List<GameObject> objectives; //objetivo final
    public GameObject player;
    public GameObject explosion;

                                       // Use this for initialization
    void Start () {
        
        player = GameObject.Find("CubeMan");
        /*
        foreach (Transform child in player.transform)
        {
            objectives.Add(child.gameObject);
        }
        foreach(GameObject name in objectives)
        {
            //Debug.Log(name.name);
        }
        */

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
