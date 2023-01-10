using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] 
    string _mapText = default;
    [SerializeField] 
    string[] _splitText = default;
    [SerializeField]
    int _x, _y;
    [SerializeField] 
    string _textFileName = default;

    [SerializeField]
    Vector3 _positionX, _positionY, _positionZ;
    [SerializeField] 
    GameObject _wallPrefub = default;
    [SerializeField] 
    GameObject _roadPrefub = default;
    void Start()
    {
        _mapText = (Resources.Load(_textFileName, typeof(TextAsset)) as TextAsset).text;
        _splitText = _mapText.Split('\n');

        //csvファイルで読み込むため原則縦、横は必ず同じ数値だが念のため
        _x = _splitText[0].Split(',').Length;
        _y = _splitText.Length;

        string[,] _map = new string[_x, _y];

        for(int i = 0; i < _y; i++)
        {

        }
    }
}
