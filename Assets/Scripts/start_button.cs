using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour
{
    public void cambiar_escena_catalogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
