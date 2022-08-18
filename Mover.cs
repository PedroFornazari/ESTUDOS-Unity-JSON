using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speedFrente;
    float speedTras;
    float speedGiro;

    void Start()
    {
        speedFrente = 60;
        speedTras = 60;
        speedGiro = 60;

    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (speedFrente * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-speedTras * Time.deltaTime));
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, (-speedGiro * Time.deltaTime), 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, (speedGiro * Time.deltaTime), 0);
        }
    }
}
