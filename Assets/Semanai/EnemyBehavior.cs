using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBehavior : MonoBehaviour {

    public GameObject enemy;
    IEnumerator frecAppear; 
    private int limLat, limSup;
    private GameObject player;


    // Use this for initialization
    void Start () {

        frecAppear = behavior();
        StartCoroutine(frecAppear);
        limLat = 12;
        limSup = 7;
        player = GameObject.Find("CubeMan");
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
        }
    }


}
