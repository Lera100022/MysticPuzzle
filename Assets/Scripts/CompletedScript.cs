using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedScript : MonoBehaviour
{
    public GameObject unlockingPanel;

    // Start is called before the first frame update
    void Start()
    {
        unlockingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenGameObject()
    {
        CollectingGameControl.collected = true;
        unlockingPanel.SetActive(true);
    }
}
