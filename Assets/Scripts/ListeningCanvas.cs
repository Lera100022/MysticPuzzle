using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ListeningCanvas : MonoBehaviour
{
    public ScrollRect scrollRect;
    public GameObject menuPanel;
    public AudioSource audioSource;

    private float deltaTime;
    private Vector2 startVector = new Vector2(0f, -1650f);

    // Start is called before the first frame update
    void Start()
    {
        scrollRect.content.localPosition = startVector;
        deltaTime = 0.08f;

        menuPanel.SetActive(false);

        audioSource.volume = 0.1f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (scrollRect.content.localPosition.y < 1625f)
            scrollRect.content.localPosition = new Vector2(0f, scrollRect.content.localPosition.y + deltaTime);
        if (scrollRect.content.localPosition.y >= 1625f)
        {
            scrollRect.content.localPosition = new Vector2(0f, 1625f);
            deltaTime = 0f;
        }
    }

    public void OpenMenuPanel() => menuPanel.SetActive(!menuPanel.activeSelf);

    public void GetCollecting()
    {
        SceneManager.LoadScene("CollectingScreen");
        Picture0.finished = false;
        Picture1.finished = false;
        Picture2.finished = false;
        Picture3.finished = false;
        Picture4.finished = false;
        Picture5.finished = false;
        Picture6.finished = false;
        Picture7.finished = false;
        Picture8.finished = false;
        Picture9.finished = false;
        Picture10.finished = false;
        Picture11.finished = false;
        Picture12.finished = false;
        Picture13.finished = false;
        Picture14.finished = false;
        CollectingVisibilityControl.count = 0;
    }

    public void RestartButton()
    {
        if (audioSource.isPlaying)
            audioSource.Play();
        else
        {
            audioSource.UnPause();
            deltaTime = 0.08f;
            audioSource.Play();
        }
        scrollRect.content.localPosition = startVector;
    }

    public void PlayOrPauseButton()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            deltaTime = 0f;
        }
        else
        {
            audioSource.UnPause();
            deltaTime = 0.08f;
        }
    }
}
