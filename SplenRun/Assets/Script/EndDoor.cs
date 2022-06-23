using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDoor : MonoBehaviour
{
    public GameObject EndLevelUI;
    public GameObject CoinUI;
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            CoinUI.SetActive(false);
            EndLevelUI.SetActive(true);
            Destroy(player);
        }
    }
}
