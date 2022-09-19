using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] int _sizeX = 40;
    [SerializeField] int _sizeY = 30;
    [SerializeField] int _xRectMin = 7; // 部屋の最小X = 4
    [SerializeField] int _yRectMin = 7; // 部屋の最小Y = 4
    [SerializeField] int _xLoadMax = 2;
    [SerializeField] int _yLoadMax = 2;
    [SerializeField] int _floorMax = 6;
    [SerializeField] int _floorPadding = 2;

    public enum Type
    {
        _none,
        _wall,
        _floor,
        _loadUp,
        _loadDown,
        _loadRight,
        _loadLeft,
        _loadUpAlone,
        _loadLeftAlone,
        _etc1, _etc2, _etc3, _etc4, _etc5
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


