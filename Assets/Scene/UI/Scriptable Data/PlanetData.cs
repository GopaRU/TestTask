using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlanetData", menuName = "Planet Data", order = 51)]
public class PlanetData : ScriptableObject {

    [SerializeField]
    private Color Background;

    [SerializeField]
    private float Gravity;

    public Color BackgroundColor
    {
        get
        {
            return Background;
        }
    }

    public float GravityValue
    {
        get
        {
            return Gravity;
        }
    }

}
