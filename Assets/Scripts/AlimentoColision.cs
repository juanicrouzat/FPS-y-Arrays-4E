using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            Destroy(gameObject);
        }
    }
}
