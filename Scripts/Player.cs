using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animacoes;

    private float velocidade = 5;
    // Use this for initialization
    void Start()
    {
        //animacoes = this.GetComponentInChildren<Animator>();
        animacoes = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, (velocidade * Time.deltaTime));
            animacoes.SetBool("Caminhar", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animacoes.SetTrigger("Pular");
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -((velocidade * 4) * Time.deltaTime), 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, ((velocidade * 4) * Time.deltaTime), 0);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animacoes.SetBool("Caminhar", false);
        }

    }
}