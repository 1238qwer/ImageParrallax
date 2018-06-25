using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    [SerializeField] private ParallaxManager parallaxManager;

    private ParallaxImage thisPallaxImage;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        thisPallaxImage = parallaxManager.ParallaxImage;

        GetComponent<Renderer>().material = thisPallaxImage.material;

        Vector2 newOffset = thisPallaxImage.material.mainTextureOffset;
        //newOffset.Set(newOffset.x + (thisPallaxImage.parallaxSpeed * Time.deltaTime), 0);
        newOffset.Set(newOffset.x + (thisPallaxImage.parallaxVector.x *thisPallaxImage.parallaxSpeed * Time.deltaTime), 
            newOffset.y + (thisPallaxImage.parallaxVector.y * thisPallaxImage.parallaxSpeed * Time.deltaTime));
        thisPallaxImage.material.mainTextureOffset = newOffset;
    }
}
