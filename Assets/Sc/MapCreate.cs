using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapCreate : MonoBehaviour
{
    [SerializeField] Text _text = default;
    //[SerializeField] TextAsset _textAsset = default;
    [SerializeField] string _loadText = default;
    [SerializeField] string[] _splitText = default;

    [SerializeField] string _textFileName = default;

    [SerializeField] string _wallNumber = default;
    void Start()
    {
        _loadText = (Resources.Load(_textFileName, typeof(TextAsset)) as TextAsset).text;
        string[] line = _loadText.Split(' ');
        for(int i = 0; i < line.Length; i++)
        {
            //_splitText[i] = int.Parse(line[i]);
            //Debug.Log(line[i]);
        }

        for(int j = 0; j < _splitText.Length; j++)
        {
            if(_splitText[j] == _wallNumber)
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
