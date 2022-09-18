using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] GameObject _wallPrefub = default;

    [SerializeField] int _mapVertical = 10;
    [SerializeField] int _mapWidth = 10;

    [SerializeField] GameObject _wallBrock = default;
    void Start()
    {
        for(int i = 0; i < _mapVertical; i++)
        {
            for(int j = 1; j < _mapWidth + 1; j++)
            {
                Instantiate(_wallBrock, new Vector3(i , 0 , -j),Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
