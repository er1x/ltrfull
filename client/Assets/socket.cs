using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class socket : MonoBehaviour {

	private SocketIOComponent s;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find("Network");
		s = go.GetComponent<SocketIOComponent>();
		s.On("open", PrintAndSend);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PrintAndSend (SocketIOEvent e) {
		Debug.Log("socket connected");
		s.Emit("move");
		Debug.Log("move sent");
	}
}
