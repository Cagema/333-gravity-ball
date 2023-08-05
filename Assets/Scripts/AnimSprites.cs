using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSprites : MonoBehaviour
{
    [SerializeField] Sprite[] _sprites;
    [SerializeField] float _speed;

    int _index;
    float _timer;
    SpriteRenderer _sr;
    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (GameManager.Single.GameActive)
        {
            _timer += Time.deltaTime;
            if (_timer > _speed)
            {
                _timer = 0;
                _sr.sprite = _sprites[++_index % _sprites.Length];
            }
        }
    }
}
