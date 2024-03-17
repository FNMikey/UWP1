using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public float bulletSpeed = 10f;
    public KeyCode shootButton;


    void Update()
    {

        if (Input.GetKeyDown(shootButton))
        {

            var vector  = transform.position.normalized;

            var obj = Instantiate(bullet, transform.position, transform.rotation);

            obj.GetComponent<Rigidbody2D>().velocity = vector * bulletSpeed;

        }



    }
}

