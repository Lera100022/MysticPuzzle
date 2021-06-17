using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingScreen : MonoBehaviour
{
    public GameObject NEMPanel;

    public GameObject UnlockingPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseUnlockingPanel()
    {
        UnlockingPanel.SetActive(false);     
    }

    public void OpenNEMPanel()
    {
        NEMPanel.SetActive(true);
        UnlockingPanel.SetActive(false);
    }
}
