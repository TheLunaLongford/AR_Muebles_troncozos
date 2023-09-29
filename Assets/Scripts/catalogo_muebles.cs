using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catalogo_muebles : MonoBehaviour
{
    public Sprite[] muebles;
    private int pagina_actual;

    public Image mueble_slot_1;
    public Image mueble_slot_2;
    public Image mueble_slot_3;

    private void actualizar_muebles()
    {
        int index1 = Mathf.Clamp(pagina_actual, 0, muebles.Length - 1);
        int index2 = Mathf.Clamp(pagina_actual + 1, 0, muebles.Length - 1);
        int index3 = Mathf.Clamp(pagina_actual + 2, 0, muebles.Length - 1);

        mueble_slot_1.sprite = muebles[index1];
        mueble_slot_2.sprite = muebles[index2];
        mueble_slot_3.sprite = muebles[index3];
    }

    public void siguiente_pagina()
    {
        pagina_actual += 3;
        if (pagina_actual >= muebles.Length)
        {
            pagina_actual = 0;
        }
        actualizar_muebles();
    }

    public void pagina_anterior()
    {
        pagina_actual -= 3;
        if (pagina_actual < 0)
        {
            pagina_actual = muebles.Length -3;
        }
        actualizar_muebles();
    }

    private void Start()
    {
        // Inicializacion de variables
        pagina_actual = 0;

        actualizar_muebles();

    }

}
