using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public GameObject NEMPanel;

    public GameObject MenuPanel;

    public GameObject UnlockingPanel;

    // Start is called before the first frame update
    void Start()
    {
        NEMPanel.SetActive(false);
        MenuPanel.SetActive(false);
        UnlockingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetCollecting()
    {
        SceneManager.LoadScene("CollectingScreen");
    }

    public void GetMenuPanel()
    {
        if (MenuPanel != null)
        {
            bool isActive = MenuPanel.activeSelf;

            MenuPanel.SetActive(!isActive);
        }
    }

    public void GetUnlockingPanel()
    {
        if (UnlockingPanel != null)
        {
            bool isActive = UnlockingPanel.activeSelf;

            UnlockingPanel.SetActive(!isActive);
        }

    }
}
