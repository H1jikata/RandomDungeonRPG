using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter : MonoBehaviour
{
    [SerializeField] int _encountNum = default;
    [SerializeField] int _randNum = default;

    [Header("エンカウントするランダムの範囲")]
    [SerializeField] int _randomNumMin = 0;
    [SerializeField] int _randonNumMax = 10;

    Rigidbody _rb;
    Fade _fadecs;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _encountNum = Random.Range(_randomNumMin, _randonNumMax);
    }
    void Update()
    {
        _randNum = Random.Range(_randomNumMin, _randonNumMax);
        Encount();
    }

    void Encount()
    {
        if (Input.GetKeyDown("w") &&  _randNum == _encountNum)
        {
            Fade.instance.FadeStart(true);
        }

        if (Input.GetKeyDown("s") &&  _randNum == _encountNum)
        {
            Fade.instance.FadeStart(true);
        }

        if (Input.GetKeyDown("a") &&  _randNum == _encountNum)
        {
            Fade.instance.FadeStart(true);
        }

        if (Input.GetKeyDown("d") &&  _randNum == _encountNum)
        {
            Fade.instance.FadeStart(true);
        }
    }
}
