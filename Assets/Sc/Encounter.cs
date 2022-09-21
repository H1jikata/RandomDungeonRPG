using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour
{
    [SerializeField] int _encountNum = default;
    [SerializeField] int _randNum = default;

    [SerializeField] int _randomNumMin = 0;
    [SerializeField] int _randonNumMax = 10;

    [SerializeField] float _currentPlayerSpeed = 0;
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _currentPlayerSpeed = _rb.velocity.magnitude;

        _encountNum = Random.Range(_randomNumMin, _randonNumMax);
    }
    void Update()
    {
        _randNum = Random.Range(_randomNumMin, _randonNumMax);
        Encount();

        //Debug.Log(_randNum);
    }

    void Encount()
    {
        if (Input.GetKeyDown("w") &&  _randNum == _encountNum)
        {
            Debug.Log("encount");
            Debug.Log(_randNum);
            Debug.Log(_encountNum);
        }

        if (Input.GetKeyDown("s") &&  _randNum == _encountNum)
        {
            Debug.Log("encount");
            Debug.Log(_randNum);
            Debug.Log(_encountNum);
        }

        if (Input.GetKeyDown("a") &&  _randNum == _encountNum)
        {
            Debug.Log("encount");
            Debug.Log(_randNum);
            Debug.Log(_encountNum);
        }

        if (Input.GetKeyDown("d") &&  _randNum == _encountNum)
        {
            Debug.Log("encount");
            Debug.Log(_randNum);
            Debug.Log(_encountNum);
        }
    }
}
