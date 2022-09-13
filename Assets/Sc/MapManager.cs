using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] GameObject _wallPrefub = default;

    [SerializeField] int _mapVertical = 10;
    [SerializeField] int _mapWidth = 10;
    void Start()
    {
        for(int i = 0; i < _mapVertical; i++)
        {
            for(int j = 0; j < _mapWidth; j++)
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
