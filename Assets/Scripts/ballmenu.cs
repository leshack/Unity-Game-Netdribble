using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmenu : MonoBehaviour
{
    public GameObject bola;
    public float p;

    void Start()
    {
        p = 5.2f;
    }

    void Update()
    {
        bola.transform.position = new Vector3(
            bola.transform.position.x,
            bola.transform.position.y,
            bola.transform.position.z - 0.3f
        );

        bola.transform.Rotate(0, 40 * Time.deltaTime, 0);
    }
}

