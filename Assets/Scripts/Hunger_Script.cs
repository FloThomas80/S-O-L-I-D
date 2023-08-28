using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger_Script : MonoBehaviour
{

    public float _maxScale = 1f; // scale max de la barre
    public float _currentScale = 0f; // on part a zero (on a pas faim au debut du game)

    [SerializeField] private float _hungerSpeed = 0.01f; // a equilibrer pour un gameplay
    [SerializeField] private RectTransform _hungerBar;
    private void Update()
    {
        if (_currentScale < _maxScale)
        {
            _currentScale += Time.deltaTime * _hungerSpeed;
            _currentScale = Mathf.Clamp(_currentScale, 0f, _maxScale);

            _hungerBar.localScale = new Vector3(_currentScale, _hungerBar.localScale.y, _hungerBar.localScale.z);
        }
    }
    public void DecreaseHunger(float amount)
    {
        if (_currentScale > 0f)
        {
            _currentScale -= amount;
            _currentScale = Mathf.Clamp(_currentScale, 0f, _maxScale);

            _hungerBar.localScale = new Vector3(_currentScale, _hungerBar.localScale.y, _hungerBar.localScale.z);
        }
    }
}

