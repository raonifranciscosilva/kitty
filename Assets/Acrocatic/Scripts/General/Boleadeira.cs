using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boleadeira : MonoBehaviour {

    Rigidbody2D rb;

    public float velocidade;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0)
        {
            rb.AddForce(new Vector2(-1, 0) * velocidade, ForceMode2D.Impulse);
        }
        else
            rb.AddForce(new Vector2(1, 0) * velocidade, ForceMode2D.Impulse);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Inimigo")
        {
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update () {
        
	}
}
