using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBehaviour : MonoBehaviour
{
[SerializeField] private KeyCode _netUp = KeyCode.A, _netDown = KeyCode.D;
    private float _speed = 1;
    private Rigidbody2D _rb2d;
    
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 vel = _rb2d.velocity;
        if (Input.GetKey(_netUp)) {
            vel.y = _speed;
        }
        else if (Input.GetKey(_netDown)) {
            vel.y = -_speed;
        }
        else {
            vel.y = 0;
        }
        _rb2d.velocity = vel;
    }
}
