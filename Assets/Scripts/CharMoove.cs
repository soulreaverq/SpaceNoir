﻿using UnityEngine;
using System.Collections;

public class CharMoove : MonoBehaviour {
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            player.transform.position = Input.mousePosition;
        }
	
	}
}
