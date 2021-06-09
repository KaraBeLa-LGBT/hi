﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRight", true);
        }
        else
        {
            anim.SetBool("isRight", false);
        }
    }
}
