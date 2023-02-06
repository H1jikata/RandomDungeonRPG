using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour
{
    [SerializeField, Tooltip("経験値テーブルの名前")]
    string _levelupTabelFileName;
    [SerializeField, Tooltip("ステータスのテキストの名前")]
    string _statusTextName;
    [SerializeField, Tooltip("ScriptableObjectの名前")]
    CharacterData _dataName;

    /// <summary>読み込んだテキストを保存しておく変数</summary>
    string _levelupText;
    string _statusData;
    /// <summary>テキストを分割したものを保存する配列</summary>
    string[] _splitLevelupText;
    string[] _splitStatusupText;
    /// <summary>現在のPlayerのレベル</summary>
    string[] _currentLevel;
    /// <summary>現在の経験値量</summary>
    int _currentEXP;
    /// <summary>次のレベルとあがるための経験値量と各ステータスを保存する</summary>
    string[] _nextLevelEXP;
    string[]_statusDatas;
    private void Start()
    {
        _statusData = (Resources.Load(_statusTextName, typeof(TextAsset)) as TextAsset).text;

        _splitStatusupText = _statusData.Split('\n');

        for(int i = 0; i < _splitStatusupText.Length - 2; i++)
        {
            _statusDatas = _splitStatusupText[i + 1].Split(',');
            _dataName._exp[i] = int.Parse(_statusDatas[0]);
            _dataName._hp[i] = int.Parse(_statusDatas[1]);
            _dataName._mp[i] = int.Parse(_statusDatas[2]);
            _dataName._str[i] = int.Parse(_statusDatas[3]);
            _dataName._def[i] = int.Parse(_statusDatas[4]);
            _dataName._speed[i] = int.Parse(_statusDatas[5]);
        }
        CurrentStatus();
    }

    void CurrentStatus()
    {
        _levelupText = (Resources.Load(_levelupTabelFileName, typeof(TextAsset)) as TextAsset).text;

        _splitLevelupText = _levelupText.Split('\n');
        _currentLevel = _splitLevelupText[1].Split(',');

        checkStatus();

        _nextLevelEXP = _splitLevelupText[int.Parse(_currentLevel[0]) + 1].Split(',');

        Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + _nextLevelEXP[1] + "です");
    }

    /// <summary>レベルアップが可能か判断する</summary>
    /// <param name="n">敵を倒した時に入手する経験値</param>
    void LevelUP(int n)
    {
        _currentEXP += n;
        if(int.Parse(_nextLevelEXP[1]) <= _currentEXP)
        {
            _currentEXP = System.Math.Abs(_currentEXP) - System.Math.Abs(int.Parse(_nextLevelEXP[1]));
            _currentLevel[0] = _nextLevelEXP[0];

            Debug.Log("レベルアップ！");
            checkStatus();

            _nextLevelEXP = _splitLevelupText[int.Parse(_currentLevel[0]) + 1].Split(',');
            Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + (int.Parse(_nextLevelEXP[1]) - _currentEXP) + "です");
        }
        else
        {
            Debug.Log(_nextLevelEXP[0] + "Levelにあがるのに必要な経験値量は" + (int.Parse(_nextLevelEXP[1]) - _currentEXP) + "です");
        }
    }

    /// <summary>現在のステータスを確認する（デバッグ用)</summary>
    void checkStatus()
    {
        Debug.Log("現在のPlayerLevelは" + _currentLevel[0] + "です");
        Debug.Log("現在のPlayerのHPは" + _dataName._hp[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("現在のPlayerのMPは" + _dataName._mp[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("現在のPlayerの力は" + _dataName._str[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("現在のPlayerの防御力は" + _dataName._def[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("現在のPlayerの素早さは" + _dataName._speed[int.Parse(_currentLevel[0]) - 1]);
    }

    public void test()
    {
        LevelUP(2);
    }
}
