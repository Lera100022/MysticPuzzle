using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "1/4";
    }

    // Update is called once per frame
    void Update()
    {
        switch (CollectingVisibilityControl.count)
        {
            case 0: myText.text = "1/4"; break;
            case 1: myText.text = "2/4"; break;
            case 2: myText.text = "3/4"; break;
            case 3: myText.text = "4/4"; break;
        }
    }
}
