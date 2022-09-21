using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] int _sizeX = 10;
    [SerializeField] int _sizeY = 10;

    [SerializeField] GameObject _wall = default;
    [SerializeField] GameObject _playerPrefub = default;
    [SerializeField] GameObject _playerSpawn = default;
    void Start()
    {
        for(int i = 0; i < _sizeX; i++)
        {
            for(int j = 1; j < _sizeY; j++)
            {
                Instantiate(_wall, new Vector3(i, 0, j), Quaternion.identity);
            }
        }

        Instantiate(_playerPrefub, _playerSpawn.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


