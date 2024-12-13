using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public VoiceOverView voiceOverView;

    // Audio sources for different sound effects or characters
    public AudioSource amunetAudio;
    public AudioSource kingAudio;
    public AudioSource backgroundAudio;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code if necessary
    }

    // Change audio to Amunet's voice
    [YarnCommand("change_audio_to_amunet")]
    public void SetAmunetAudio()
    {
        voiceOverView.audioSource = amunetAudio;
    }

    // Change audio to King's voice
    [YarnCommand("change_audio_to_king")]
    public void SetKingAudio()
    {
        voiceOverView.audioSource = kingAudio;
    }

    // Change background music
    [YarnCommand("change_audio_to_background")]
    public void SetBackgroundAudio()
    {
        voiceOverView.audioSource = backgroundAudio;
    }
}
