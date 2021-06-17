using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratulationCanvas : MonoBehaviour
{
    public void GetGallery() => SceneManager.LoadScene("MainScreen");

    public void GetListening() => SceneManager.LoadScene("ListeningScreen");
}
