using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ParallaxImage : ScriptableObject {

    public Material material;  
    public string ID;
    public float parallaxSpeed;

    public Vector2 parallaxVector;
}
