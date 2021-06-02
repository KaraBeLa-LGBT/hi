using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2D;

    public Transform transform1;
    public Transform transform2;
    private int len = 0;
    void Start()
    {
        rigidbody2D.velocity = new Vector2(transform2.position.x - transform1.position.x,
                                        transform2.position.y - transform1.position.y);
    }
}
