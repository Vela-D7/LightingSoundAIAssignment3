using UnityEngine;
using Yarn.Unity;

public class AudioManager : MonoBehaviour
{
    public VoiceOverView voiceOverView;
    public AudioSource amunetAudio;
    public AudioSource kingAudio;
 

    private AudioSource currentAudio;

    private void Start()
    {
        
    }

    [YarnCommand("change_audio_to_amunet")]
    public void AmunetAudio()
    {
        voiceOverView.audioSource = amunetAudio;
    }

    [YarnCommand("change_audio_to_king")]
    public void KingAudio()
    {
        voiceOverView.audioSource = kingAudio;
    }

    
}
