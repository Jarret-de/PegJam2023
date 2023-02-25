using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetFactory : MonoBehaviour
{
    [SerializeField] private GameObject _net;
    [SerializeField] private KeyCode _throw = KeyCode.W, _reload = KeyCode.R;

    private float _dist = 2f, _ammo = 3;

    private bool _canFire = true, _canReload = false;

    void Start() {
        
    }

    void Update()
    {
        if (_ammo > 0 && _canFire) {
            if (Input.GetKey(_throw)) {
                _canFire = false;
                _ammo--;
                Instantiate(_net, new Vector3(transform.position.x - _dist, transform.position.y + 1, transform.position.z), Quaternion.identity);
            }
        }
        else if (Input.GetKeyUp(_throw)) {
            _canFire = true;
        }

        if (Input.GetKey(_reload)) {
            RefillAmmo();
        }   
        else if (Input.GetKeyUp(_reload)) {
            _canReload = true;
        }
    }

    public void RefillAmmo() {
        if (_ammo < 3 && _canReload) {
            _canReload = false;
            _ammo++;
        }
    }
}
