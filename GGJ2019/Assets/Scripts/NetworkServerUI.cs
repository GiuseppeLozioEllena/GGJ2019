using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;

public class NetworkServerUI : MonoBehaviour {

	// Use this for initialization
	void Start () {

        UnityEngine.Networking.NetworkServer.Listen(2500);
	}
	
	// Update is called once per frame
	void Update () {

        string ipAddress = Network.player.ipAddress;
        GUI.Box(new Rect(10,Screen.))
	}
}
