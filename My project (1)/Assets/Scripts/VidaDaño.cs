using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDaño : MonoBehaviour
{
    public int Vida;
    public int Daño;

    private BoxCollider2D Ataque;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TomaryHacerDaño();
    }

    private void TomaryHacerDaño()
    {
        if (Ataque.isTrigger)
        {
            Vida -= Daño;
        }
    }

    /*
    private void HacerDaño()
    {
        if (Ataque.isTrigger)
        {

        }

    }
    */
}
