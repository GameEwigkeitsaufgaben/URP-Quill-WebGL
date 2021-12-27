using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Manager : MonoBehaviour
{
    public VideoPlayer player;

   public void PlayTheVideo()
    {
        player.Play();
    }
}
