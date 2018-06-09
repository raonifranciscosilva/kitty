using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fases : MonoBehaviour {


    public float tempo;
    public string fase;
    public Animator animator;

	void Start () {
	     	
	}

    public void Teste()
    {
        StartCoroutine(PassaFase(tempo, fase));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(PassaFase(tempo, fase));
        
    }



    IEnumerator PassaFase(float tempo, string fase)
    {
        this.tempo = tempo;
        this.fase = fase;
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(tempo);
        SceneManager.LoadScene(fase);
    }

    void Update () {
		
	}
}
