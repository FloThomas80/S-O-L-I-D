using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        // D�truire l'objet collectable une fois qu'il a �t� collect�
        Destroy(gameObject);
    }
}