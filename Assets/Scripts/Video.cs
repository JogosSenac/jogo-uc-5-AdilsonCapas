using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class Video : MonoBehaviour
{
       public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
        }
    }
}
