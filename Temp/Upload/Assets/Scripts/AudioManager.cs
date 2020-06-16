﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to call SFX in other scripts AudioManager.instance.PlaySFX(INPUTSFXNUMBER)
public class AudioManager : MonoBehaviour
{
  public AudioSource[] sfx;
  public AudioSource[] bgm;

  public static AudioManager instance;

  // Start is called before the first frame update
  void Start()
  {
    instance = this;
    DontDestroyOnLoad(this.gameObject);

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.J))
    {
      PlaySFX(18);
    }
  }
  public void PlaySFX(int soundToPlay)
  {
    if (soundToPlay < sfx.Length)
    {
      sfx[soundToPlay].Play();
    }
  }

  public void PlayBGM(int musicToPlay)
  {
    if (!bgm[musicToPlay].isPlaying)
    {
      StopMusic();
      if (musicToPlay < bgm.Length)
      {
        bgm[musicToPlay].Play();
      }
    }
  }

  public void StopMusic()
  {
    for (int i = 0; i < bgm.Length; i++)
    {
      bgm[i].Stop();
    }
  }
}