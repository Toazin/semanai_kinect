using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBehavior : MonoBehaviour {

    public GameObject enemy;
    IEnumerator frecAppear;
    private int limLat, limSup;
    //public GameObject player;
    public List<GameObject> objectives; //objetivo final
    private GameObject player;


    // Use this for initialization
    void Start () {
        //player = GameObject.Find("CubeMan");
        //Destroy(enemy, 10);
        frecAppear = behavior();
        StartCoroutine(frecAppear);
        limLat = 12;
        limSup = 7;
        player = GameObject.Find("CubeMan");
        foreach (Transform child in player.transform)
        {
            objectives.Add(child.gameObject);
        }
        foreach (GameObject name in objectives)
        {
            Debug.Log(name.name);
        }
        /*
                foreach (Transform child in player.transform)
                {
                    Debug.Log(child.gameObject.name);
                    objectives.Add(child.gameObject);
                }
                foreach (GameObject name in objectives)
                {
                    Debug.Log(name.name);
                }
                */
    }
	
	// Update is called once per frame
	void Update () {

	}


    IEnumerator behavior()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            

            GameObject en1 = (GameObject)Instantiate(enemy, new Vector3(Random.Range(-1*limLat, limLat),
                Random.Range(0, limSup)), transform.rotation);            

            //en1.transform.Translate(0, Time.deltaTime * 10, 0);
        }
    }


}
