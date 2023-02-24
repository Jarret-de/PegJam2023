using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehaviour : MonoBehaviour
{

    [SerializeField] private KeyCode _moveLeft = KeyCode.A, _moveRight = KeyCode.D, _netUp = KeyCode.A, _netDown = KeyCode.D;
    private float _speed = 5, _test = 1f;
    private Rigidbody2D _rb2d;

    private GameObject _ship;
    
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _ship = GameObject.Find("LineExtend");
    }
    void Update()
    {
        Vector2 vel = _rb2d.velocity;
        if (Input.GetKey(_moveLeft)) {
            vel.x = -_speed;
            _ship.transform.SetParent(transform);
        }
        else if (Input.GetKey(_moveRight)) {
            vel.x = _speed;
            _ship.transform.SetParent(transform);
        }
        else {
            vel.x = 0;
            _ship.transform.SetParent(null);
        }
        _rb2d.velocity = vel;
    }
}
