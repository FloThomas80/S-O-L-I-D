using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMorphing_Script : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public string blendShapeName = "Fatness";
    public float morphSpeed = 1f;

    private float currentBlendWeight = 0f;
    private bool isMorphing = false;
    private float targetBlendWeight = 0f;

    private void Update()
    {
        if (isMorphing)
        {
            currentBlendWeight = Mathf.MoveTowards(currentBlendWeight, targetBlendWeight, morphSpeed * Time.deltaTime);
            skinnedMeshRenderer.SetBlendShapeWeight(skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName), currentBlendWeight);

            if (currentBlendWeight == targetBlendWeight)
            {
                isMorphing = false;
            }
        }
    }

    public void MorphToBlendWeight(float blendWeight)
    {
        targetBlendWeight += blendWeight;
        isMorphing = true;
    }
}
