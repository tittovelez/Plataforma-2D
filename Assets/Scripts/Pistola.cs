using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour
{

    public Transform arma_jugador;
    

    public void PonerArmaAJugador()
    {
        transform.SetParent(arma_jugador, true);
        transform.position = arma_jugador.position;
        transform.localScale = arma_jugador.localScale;
    }
}
