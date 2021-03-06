﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesEvent : MonoBehaviour
{
  public bool visible1 = false;
  public PlayerController PlayerScript;
  public SpriteRenderer atticSprite;

  public SpriteRenderer atticSprite2;
  public Sprite blueSpriteThree;

  public Sprite redSpriteThree;
  // Start is called before the first frame update
  void Start()
  {
    PlayerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    if (PlayerScript.atticTile1 == true)
    {
      atticSprite.sprite = blueSpriteThree;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      visible1 = true;
      var player = other.GetComponentInParent<PlayerController>();
      player.atticTile1 = true;
      atticSprite.sprite = blueSpriteThree;
      atticSprite2.sprite = redSpriteThree;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      visible1 = false;
    }
  }

  void OnGUI()
  {
    if (visible1)
    {
      GUIStyle myBoxStyle = new GUIStyle(GUI.skin.box);
      myBoxStyle.fontSize = 20;
      Font myFont = (Font)Resources.Load("../Fonts/Pixelnauts.ttf", typeof(Font));
      myBoxStyle.font = myFont;
      myBoxStyle.normal.textColor = Color.white;
      GUI.Box(new Rect(Screen.width / 4, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 3), "There are some loose tiles here...", myBoxStyle);
    }
  }
}
