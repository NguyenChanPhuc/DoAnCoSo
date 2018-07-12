using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changescene : MonoBehaviour {

    public changescene.ButtonType bt;
    // Use this for initialization
    public changescene()
    {

    }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
    }
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f);
        if(bt == changescene.ButtonType.btplay)
        {
            Application.LoadLevel("Gameplay");
        }
        if(bt == changescene.ButtonType.bthighscore)
        {
            Application.LoadLevel("Highscore");
        }
        if(bt == changescene.ButtonType.btexit)
        {
            Application.Quit();
        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public enum ButtonType
    {
        btplay,
        bthighscore,
        btexit
    }
}
