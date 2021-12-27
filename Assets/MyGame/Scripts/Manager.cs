using UnityEngine;
using UnityEngine.Video;

public class Manager : MonoBehaviour
{
    public VideoPlayer player;

    private void Start()
    {
        player.url = System.IO.Path.Combine(Application.streamingAssetsPath, "testvideo.mp4");
    }

    public void PlayTheVideo()
    {
        player.Play();
    }
}
