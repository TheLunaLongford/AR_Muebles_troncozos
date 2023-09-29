using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_animation : MonoBehaviour
{
    public Vector3 posicion_inicial;
    public Vector3 posicion_final;

    public float duracion;
    public iTween.EaseType tipo_interpolacion;

    private void Start()
    {
        // Inicializacion de variables
        duracion = 1.0f;
        tipo_interpolacion = iTween.EaseType.easeInOutQuad;

        // Real Start
        transform.localPosition = posicion_inicial;

    }

    public void ocultar_panel()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", posicion_final,
            "time", duracion,
            "easetype", tipo_interpolacion
            ));
    }
}
