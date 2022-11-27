//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class seguirJogador : MonoBehaviour
{
    public Transform jogador;

    public Vector3 offset;
   //Não precisaremos do Void Start agora

    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.position + offset; //diz que a posição da câmera é igual ao do jogador e adiciona a posição escolhida no Offset, ou seja, a posição da câmera será a do a que fica uma posição do offset de distância do jogador
    }
}
