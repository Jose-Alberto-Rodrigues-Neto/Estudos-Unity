//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject UISucesso;

    public bool GameOver = false;

    public void Start() //reseta o UISucesso quando muda de fase, fazendo com que o texto que aparece ao passar de fase volte a ficar invis�vel
    {
        UISucesso.SetActive(false);
    }
    public void EndGame()
    {
        float tempoDelay = 1f; //� interna e n�o pode ser acessada pelos outros m�dulos
        if (GameOver == false)
        {
            GameOver = true;
            Debug.Log("Game Over");
            Invoke("Restart", tempoDelay); //chama nova cena e da um delay no restarte do jogador
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void sucesso()
    {
        UISucesso.SetActive(true);
    }
}
