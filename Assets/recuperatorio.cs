using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recuperatorio : MonoBehaviour
{
    public string codigoDelGusto;
    public float cantidadDeHelado;
    float precioFrutilla;

    // Start is called before the first frame update
    void Start()
    {

        if (codigoDelGusto != "CHO" && codigoDelGusto != "DDL" && codigoDelGusto != "FRU" && cantidadDeHelado < 250 || cantidadDeHelado > 3000)
        {
            Debug.Log("Error");
        }

        else if (codigoDelGusto == "FRU")
        {
            precioFrutilla = 500f /1000 * cantidadDeHelado * 0.9f;
            Debug.Log("El total es de $" + precioFrutilla);
        }

        else 
        {
            Debug.Log("El total es de $" + 500f / 1000 * cantidadDeHelado);
        }

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
