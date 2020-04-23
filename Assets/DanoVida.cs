using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoVida : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;
    public int vida;
    public GameObject painel;    
    public Text textoDano;

    void Start()
    {
        painel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        textoDano.text = Convert.ToString(vida);
        
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);
    }
    public void Dano(int xDmg)
    {
        vida = vida - dano;
    }
}   
