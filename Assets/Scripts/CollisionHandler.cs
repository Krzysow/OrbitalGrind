using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("in seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX on player")] [SerializeField] GameObject deathFX;

    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    private void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
    }
}
