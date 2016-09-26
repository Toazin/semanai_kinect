using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
    //public GameObject detect;
    public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Instantiate(explosion, col.transform.position, Quaternion.identity);
        Destroy(col.gameObject);
    }
}
