using UnityEngine;
using System.Collections;

public class citymovement : MonoBehaviour {

    public float enemySpeed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(transform.forward * Time.deltaTime * enemySpeed, Space.World);
    }
}
