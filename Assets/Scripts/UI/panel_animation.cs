using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_animation : MonoBehaviour
{
    public Vector3 posicion_inicial;
    public Vector3 posicion_final;

    public float duracion;
    public iTween.EaseType tipo_interpolacion;
    private bool sw_show;

    private void Start()
    {
        // Inicializacion de variables
        duracion = 1.0f;
        tipo_interpolacion = iTween.EaseType.easeInOutExpo;
        
        RectTransform resolution2 = gameObject.GetComponentInParent<RectTransform>();

        float desplazamiento_dinamico = resolution2.position.x * 5;
        // Obtener posicion inicial del panel
        Vector3 pos = transform.localPosition;
        // Calcular posicion inicial y final del panel, a partir de la posicion del canvas que lo contiene
        posicion_inicial = new Vector3(pos.x + resolution2.position.x, pos.y + resolution2.position.y, 0);
        posicion_final = new Vector3(posicion_inicial.x + desplazamiento_dinamico, posicion_inicial.y, posicion_inicial.z);

        sw_show = true;

    }

    public void toggle_panel()
    {
        if (sw_show)
        {
            ocultar_panel();
            sw_show = false;
        }
        else
        {
            aparecer_panel();
            sw_show = true;
        }
    }

    public void ocultar_panel()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", posicion_final,
            "time", duracion,
            "easetype", tipo_interpolacion
            ));
    }

    public void aparecer_panel()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", posicion_inicial,
            "time", duracion,
            "easetype", tipo_interpolacion
            ));
    }
}
