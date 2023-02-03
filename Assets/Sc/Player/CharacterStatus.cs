using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    [SerializeField, Tooltip("経験値テーブルの名前")]
    string _levelupTabelFileName;

    /// <summary>読み込んだテキストを保存しておく変数</summary>
    string _levelupText;
    /// <summary>テキストを分割したものを保存する配列</summary>
    string[] _splitLevelupText;
    /// <summary>現在のPlayerのレベル</summary>
    string[] _currentLevel;
    /// <summary>現在の経験値量</summary>
    int _currentEXP;
    /// <summary>次のレベルとあがるための経験値量を保存する</summary>
    string[] _nextLevelEXP;
    private void Start()
    {
        _levelupText = (Resources.Load(_levelupTabelFileName, typeof(TextAsset)) as TextAsset).text;

        _splitLevelupText = _levelupText.Split('\n');
        _currentLevel = _splitLevelupText[1].Split(',');
        Debug.Log("現在のPlayerのLevelは" + _currentLevel[0]);

        _nextLevelEXP = _splitLevelupText[int.Parse(_currentLevel[0]) + 1].Split(',');
        Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + _nextLevelEXP[1] +　"です");
    }


    public void test()
    {
        LevelUP(2);
    }
    void LevelUP(int n)
    {
        _currentEXP += n;
        if(int.Parse(_nextLevelEXP[1]) <= _currentEXP)
        {
            _currentEXP = System.Math.Abs(_currentEXP) - System.Math.Abs(int.Parse(_nextLevelEXP[1]));
            _currentLevel[0] = _nextLevelEXP[0];

            Debug.Log("レベルアップ！");
            Debug.Log("現在のPlayerLevelは" + _currentLevel[0] + "です");

            _nextLevelEXP = _splitLevelupText[int.Parse(_currentLevel[0]) + 1].Split(',');
            Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + (int.Parse(_nextLevelEXP[1]) - _currentEXP) + "です");
        }
        else
        {
            Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + (int.Parse(_nextLevelEXP[1]) - _currentEXP) + "です");
        }
    }
}
