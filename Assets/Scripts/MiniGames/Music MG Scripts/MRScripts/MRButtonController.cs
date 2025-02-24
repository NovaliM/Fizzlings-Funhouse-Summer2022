﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRButtonController : MonoBehaviour
{

    private SpriteRenderer theSR;
    public Sprite defaultIamge;
    public Sprite pressedIamge;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedIamge;
        }
        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultIamge;
        }
    }
}
