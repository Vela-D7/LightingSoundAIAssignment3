using System.Collections;
using UnityEngine;

public class NarrativeManager : MonoBehaviour
{
    public GameObject king; // Reference to the King object
    public GameObject sword; // Reference to the sword object
    public GameObject gem; // Reference to the gem object

    private bool kingDefeated = false;
    private bool takeGem = false;

    // Event for handling the King's death
    public void KillKing()
    {
        if (!kingDefeated)
        {
            kingDefeated = true;
            // Perform death animation or other effects
            Debug.Log("King is killed. Ending his torment.");
            // Call a function that triggers the 'EndGame' narrative state
            EndGame();
        }
    }

    // Event for handling the "Walk Away" choice
    public void WalkAway()
    {
        // Call a function that triggers the 'EndGame' narrative state
        Debug.Log("You walk away, and the curse follows you.");
        EndGame();
    }

    // Event for when the player decides to take the gem
    public void TakeGem()
    {
        if (!takeGem)
        {
            takeGem = true;
            Debug.Log("You have taken the gem.");
            // Trigger further actions or narrative here
        }
    }

    // Event for when the player decides to take the sword and move forward
    public void TakeSword()
    {
        Debug.Log("You have taken the sword. Prepare to move forward.");
        // Handle the sword functionality (e.g., enabling attacks, animations, etc.)
    }

    // Function to handle the end game based on choices made
    void EndGame()
    {
        if (kingDefeated)
        {
            Debug.Log("You have completed your journey, but the price of immortality haunts you.");
        }
        else
        {
            Debug.Log("The curse claims you, lost to time and bound to the mines.");
        }
    }

    // Example to update the dialogue based on choices
    public void UpdateDialogue(string dialogueText)
    {
        // Update UI with the given dialogue text (e.g., using TextMeshPro or Unity UI)
        Debug.Log(dialogueText);
    }

    // This function will be called when the player interacts with the king
    public void InteractWithKing()
    {
        if (!kingDefeated)
        {
            // Here, you can start the conversation with the king (Amunet's dialogue)
            UpdateDialogue("Ra-Hotep: You have come Finally. I waited for 2000 years.");
            // Allow for choices to be made: Kill the king or Walk Away
            ShowChoices();
        }
    }

    // Function to show choices to the player
    private void ShowChoices()
    {
        // Example: Showing choices in UI
        // This can be done by enabling buttons or triggering UI elements in Unity
        Debug.Log("Choose: Kill the king or Walk Away.");
    }

    // Call this method when the player interacts with a sword
    public void InteractWithSword()
    {
        // Allow the player to choose to take the sword or do something else
        UpdateDialogue("Amunet: Take my sword and move forward.");
        TakeSword(); // Activate the sword in the game
    }

    // Call this method when the player interacts with the gem
    public void InteractWithGem()
    {
        UpdateDialogue("Amunet: Take the gem! Leave this place.");
        TakeGem(); // Activate the gem collection
    }
}
