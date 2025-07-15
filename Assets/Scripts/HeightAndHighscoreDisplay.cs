using UnityEngine;
using TMPro;

public class HeightAndHighscoreDisplay : MonoBehaviour
{
    public Transform xrOrigin;                   // Dein XR Origin (Spieler)
    public TextMeshProUGUI currentHeightText;   // Textfeld f�r aktuelle H�he
    public TextMeshProUGUI highscoreText;       // Textfeld f�r Highscore (max H�he)

    private int maxHeight = 0;

    void Update()
    {
        int currentHeight = Mathf.FloorToInt(xrOrigin.position.y);

        // Aktuelle H�he anzeigen (ganzzahlig)
        currentHeightText.text = "Aktuell: " + currentHeight + " m";

        // Highscore pr�fen und aktualisieren
        if (currentHeight > maxHeight)
        {
            maxHeight = currentHeight;
            highscoreText.text = "Highscore: " + maxHeight + " m";
        }
    }
}
