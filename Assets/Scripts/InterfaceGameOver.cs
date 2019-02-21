using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    [SerializeField]
    private Text valorRecorde;

    public void MostrarInterface(){
        this.AtualizarInterfazeGrafica();
        this.imagemGameOver.SetActive(true);
    }

    public void EsconderInterface(){
        this.imagemGameOver.SetActive(false);
    }

    private void AtualizarInterfazeGrafica(){
        int recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();
    }
}
        
