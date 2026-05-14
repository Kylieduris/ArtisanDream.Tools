
using UnityEngine;

public class TriggerLogger : MonoBehaviour
{
    // Called once when another collider enters this trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Logs a simple message to the console
        Debug.Log("Triggered!");

    }
}

