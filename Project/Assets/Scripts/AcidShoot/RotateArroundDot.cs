using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArroundDot : MonoBehaviour
{

    public Transform center;
    public float radius = 2f, anglarSpeed = 2f;
    float posX, posY;
    public float angle = 0;

    private void Update() {
        posX = center.position.x + Mathf.Cos(angle) * radius;
        posY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posX, posY);
        
        if (Input.GetKey(KeyCode.C)){
            angle = angle + Time.deltaTime * anglarSpeed;

            if (angle > 6.35f)
            {
                angle = 0f;
            }
        }

        if (Input.GetKey(KeyCode.V)){
            angle = angle - Time.deltaTime * anglarSpeed;

            if (angle < 0f)
            {
                angle = 6.35f;
            }
        }
        
    }

}
