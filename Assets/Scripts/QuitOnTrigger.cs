using UnityEngine;

public class QuitOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Optional: Pr�fe, ob es der Spieler ist (z.B. mit Tag "Player")
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger erreicht, Spiel wird beendet.");
            Application.Quit();

            // F�r den Editor:
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
