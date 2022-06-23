using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange_plate : MonoBehaviour
{
    public GameObject Door;

    void OnCollisionEnter2D(Collision2D boite)
    {
        if (boite.gameObject.tag == "Boite")
        {
            Destroy(Door);
        }
    }
}
