using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class WebGLVideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private string videoPostName;

    private GameObject rawImage;
    private bool videoIsPlaying = false;
    private bool videoSetUpDone = false;

    private void Start()
    {
        Debug.Log("Set Video Url and configurations: " + videoPlayer.url);
    }

    public void StartTheVideo(string videoPostName, string videoName, RawImage imgRaw)
    {
        if (!videoSetUpDone)
        {
            SetVideo(videoName, imgRaw);
            videoSetUpDone = true;
            Debug.Log("Setup Videooutput" + videoPostName);
        }

        this.videoPostName = videoPostName;

        if (!videoIsPlaying)
        {
            videoPlayer.Play();
            videoPlayer.loopPointReached += SetVideopostToRead;
            videoIsPlaying = true;
        }
        else
        {
            videoPlayer.Stop();
            videoIsPlaying = false;
        }

        //rawImage.transform.parent.transform.parent.GetComponent<Overlay>().SetIconActive(!videoIsPlaying);
    }

    public void SetVideo(string videoName, RawImage imgRaw)
    {
        Debug.Log("SetVideoData in Player");
        rawImage = imgRaw.gameObject;
        rawImage.GetComponent<RawImage>().texture = videoPlayer.targetTexture;
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
        videoPlayer.isLooping = false;
    }

    public void StopTheVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }

        videoIsPlaying = false;
    }

    //Method called (from local method StartTheVideo) if event player finished is fired
    public void SetVideopostToRead(VideoPlayer vp)
    {
        videoIsPlaying = false;
    }
}
