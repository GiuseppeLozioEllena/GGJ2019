using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour {

    // Use this for initialization
    public float speedX = 10f;
    public float speedY = 10f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float y=CrossPlatformInputManager.GetAxis("Vertical")*speedX;
        float x = CrossPlatformInputManager.GetAxis("Horizontal") * speedY;
        x *= Time.deltaTime;
        y *= Time.deltaTime;
        transform.Translate(x, y, 0);
       
	}
}
