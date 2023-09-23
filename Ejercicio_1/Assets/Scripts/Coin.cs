using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(10f, 30f, 0) * Time.deltaTime);
    }
}
