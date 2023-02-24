using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{
    [SerializeField] private KeyCode _moveUp = KeyCode.W, _moveDown = KeyCode.S, _moveLeft = KeyCode.A, _moveRight = KeyCode.D, _wave = KeyCode.E;
    private float _speed = 5, _boundary = 0.5f;

    [SerializeField] private Vector2 _pos = new Vector2(1f,1f), _size = new Vector2(1f,1f), _force = new Vector2(1f,1f);
    private Rigidbody2D _rb2d;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 vel = _rb2d.velocity;
        if (Input.GetKey(_moveUp)) {
            vel.y = _speed;
        }
        else if (Input.GetKey(_moveDown)) {
            vel.y = -_speed;
        }
        else if (Input.GetKey(_moveLeft)) {
            vel.x = -_speed;
        }
        else if (Input.GetKey(_moveRight)) {
            vel.x = _speed;
        }
        else {
            vel.x = 0;
            vel.y = 0;
        }
        _rb2d.velocity = vel;

        if (Input.GetKey(_wave)) {
            GameObject.Find("Water").GetComponent<WaterWaves2D>().Impact(_pos, _size, _force);
        }

        Vector3 pos = transform.position;
        if (pos.y > _boundary) {
            pos.y = _boundary;
        }
        transform.position = pos;
    }
}
