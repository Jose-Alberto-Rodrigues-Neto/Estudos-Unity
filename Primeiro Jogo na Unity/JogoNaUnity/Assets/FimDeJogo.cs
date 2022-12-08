//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FimDeJogo : MonoBehaviour
{
    public GameObject Jogador;
    private void OnTriggerEnter(Collider other) //diz que quando um corpo entrar em contato com um objeto setado como IsTrigger irá executar esse código
    {
        FindObjectOfType<GameManager>().sucesso();
        //parar o jogador
        Jogador.GetComponent<MovimentoJogador>().velF = 0;
        Jogador.GetComponent<MovimentoJogador>().velLados = 0;
    }
}
