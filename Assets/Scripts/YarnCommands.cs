using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public VoiceOverView voiceOverView;

    // Audio sources for characters and events
    public AudioSource raHotepAudio, amunetAudio, itBossAudio, orbExplosionAudio, fireSoundAudio, technoHumAudio;

    // State variables for Yarn Spinner
    private bool takeGem = false;
    private bool kingDefeated = false;
    private bool orbTaken = false;

    // Initialize variables
    void Start()
    {
        // Optional initialization logic if needed
    }

    // Command to change audio to Ra-Hotep's voice
    [YarnCommand("change_audio_to_raHotep")]
    public void ChangeAudioToRaHotep()
    {
        voiceOverView.audioSource = raHotepAudio;
    }

    // Command to change audio to Amunet's voice
    [YarnCommand("change_audio_to_amunet")]
    public void ChangeAudioToAmunet()
    {
        voiceOverView.audioSource = amunetAudio;
    }

    // Command to change audio to IT Boss's voice
    [YarnCommand("change_audio_to_itBoss")]
    public void ChangeAudioToItBoss()
    {
        voiceOverView.audioSource = itBossAudio;
    }

    // Command to change audio to orb explosion sound
    [YarnCommand("change_audio_to_orb_explosion")]
    public void ChangeAudioToOrbExplosion()
    {
        voiceOverView.audioSource = orbExplosionAudio;
    }

    // Command to change audio to fire sound
    [YarnCommand("change_audio_to_fire_sound")]
    public void ChangeAudioToFireSound()
    {
        voiceOverView.audioSource = fireSoundAudio;
    }

    // Command to change audio to techno hum sound
    [YarnCommand("change_audio_to_techno_hum")]
    public void ChangeAudioToTechnoHum()
    {
        voiceOverView.audioSource = technoHumAudio;
    }

    // Yarn command to set "takeGem" state
    [YarnCommand("set_take_gem")]
    public void SetTakeGem()
    {
        takeGem = true;
        Debug.Log("Gem has been taken.");
    }

    // Yarn command to set "kingDefeated" state
    [YarnCommand("set_king_defeated")]
    public void SetKingDefeated()
    {
        kingDefeated = true;
        Debug.Log("The king has been defeated.");
    }

    // Yarn command to set "orbTaken" state
    [YarnCommand("set_orb_taken")]
    public void SetOrbTaken()
    {
        orbTaken = true;
        Debug.Log("The orb has been taken.");
    }

    // Yarn command to check end game state and trigger events
    [YarnCommand("check_end_game")]
    public void CheckEndGame()
    {
        if (kingDefeated || orbTaken)
        {
            Debug.Log("End Game: The journey is complete, but the consequences remain.");
            // Trigger victory-related effects or end game events
        }
        else
        {
            Debug.Log("End Game: The curse remains, you are lost to time.");
            // Trigger failure-related effects or end game events
        }
    }

    // Additional helper methods for any future Yarn Spinner commands
}
