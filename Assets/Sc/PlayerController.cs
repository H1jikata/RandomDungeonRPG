using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    [SerializeField] float _upForce = 10f; 
    Vector3 _dir = default;

    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        PlayerMove();
        PlayerFly();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = _dir.normalized * _speed;
        velocity.y = _rb.velocity.y;
        _rb.velocity = velocity;
    }

    private void PlayerMove()
    {
        float _h = Input.GetAxisRaw("Horizontal");
        float _v = Input.GetAxisRaw("Vertical");

        _dir = new Vector3(_h, 0, _v);

        if (_dir != Vector3.zero)
        {
            this.transform.forward = _dir;
        }
    }

    void PlayerFly()
    {
        if(Input.GetButton("Jump"))
        {
            _rb.AddForce(new Vector3(0, _upForce, 0));
        }
    }
}
