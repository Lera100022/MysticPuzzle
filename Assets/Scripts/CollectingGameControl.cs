using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGameControl : MonoBehaviour
{
    public GameObject collectingButton;

    public GameObject rightButton;

    public GameObject leftButton;

    public static bool collected;

    // Start is called before the first frame update
    void Start()
    {
        collectingButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Picture0.finished && Picture1.finished && Picture2.finished && Picture3.finished && Picture4.finished &&
            Picture5.finished && Picture6.finished && Picture7.finished && Picture8.finished && Picture9.finished &&
            Picture10.finished && Picture11.finished && Picture12.finished && Picture13.finished && Picture14.finished)
        {
            collectingButton.SetActive(true);
            //collected = true;

            rightButton.SetActive(false);
            leftButton.SetActive(false);
        }
    }
}
