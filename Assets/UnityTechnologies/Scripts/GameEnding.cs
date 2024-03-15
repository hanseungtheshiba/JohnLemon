using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    private bool isPlayerAtExit = false;
    private float timer = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            isPlayerAtExit = true;
        }
    }

    private void Update()
    {
        if (isPlayerAtExit)
        {
            EndLevel();
        }
    }

    private void EndLevel()
    {
        timer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = timer / fadeDuration;
        if(timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
