using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Animator animacoes;

    // Start is called before the first frame update
    void Start()
    {
        animacoes = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            animacoes.SetTrigger("Mover");
        }
    }
}
