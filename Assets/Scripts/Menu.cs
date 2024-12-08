using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void IA()
    {
        SceneManager.LoadScene("IA");
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Mapa()
    {
        SceneManager.LoadScene("Mapa");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
