using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingVisibilityControl : MonoBehaviour
{
    [SerializeField]
    private GameObject button;

    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Button>().onClick.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetLeft()
    {
        if (count > 0) count--;
        button.GetComponent<Button>().onClick.Invoke();
    }

    public void GetRight()
    { 
        if (count < 3) count++;
        button.GetComponent<Button>().onClick.Invoke();
    }
}
