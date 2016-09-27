using UnityEngine;
using System.Collections;

public class collisionObjectives: MonoBehaviour {


    void OnCollisionEnter(Collision c)
    {
        Player p = GameObject.Find("CubeMan").GetComponent("Player") as Player;
        p.Life -= 5;
        Debug.Log("Colision en: " + this.name + " cant: " + p.Life);
    }
}
