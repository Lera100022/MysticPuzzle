using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseMenuPanel()
    {
        MenuPanel.SetActive(false);
    }

    public void GameClose()
    {
        Application.Quit(1);
    }

    public void GetGallery()
    {
        SceneManager.LoadScene("MainScreen");
    }
}

