using UnityEngine;
using Yarn.Unity;

public class AudioManager : MonoBehaviour
{
    public AudioSource amunetAudio;
    public AudioSource kingAudio;
 

    private AudioSource currentAudio;

    private void Start()
    {
        //currentAudio = defaultAudio;
        currentAudio.Play();
    }

    [YarnCommand("change_audio_to_amunet")]
    public void ChangeAudioToAmunet()
    {
        ChangeAudio(amunetAudio);
    }

    [YarnCommand("change_audio_to_king")]
    public void ChangeAudioToKing()
    {
        ChangeAudio(kingAudio);
    }

    private void ChangeAudio(AudioSource newAudio)
    {
        if (currentAudio != null && currentAudio.isPlaying)
        {
            currentAudio.Stop();
        }
        currentAudio = newAudio;
        if (currentAudio != null)
        {
            currentAudio.Play();
        }
    }
}
