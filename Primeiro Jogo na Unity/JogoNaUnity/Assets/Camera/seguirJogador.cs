//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class seguirJogador : MonoBehaviour
{
    public Transform jogador;

    public Vector3 offset;
   //N�o precisaremos do Void Start agora

    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.position + offset; //diz que a posi��o da c�mera � igual ao do jogador e adiciona a posi��o escolhida no Offset, ou seja, a posi��o da c�mera ser� a do a que fica uma posi��o do offset de dist�ncia do jogador
    }
}
