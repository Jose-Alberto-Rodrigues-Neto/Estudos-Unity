# Aula 1

## Variáveis

Variáveis são divididas em tipos, sendo eles:

~~~C#
int x = 10; // o int se refere a números inteiros

float y = 20.4f; // o float é usado para se referir a números "quebrados", ou seja, com casas decimais após o ponto

double z = 20.45f; //o double é uma versão mais longa do float, ou seja, armazena um maior número de dados

bool Estudando = true; //valor booleano se refere ao estado de verdadeiro ou falso, nesse caso é verdadeiro

string IssoÉUmTexto = "Isso é um texto"; //uma string se refere a um texto
~~~

## Variáveis globais e locais

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

~~~

## Operadores

Os principais operadores aritméticos são:

![Operadores art.](https://mantmor.files.wordpress.com/2010/07/01.png)

Já os principais operadores lógicos são:

![Operadores log.](https://mantmor.files.wordpress.com/2010/07/02.png)

Mas quando vamos usa-los? Irei dar um exemplo simples. Caso queira implementar um evento que vá acontecer em determinado momento do seu tempo, nesse caso 20 segundos depois do jogo começar, nós iremos fazer:

~~~C#
using UnityEngine;
public class Script1 : MonoBehaviour
{
    float contador = 0f; //primeiro criamos um contador que irá começar com zero

    float evento = 25f; //após, nós criaremos o valor ao qual o evento acontecerá

    void Update()
    {
        contador += Time.deltaTime; //aqui nós estaremos falando que o tempo em que o jogo está sendo rodado será adicionado ao valor do contador

        Debug.Log(contador); //mostrará o valor do contador

        if (contador >= evento) //nessa condicional, ao qual iremos explorar mais para frente, dizemos que se o contador for maior ou igual ao evento ele irá iniciar o evento, vale ressaltar que como se trata de valores quebrados (float) ele pode não rodar se você colocar como condição o contador ser igual ao evento
        {
            Debug.LogError("evento iniciado"); //Aqui nós iremos fazer com que surja um erro, meramente por capricho, para mostrar que o evento foi iniciado com sucesso
        }

    }
}
~~~

### Operador Ternário

Operadores ternários são
