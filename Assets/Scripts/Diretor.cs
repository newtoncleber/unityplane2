using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {

    private InterfaceGameOver interfaceGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;
    private TrilhaSonora trilhaSonora;



    private void Start()
    {
        this.interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>();
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        this.trilhaSonora = GameObject.FindObjectOfType<TrilhaSonora>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.pontuacao.SalvarRecorde();
        this.trilhaSonora.Parar();
        this.interfaceGameOver.MostrarInterface();
    }

    public void ReiniciarJogo()
    {
        this.interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        this.trilhaSonora.Tocar();
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.Reiniciar();
        
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }

}
