using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public int health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * speed;
        var y = Input.GetAxis("Vertical") * speed;

        var rb = GetComponent<Rigidbody2D>();
        if (rb != null) { 
        
        rb.velocity = new Vector2(x, y);

        }

        
    }

}
