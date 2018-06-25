using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ParallaxManager : ScriptableObject {

    public ParallaxImage[] parallaxImages;

    private ParallaxImage parallaxImage;

    private void OnEnable()
    {
        parallaxImage = parallaxImages[0];
    }
    private void OnDisable()
    {

    }
    public ParallaxImage ParallaxImage
    {
        get
        {
            return parallaxImage;
        }
    }

    public void ChangePallaxImage(string ID)
    {

        foreach (ParallaxImage image in parallaxImages)
        {
            if (image.ID == ID)
            {
                //image.material.SetTextureOffset(image.material, new Vector2(0, 0));
                parallaxImage = image;
            }
        }
    }

}
