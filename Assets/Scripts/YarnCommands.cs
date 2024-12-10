using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public VoiceOverView voiceOverView;

    // Audio sources for each character's voice
    public AudioSource raHotepAudio, amunetAudio, kingAudio;
    public AudioSource itBossAudio, robot1Audio, robot2Audio, robot3Audio;
    public AudioSource lanternFlickerAudio, orbEnergyAudio, combatMusicAudio;
    public AudioSource ambientLightingAudio, swordRustlingAudio, statueEchoAudio, fireSoundAudio;

    // Track taken items and defeated characters
    private bool takeGem = false;
    private bool takeSword = false;
    private bool kingDefeated = false;
    private bool robotDefeated = false;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize or set any default states
    }

    // Command for changing to the Ra-Hotep (Ancient Egypt) voice
    [YarnCommand("change_audio_to_raHotep")]
    public void RaHotepAudio()
    {
        voiceOverView.audioSource = raHotepAudio;
    }

    // Command for changing to the Amunet (Hanging Man) voice
    [YarnCommand("change_audio_to_amunet")]
    public void AmunetAudio()
    {
        voiceOverView.audioSource = amunetAudio;
    }

    // Command for changing to the King voice
    [YarnCommand("change_audio_to_king")]
    public void KingAudio()
    {
        voiceOverView.audioSource = kingAudio;
    }

    // Command for changing to the IT Boss voice (Future)
    [YarnCommand("change_audio_to_itBoss")]
    public void ItBossAudio()
    {
        voiceOverView.audioSource = itBossAudio;
    }

    // Command for changing to the Robot 1 voice (Future)
    [YarnCommand("change_audio_to_robot1")]
    public void Robot1Audio()
    {
        voiceOverView.audioSource = robot1Audio;
    }

    // Command for changing to the Robot 2 voice (Future)
    [YarnCommand("change_audio_to_robot2")]
    public void Robot2Audio()
    {
        voiceOverView.audioSource = robot2Audio;
    }

    // Command for changing to the Robot 3 voice (Future)
    [YarnCommand("change_audio_to_robot3")]
    public void Robot3Audio()
    {
        voiceOverView.audioSource = robot3Audio;
    }

    // Command for changing to the Lantern Flicker sound
    [YarnCommand("change_audio_to_lantern_flicker")]
    public void LanternFlickerAudio()
    {
        voiceOverView.audioSource = lanternFlickerAudio;
    }

    // Command for changing to the Orb Energy sound
    [YarnCommand("change_audio_to_orb_energy")]
    public void OrbEnergyAudio()
    {
        voiceOverView.audioSource = orbEnergyAudio;
    }

    // Command for changing to the Combat Music sound
    [YarnCommand("change_audio_to_combat_music")]
    public void CombatMusicAudio()
    {
        voiceOverView.audioSource = combatMusicAudio;
    }

    // New Commands for additional sound effects
    [YarnCommand("change_audio_to_ambient_lighting")]
    public void AmbientLightingAudio()
    {
        voiceOverView.audioSource = ambientLightingAudio;
    }

    [YarnCommand("change_audio_to_sword_rustling")]
    public void SwordRustlingAudio()
    {
        voiceOverView.audioSource = swordRustlingAudio;
    }

    [YarnCommand("change_audio_to_statue_echo")]
    public void StatueEchoAudio()
    {
        voiceOverView.audioSource = statueEchoAudio;
    }

    [YarnCommand("change_audio_to_fire_sound")]
    public void FireSoundAudio()
    {
        voiceOverView.audioSource = fireSoundAudio;
    }

    // Handle specific actions that happen when characters are interacted with, like taking gems, swords, or burning the king
    [YarnCommand("set_take_gem")]
    public void TakeGem()
    {
        takeGem = true;
        Debug.Log("Gem has been taken.");
    }

    [YarnCommand("set_take_sword")]
    public void TakeSword()
    {
        takeSword = true;
        Debug.Log("Sword has been taken.");
    }

    [YarnCommand("burn_king")]
    public void BurnKing()
    {
        // Logic to handle burning the king when the player chooses to do so
        Debug.Log("Burning the king.");
        // Add game mechanics for burning animation or effects here
    }

    [YarnCommand("set_robot_defeated")]
    public void DefeatRobot()
    {
        robotDefeated = true;
        Debug.Log("A robot has been defeated.");
        // Trigger events such as animations or visual feedback for defeating robots
    }

    // Checking if the player has defeated the king or robots to determine game outcome
    [YarnCommand("check_end_game")]
    public void CheckEndGame()
    {
        if (kingDefeated || robotDefeated)
        {
            Debug.Log("Game Ended: Victory over King or Robots.");
            // End game actions
        }
        else
        {
            Debug.Log("Game Ended: Curse of Immortality remains.");
            // Alternate ending actions
        }
    }

    // Additional commands or logic can go here for any new interactions
}
