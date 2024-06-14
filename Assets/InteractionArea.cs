using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Detectar cuando el area entra en contacto con un alimento
//si lo hace destruye el alimento y suma a una variable el valor del item y muestre el valor de esa variable
//txtScore de la escena

//Agregar una variable que almacene el valor maximo de puntos cuando se llegue al valor maximo debe
//dejar de sumarse puntos y mostrar en txtScore en lugar del puntaje el msj ganaste

public class InteractionArea : MonoBehaviour
{



    public Text txtScore;
    public int score;
    public int MaxScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;

        if(score>= MaxScore)
        {
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            txtScore.text = "¡GANASTE!";
        }
    }
}
