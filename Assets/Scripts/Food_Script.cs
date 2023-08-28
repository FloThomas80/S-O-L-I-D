using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Script : CollectableItem
{
    [SerializeField] private bool _goodBadFood; //good is true
    [SerializeField] private float _satiete;
    [SerializeField] private float _speedMalus;
    [SerializeField] private Hunger_Script _hunger_Script;
    [SerializeField] private CharacterMorphing_Script _characterMorph;
    [SerializeField] private Player_Controller _PlayController;

    private void OnTriggerEnter(Collider WhoHitMe)
    {
        Collect();
        _hunger_Script.DecreaseHunger(_satiete/100);
        //SoundController_Script.Instance.LaunchEatSound();
        _characterMorph.MorphToBlendWeight(_speedMalus*-10);
        _PlayController.IncreaseSpeed(_speedMalus);
    }
}
