using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    [SerializeField] private ParallaxManager parallaxManager;
    [SerializeField] private bool isFarClip;

    private ParallaxImage thisPallaxImage;
    
	void Update () {

        if (isFarClip)
            thisPallaxImage = parallaxManager.FarClipParallaxImage;
        else
            thisPallaxImage = parallaxManager.NearClipParallaxImage;

        Vector2 newOffset = thisPallaxImage.material.mainTextureOffset;

        GetComponent<Renderer>().material = thisPallaxImage.material;         
        newOffset.Set(newOffset.x + (thisPallaxImage.parallaxVector.x *thisPallaxImage.parallaxSpeed * Time.deltaTime), 
        newOffset.y + (thisPallaxImage.parallaxVector.y * thisPallaxImage.parallaxSpeed * Time.deltaTime));
        thisPallaxImage.material.mainTextureOffset = newOffset;
    }
}
