using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoVida : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;
    public int vidamaxima;
    public int vidaatual;

    public BarraVida barravida;



    void Start()
    {
        vidaatual = vidamaxima;
        barravida.VidaMaxima(vidamaxima);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);
    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }
}   
