using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entrada : MonoBehaviour
{
    public void Jogar()
    {
        //Iniciando o jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
