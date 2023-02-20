using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField, Tooltip("ステータスのテキストの名前")]
    string _statusTextName;
    [SerializeField, Tooltip("ScriptableObjectの名前")]
    CharacterData _enemyData;

    DataBase _playerDataSave = new DataBase();
    /// <summary>読み込んだテキストを保存しておく変数</summary>
    string _statusData;
    /// <summary>テキストを分割したものを保存する配列</summary>
    string[] _splitStatusupText;
    /// <summary>現在のEnemyのレベル</summary>
    string[] _currentLevel;
    /// <summary>現在の経験値量</summary>
    int _currentEXP;
    /// <summary>各ステータスを保存する</summary>
    string[] _statusDatas;
    private void Start()
    {
        
        _statusData = (Resources.Load(_statusTextName, typeof(TextAsset)) as TextAsset).text;

        _splitStatusupText = _statusData.Split('\n');

        for (int i = 0; i < _splitStatusupText.Length - 2; i++)//データを格納している
        {
            _statusDatas = _splitStatusupText[i + 1].Split(',');
            _enemyData._level[i] = int.Parse(_statusDatas[0]);
            _enemyData._hp[i] = int.Parse(_statusDatas[1]);
            _enemyData._mp[i] = int.Parse(_statusDatas[2]);
            _enemyData._str[i] = int.Parse(_statusDatas[3]);
            _enemyData._def[i] = int.Parse(_statusDatas[4]);
            _enemyData._speed[i] = int.Parse(_statusDatas[5]);
        }
    }
    /// <summary>現在のステータスを確認する（デバッグ用)</summary>
    void checkStatus()
    {
        Debug.Log("EnemyLevelは" + _currentLevel[0] + "です");
        Debug.Log("EnemyのHPは" + _enemyData._hp[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("EnemyのMPは" + _enemyData._mp[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("Enemyの力は" + _enemyData._str[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("Enemyの防御力は" + _enemyData._def[int.Parse(_currentLevel[0]) - 1]);
        Debug.Log("Enemyの素早さは" + _enemyData._speed[int.Parse(_currentLevel[0]) - 1]);
    }
}
