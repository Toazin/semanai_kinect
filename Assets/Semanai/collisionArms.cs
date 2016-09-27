using UnityEngine;
using System.Collections;

public class collisionArms : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        Player p = GameObject.Find("CubeMan").GetComponent("Player") as Player;
        //GameObject player = GameObject.Find("CubeMan");
        p.Score += 5;
        Debug.Log("Puntos en: " + this.name + " cant: " + p.Score);
    }
}
