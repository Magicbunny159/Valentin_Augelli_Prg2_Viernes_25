using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAnimplayer : MonoBehaviour
{

    [SerializeField] private float _movSpeed = 5f;

    private float _xAxis, _zAxis;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        _xAxis = Input.GetAxis("Horizontal");
        _zAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (_xAxis !=0 || _zAxis !=0)
        {

        }

    }

    private void Movement (float xAxis, float zAxis)
    {
        Vector3 dir = (transform.right * xAxis + transform.forward * zAxis).normalized;

        _rb.MovePosition(transform.position += dir * _movSpeed * Time.fixedDeltaTime);

    }

}
