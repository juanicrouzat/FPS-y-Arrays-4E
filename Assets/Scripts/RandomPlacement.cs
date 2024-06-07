using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlacement : MonoBehaviour
{
    public float offset;
    public void SetRandomPosition()
    {
        Vector3 newPosition = new Vector3(Random.Range(0,offset), 9, Random.Range(0, offset));
        transform.position = newPosition;
    }
}
