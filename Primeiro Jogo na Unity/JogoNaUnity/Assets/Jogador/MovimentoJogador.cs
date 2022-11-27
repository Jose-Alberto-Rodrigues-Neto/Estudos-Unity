//using System.Collections; (por enquanto n�o ser� usado)
//using System.Collections.Generic; (por enquanto n�o ser� usado)
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public Rigidbody rb; //aqui foi criado uma variavel public, do tipo Rigdbody, onde foi dado o nome de rb e no unity foi indexado o rigdbody do jogador, assim, toda vez que essa variavel for escolhida ela estar� referenciando o rigdbody do Jogador
    
    public float velF = 500f; //aqui � colocado a v�riavel que ser� usada para a velocidade do jogador

    public float velLados = 100f; //aqui � colocado a var que � usada para a velocidade do movimento para os lados

    public float pulo = 1000f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "Obstaculo")
        {
            velF = 0;
            velLados = 0;
        }
    }
    void Start() //Roda quando seu jogo inicia, tipo um create em Game Maker Studio 2
    {
        Debug.Log("Ol�, mundo"); //manda uma mensagem de debug para o Console do jogo, h� outras fun��es de debug que podem ser usadas, como o Debug.Warning

    }

    private void Update()
    {
        Debug.Log(velF);
    }

    void FixedUpdate() //O Update � atualizado uma vez a cada frame por segundo (fps), ou seja, ele ir� rodar durante todo o jogo, tipo um step no Game Maker Studio 2, por�m � utilizado o "FixedUpdate()" pois assim a Unity entende melhor o c�digo(?), preciso pesquisar sobre isso depois ("Para que serve o FixedUpdate?" e "Diferen�as entre o FixedUpdate e o Update") 
    {

        //fazendo ele ir infinitamente para frente
        rb.AddForce(0, 0, velF * Time.deltaTime); //adiciona uma for�a/impulso para o personagem, setando o quanto ir� mudar seu (x, y, z)
        //o Time.deltaTime, � utilizado a fim de manter uma taxa de atualiza��o de frame por segundo boa o suficiente para cada computador, exemplo: se um computador roda o jogo a 10 fps, ele ir� ser 0.1, por�m, se um jogo roda a 20 fps ele ir� ser 0.05 (um tempo menor que 0.1, logo, mais r�pido)
 
        //adicionando movimento ao jogador
        if (Input.GetKey("d"))
        { // caso o jogador aperte d
            rb.AddForce(velLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //anda para a direita
            //ForceMod.VelocityChange faz com que a massa seja ignorada no momento de verificar o input do jogador, fazendo com que tenha menos resist�ncia na hora de fazer o jogador ir para o lado
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-(velLados * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }

        
        
    }
}
