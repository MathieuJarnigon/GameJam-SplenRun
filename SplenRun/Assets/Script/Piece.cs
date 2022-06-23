using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    public GameObject Coin;
    public Text Mypoint;
    private int ScoreNum;

    void Start()
    {
            ScoreNum = 0;
            Mypoint.text = "Coin : " + ScoreNum;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            ScoreNum += 1;
            Destroy(Coin);
            Mypoint.text = "Coin : " + ScoreNum;
        }
    }
}
