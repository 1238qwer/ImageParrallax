using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    [SerializeField] ParallaxManager parallaxManager;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            parallaxManager.ChangeParallaxImage("bubble",true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            parallaxManager.ChangeParallaxImage("flow",false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            parallaxManager.ChangeParallaxImage("city",true);
        }
    }
}
