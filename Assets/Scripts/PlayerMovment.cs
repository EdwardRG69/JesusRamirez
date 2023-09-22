using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private int coin;
    //[SerializeField] private GameObject player;
    private void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Cube")
        {
            Destroy(other.gameObject);
            coin++;
        }
    }
}
