using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Script : MonoBehaviour
{
    private float _maxScale = 1f; // scale max de la barre
    private float _currentScale = 1f; // on part a zero (on a pas faim au debut du game)
    [SerializeField] private float _hungerDammage;
    [SerializeField] private RectTransform _healthBar;
    [SerializeField] private Hunger_Script _hungerBar;
    [SerializeField] private UIDammages _uIdammages;



    private void Update()
    {
        if (_hungerBar._currentScale >= _hungerBar._maxScale)
        {
            DecreaseHealth(_hungerDammage/100);
            _uIdammages.TakeDamageUI(true);
        }

    }
    public void DecreaseHealth(float amount)
    {
        if (_currentScale > 0f)
        {
            _currentScale -= amount;
            _currentScale = Mathf.Clamp(_currentScale, 0f, _maxScale);

            _healthBar.localScale = new Vector3(_currentScale, _healthBar.localScale.y, _healthBar.localScale.z);
        }
    }
}
