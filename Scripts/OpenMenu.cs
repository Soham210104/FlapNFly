using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;//resumed the pause game after game over
    }
}
