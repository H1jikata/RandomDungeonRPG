using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    [Header("FadeのPanel関係")]
    [SerializeField] float _fadeSpeed = 0.02f;
    [SerializeField] float _alfa = default;
    [SerializeField] bool Isfade = false;

    [SerializeField, Tooltip("戦闘シーンの名前")] string _sceneName = default;
    Image _fadeImage;

    public static Fade instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        _fadeImage = GetComponent<Image>();
        _alfa = _fadeImage.color.a;
        FadeStart(false);
    }

    private void Update()
    {
        if (Isfade == true)
        {
            _alfa += _fadeSpeed;
            _fadeImage.color = new Color(0, 0, 0, _alfa);

            if (_alfa >= 1)
            {
                SceneManager.LoadScene(_sceneName);
            }
        }
    }

    public void FadeStart(bool isstart)
    {
        if(isstart == true)
        {
            Isfade = true;
            _fadeImage.enabled = true;
        }
    }
}
