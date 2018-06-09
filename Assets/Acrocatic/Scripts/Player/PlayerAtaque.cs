using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Acrocatic;

public class PlayerAtaque : MonoBehaviour {

    //public GameObject projetil;
    //public GameObject boleadeiraPosicao;
    // Boleadeira boleadeira;
    public GameObject boleadeira;
    public Transform mao;
    public float taxaLancar = 1f;
    public float proximoLancar = 0f;

    Player player;
    
	
    
    void Update () {
        if (Input.GetKeyDown("c"))
        {
            Atira();
            
        }
    }
    public void Atira()
    {
        if (Time.time > proximoLancar)
        {
            proximoLancar = Time.time + taxaLancar;

            //Instantiate(boleadeira, mao.position, Quaternion.Euler(new Vector3(0, 0, 0)));

            if (player.facingRight == true)
            {
                Instantiate(boleadeira, mao.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (player.facingRight == false)
            {
                Instantiate(boleadeira, mao.position, Quaternion.Euler(new Vector3(0, 0, -180f)));
            }
        }
    }
}
