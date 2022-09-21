using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [Header("FadeのPanel関係")]
    [SerializeField] float _fadeSpeed = 0.02f;
    [SerializeField] float _alfa = default;

    [SerializeField] bool Isfade = false;
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
