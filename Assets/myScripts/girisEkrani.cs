using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class girisEkrani : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("level1");
    }
}
