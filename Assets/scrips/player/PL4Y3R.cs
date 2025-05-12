using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class PL4Y3R : MonoBehaviour
{

    Rigidbody _rb; //llamar al rigibody

   


    [Header("speed")] //header es nombrar el titulo de la funcion
    [SerializeField] float _speed;
    [SerializeField] float _jumpForce;

    [Header("Keys")]
    [SerializeField] KeyCode _KeyTojump = KeyCode.Space;

    float _xAxi;
    float _zAxi;

    Vector3 _direction;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>(); //asegurar que comience con ese componente
        _direction = Vector3.zero;
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(_KeyTojump))
        {

        }

        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        if (_direction.sqrMagnitude > 1)
        {
            _direction.Normalize();
        }
        transform.position += _direction *(_speed * Time.deltaTime);

        //if (_direction.sqrMagnitude < 1)
        //{
        //    _direction.Normalize();

        //}
        //_rb.MovePosition(transform.position + _direction * (_speed * Time.fixedDeltaTime));


    }

    //private void FixedUpdate()
    //{

        
       
    //}



}
