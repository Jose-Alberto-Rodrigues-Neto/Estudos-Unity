using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    float eventoX = 0f, limite = 25f;

    void Start()
    {
        
    }


    void Update()
    {
        eventoX += Time.deltaTime;
        Debug.Log(eventoX);
        int resultado;
        print(resultado = eventoX < limite ? 0 : 1); //operador ternário
        if (eventoX >= limite)
        {
            Debug.LogError("fim");

        }

    }
}
