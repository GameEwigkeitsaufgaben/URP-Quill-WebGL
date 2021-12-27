using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Manager : MonoBehaviour
{
    public VideoPlayer player;
    public VideoClip clip;

    private void Start()
    {
        Debug.Log("clipname " + "testvideo.mp4");
        player.url = System.IO.Path.Combine(Application.streamingAssetsPath, "testvideo.mp4");
        Debug.Log("url " + player.url);
    }

    public void PlayTheVideo()
    {
      
        player.Play();
    }
}
