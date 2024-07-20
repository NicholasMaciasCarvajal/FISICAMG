using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDaño : MonoBehaviour
{
    public int vida;
    public int daño;

    //public BoxCollider2D ataquePrefab;

    public GameObject personaje;

    //private BoxCollider2D ataque;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("proyectil"))
        {
            if (collision.CompareTag("Enemigo")) 
            {
                VidaDaño personaje = collision.GetComponent<VidaDaño>();
                if (personaje != null)
                {
                    TomaryHacerDaño();
                }
            }
        }
    }

    private void TomaryHacerDaño()
    {
        vida -= daño;
 
        if (vida <= 0)
        {
            Destroy(personaje);
        }
    }
}
