using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrilhaSonora : MonoBehaviour
{
    private AudioSource trilha;
    // Start is called before the first frame update
    private void Awake()
    {
        this.trilha = GetComponent<AudioSource>();
    }

    public void Tocar(){
        this.trilha.Play();
    }

    public void Parar(){
        this.trilha.Stop();
    }

}
