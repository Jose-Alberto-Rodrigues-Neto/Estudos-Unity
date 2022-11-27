//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro; //usar o TextMeshPro

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score; //iniciando o TextMeshPro
    public Transform jogador;
    
    void Update()
    {
        score.text = jogador.position.z.ToString("0");
    }
}
