using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class Video : MonoBehaviour
{
       public VideoPlayer videoPlayer;

    void Start()
    {
        // Reproduz o vídeo ao iniciar
        videoPlayer.Play();
    }

    void Update()
    {
        // Exemplo de controle de vídeo
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
