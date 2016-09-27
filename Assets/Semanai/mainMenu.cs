using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public GUISkin NecromancerGUI;
	public bool visible=false;
	public bool click=false;
	//texturas de las imagenes para los botones
	public Texture2D bosque;
	public Texture2D desierto;
	public Texture2D fabrica;
	public Texture2D tutorial;
	public Texture2D logo;
    public GameObject player;
   

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
	}

	void OnGUI(){
		//skin del GUI
		GUI.skin = NecromancerGUI;
            /*
			GUI.DrawTexture(new Rect(Screen.width/2-Screen.height/4, 30, Screen.height/2f, Screen.height/2.4f), logo, ScaleMode.StretchToFill, true, 10.0F);
			if (GUI.Button (new Rect (Screen.width/2-100, Screen.height/6, 50, 50), "START")) {
				click = true;
				visible=true;
				}
            */
           
    }
}