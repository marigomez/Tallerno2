using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{
    private GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("Rectangle");
        }

        if (player != null)
        {
            Debug.Log("hellokitty");
            transform.position = player.transform.position;
        }
    }
}