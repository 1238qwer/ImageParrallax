using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    [SerializeField] ParallaxManager parallaxManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            parallaxManager.ChangePallaxImage("test1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            parallaxManager.ChangePallaxImage("test2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            parallaxManager.ChangePallaxImage("test3");
        }
    }
}
