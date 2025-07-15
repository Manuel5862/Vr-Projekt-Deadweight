using UnityEngine;
using TMPro;

public class HeightAndHighscoreDisplay : MonoBehaviour
{
    public Transform xrOrigin;                   // Dein XR Origin (Spieler)
    public TextMeshProUGUI currentHeightText;   // Textfeld für aktuelle Höhe
    public TextMeshProUGUI highscoreText;       // Textfeld für Highscore (max Höhe)

    private int maxHeight = 0;

    void Update()
    {
        int currentHeight = Mathf.FloorToInt(xrOrigin.position.y);

        // Aktuelle Höhe anzeigen (ganzzahlig)
        currentHeightText.text = "Aktuell: " + currentHeight + " m";

        // Highscore prüfen und aktualisieren
        if (currentHeight > maxHeight)
        {
            maxHeight = currentHeight;
            highscoreText.text = "Highscore: " + maxHeight + " m";
        }
    }
}
