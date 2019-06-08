using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour,IClickable {

    [SerializeField]
    private SpriteRenderer MySprite;

    public void Clicked()
    {
        MySprite.color = Random.ColorHSV();
    }

    void OnMouseDown()
    {
        Clicked();
    }
}
