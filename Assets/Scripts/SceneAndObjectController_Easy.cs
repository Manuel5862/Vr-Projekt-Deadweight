using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneAndObjectController_Easy : MonoBehaviour
{
    public Button loadSceneButton;         // Button A – Szene 2 laden
    public Button destroyObjectButton;     // Button B – Objekt entfernen
    public Button backToMenuButton;        // Button C – Zurück zum Hauptmenü
    public GameObject objectToDestroy;     // Objekt, das entfernt werden soll
    public GameObject objectToEnable;      // Objekt, das nach dem Zerstören aktiviert wird

    void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene2);
        destroyObjectButton.onClick.AddListener(DestroyTargetObject);
        backToMenuButton.onClick.AddListener(LoadMainMenu);
    }

    void LoadScene2()
    {
        SceneManager.LoadScene(2); // Szene mit Build-Index 2
    }

    void DestroyTargetObject()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);

            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true); // Objekt aktivieren
            }
            else
            {
                Debug.LogWarning("Kein Objekt zum Aktivieren zugewiesen!");
            }
        }
        else
        {
            Debug.LogWarning("Kein Objekt zugewiesen!");
        }
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene(0); // Szene 0 = Hauptmenü
    }
}
