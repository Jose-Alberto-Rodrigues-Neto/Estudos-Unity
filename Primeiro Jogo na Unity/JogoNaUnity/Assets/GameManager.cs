//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool fimDeJogo = false;
   public void EndGame()
    {
        float tempoDelay = 1f; //� interna e n�o pode ser acessada pelos outros m�dulos
        if (fimDeJogo == false)
        {
            fimDeJogo = true;
            Debug.Log("Game Over");
            Invoke("Restart", tempoDelay); //chama nova cena e da um delay no restarte do jogador
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
