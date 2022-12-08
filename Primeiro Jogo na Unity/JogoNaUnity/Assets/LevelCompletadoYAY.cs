//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelCompletadoYAY : MonoBehaviour
{
    public void LoadNextLevel()
    {
        if (FindObjectOfType<GameManager>().UISucesso == true) { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //pega a cena em que o jogador se encontra e adiciona mais 1;
        }
    }


}
