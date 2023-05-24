using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // Değişkenlerin başında alt çizgi görürsek private olduğunu anlayacağız; _rb
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(_rb.velocity.x, 9f);
    }

    void Update()
    {
        
    }
}
