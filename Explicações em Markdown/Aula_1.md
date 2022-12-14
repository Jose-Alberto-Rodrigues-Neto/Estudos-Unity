# Aula 1

## Variáveis

Variáveis são divididas em tipos, sendo eles:

![Tipos de variaveis](https://i1.wp.com/i7.photobucket.com/albums/y300/clarkquente/tutorialcsharo21.jpg)

~~~C#
int x = 10; // o int se refere a números inteiros

float y = 20.4f; // o float é usado para se referir a números "quebrados", ou seja, com casas decimais após o ponto

double z = 20.45f; //o double é uma versão mais longa do float, ou seja, armazena um maior número de dados

bool Estudando = true; //valor booleano se refere ao estado de verdadeiro ou falso, nesse caso é verdadeiro

string IssoÉUmTexto = "Isso é um texto"; //uma string se refere a um texto
~~~~

### Variáveis globais e locais

Uma **variável global** é criada dentro da *Public Class "nome"*. As váriaveis globais podem ser acessadas e alterada de dentro de todos os outros metódos.

Já as **variáveis locais** são criadas dentro dos metódos, logo, apenas o método pode acessa-la e modifica-la, ou seja, outros metódos não poderão acessar essa variável

## Metódos

*Void Start()* e *Void Update()* são metódos. O *Void Start()*, roda o código encapsulado dentro dele apenas uma vez quando o jogo inicia, já o *Void Update()*, roda o código a cada frame do jogo. Vale ressaltar, que por serem metódos do tipo *Void*, eles não retornam nada. Porém, nós podemos criar metódos que retornam algo, caso necessário.

Por exemplo, para criar um metódo que retorne uma soma entre dois números:

~~~C#
using UnityEngine;
public class Somar: MonoBehaviour{
    //primeiro é criado um metódo nomeado de soma que irá retornar um valor
    int soma(int x, int y){ //dentro dos parenteses nós iremos colocar os parametros, ou seja, valores que serão necessários serem colocados quando formos chamar esse metódo para efetuar a soma
        return(x + y); //após isso, como queremos que o metódo retorne algo, nós escrevemos "return()" e dentro do parenteses coloca-se o que deseja-se que seja retornado, nesse caso estamos retornando uma soma entre dois valores
    }

    //agora iremos criar um metódo que irá utilizar a soma e não retornará nada
    void Start(){
        int a = 10;
        int b = 20;
        Debug.Log(soma(a, b)); // irá retornar o valor 30 no console, vale ressaltar que para ele mostrar o dado no console é vital que o script "Somar" esteja em algum objeto em cena
    }
}

~~~~
