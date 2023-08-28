using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        // Détruire l'objet collectable une fois qu'il a été collecté
        Destroy(gameObject);
    }
}