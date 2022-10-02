using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class P1Special : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public void playVideo()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();
    }
}
