﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject book;
    public PlayerController PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (PlayerScript.gamestate > 1)
        {
            //sprite state updated
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.gamestate > 1)
        {
            //sprite state updated
        }
    }

    void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      if (Input.GetKeyDown("j") && PlayerScript.gamestate < 2)
      {
        PlayerScript.gamestate = 2;
        book.SetActive(false);
      }
    }
  }
}
