using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBG: MonoBehaviour{

	// Use this for initialization
	void Start () {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempscale = transform.localScale;
        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;
        float worldHeight = Camera.main.orthographicSize * 2f;
        float worldWidth = worldHeight * Screen.width / Screen.height;
        tempscale.y = worldHeight / height;
        tempscale.x = worldWidth / width;
        transform.localScale = tempscale;
    }

}
