using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is the player
        if (Collision.gameObjecty.tag == "Player")
        {
            SceneManager.loadedScene(sceneName);

        }
}
