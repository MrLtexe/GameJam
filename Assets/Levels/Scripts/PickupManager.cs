using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupManager : MonoBehaviour
{
    public int totalPickups;
    private int collectedPickups;

    void Start()
    {
        collectedPickups = 0;
    }

    public void PickupCollected()
    {
        collectedPickups++;

        if (collectedPickups >= totalPickups)
        {
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        // Wait for a short time to allow any animation or feedback to play
        yield return new WaitForSeconds(1.0f);

        // Load the next scene or perform any other action
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

