using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D MyPhys;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            MyPhys.AddForce(new Vector2((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x),0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Counter++;
        MyPhys.AddForce(collision.contacts[0].normal.normalized * 1000/(Mathf.Sqrt(Physics2D.gravity.magnitude)/2));
        IClickable platform = collision.gameObject.GetComponent<IClickable>();
        if (platform != null)
        {
            platform.Clicked();
        }
    }
}
