using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture1 : MonoBehaviour
{
    public GameObject correctForm1;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;
    public static bool finished;

    private void Start()
    {
        resetPosition = transform.localPosition;
    }

    void Update()
    {
        if (moving && !finished)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, gameObject.transform.localPosition.z);

        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - transform.localPosition.x;
            startPosY = mousePos.y - transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(transform.localPosition.x - correctForm1.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(transform.localPosition.y - correctForm1.transform.localPosition.y) <= 0.5f)
        {
            transform.position = new Vector3(correctForm1.transform.position.x,
                                                correctForm1.transform.position.y,
                                                correctForm1.transform.position.z);
            finished = true;
        }
        else
            transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
    }
    public void ToggleVisibility1()
    {
        //if (!finished)
        //    if (CollectingVisibilityControl.count != 1)
        //        gameObject.transform.localPosition = new Vector3(10f, 10f, resetPosition.z);
        //    else
        //        gameObject.transform.localPosition = new Vector3(3.5f, 2f, resetPosition.z);
        if (!finished)
            if (CollectingVisibilityControl.count == 1)
                gameObject.SetActive(true);
            else
                gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
