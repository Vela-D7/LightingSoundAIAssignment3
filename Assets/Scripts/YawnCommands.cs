using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public AudioSource amunetAudio;
    public AudioSource kingAudio;

    // Add this script to your YarnCommandHolder or another relevant GameObject
    [YarnCommand("change_audio_amunet")]
    public void ChangeAudioToAmunet()
    {
        // Ensure only Amunet's audio is playing
        if (amunetAudio != null)
        {
            amunetAudio.Play();
        }
    }

    [YarnCommand("change_audio_king")]
    public void ChangeAudioKing()
    {
        // Ensure only the King's audio is playing
        if (kingAudio != null)
        {
            kingAudio.Play();
        }
    }
}
