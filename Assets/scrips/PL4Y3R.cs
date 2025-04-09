using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class PL4Y3R : MonoBehaviour
{

    Rigidbody _rb; //llamar al rigibody

    [Header("speed")]
    [SerializeField] float _seed;


    [Header("Keys")]
    [SerializeField] KeyCode _jumpKey = KeyCode.Space;

    float _xAxi;
    float _zAxi;

    Vector3 _direction;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>(); //asegurar que comience con ese componente
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(_keyToJump))
        //{

        //}

    }

    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = Input.GetAxis("Vertical");

        if (_direction.sqrMagnitude < 1)
        {
            _direction.Normalize();

        }

        //_rb.Velocity =
        //_rb.AddForce(_direction * _speed, ForceMode.Acceleration);
        _rb.MovePosition(transform.position + _direction * (_seed * Time.fixedDeltaTime));
    }



}
