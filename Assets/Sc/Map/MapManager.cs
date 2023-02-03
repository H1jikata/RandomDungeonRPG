using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] 
    string[] _splitText = default;
    [SerializeField] 
    string _textFileName = default;

    [SerializeField]
    float _positionX, _positionY, _positionZ;
    [SerializeField] 
    GameObject _wallPrefub = default;
    [SerializeField] 
    GameObject _roadPrefub = default;

    /// <summary>読み込んだマップのテキストの保存</summary>
    string _mapText;
    /// <summary></summary>
    int _x, _y;
    void Start()
    {
        _mapText = (Resources.Load(_textFileName, typeof(TextAsset)) as TextAsset).text;
        _splitText = _mapText.Split('\n');

        //csvファイルで読み込むため原則縦、横は必ず同じ数値だが念のため
        _x = _splitText[0].Split(',').Length;
        _y = _splitText.Length;

        string[,] _map = new string[_x, _y];

        for(int i = 0; i < _x - 1; i++)
        {
            string[] _tempWords = _splitText[i].Split(',');

            for(int l = 0; l < _y - 1; l++)
            {
                _map[i, l] = _tempWords[l];
                if(_map[i, l] != null)
                {
                    switch(_map[i, l])
                    {
                        case "1":
                            Instantiate(_wallPrefub, new Vector3(_positionX + l, _positionY, _positionZ - i), Quaternion.identity);
                            break;

                        case "2":
                            Instantiate(_roadPrefub, new Vector3(_positionX + l, _positionY, _positionZ - i), Quaternion.identity);
                            break;

                        case "3":
                            Instantiate(_roadPrefub, new Vector3(_positionX + l, _positionY, _positionZ - i), Quaternion.identity);
                            break;
                    }
                }
            }
        }
    }
}
