using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    Animator animator;

    [Tooltip("Digite o tempo de stun")]
    [Range(1,10)]
    public float tempoStun = 2f;
    Collider2D morte;
    public GameObject colisaoMorte;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boleadeira")
        {
            animator.SetTrigger("Stunado");
            StartCoroutine(FimAnimacao(tempoStun));
        }
    }

    IEnumerator FimAnimacao(float tempoStun)
    {
        this.tempoStun = tempoStun;
        Physics2D.IgnoreLayerCollision(12, 13, true);
        yield return new WaitForSeconds(tempoStun);
        animator.SetTrigger("FimAnimacao");
        Physics2D.IgnoreLayerCollision(12, 13, false);

        //colisaoMorte.SetActive(false);

    }


    void Start () {
        animator = GetComponent<Animator>();
        morte = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
