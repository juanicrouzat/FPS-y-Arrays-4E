using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Agregar una variable que establezca la cantidad de veces que se instanciara un alimento
//cuando se inrancien esa cantidad de alimentos no deben instanciarse mas


public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement posicionAleatoriaDeClonePoint;
    public int MaxClones;
    public int CloneCount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    void CloneFood()
    {
        if (CloneCount < MaxClones)
        {
            CloneCount++;
            posicionAleatoriaDeClonePoint.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
    }
}
