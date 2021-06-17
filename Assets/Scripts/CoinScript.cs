using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectingGameControl.collected)
            myText.text = "50";
    }
}
