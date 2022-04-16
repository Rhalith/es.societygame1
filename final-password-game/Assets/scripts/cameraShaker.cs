using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShaker : MonoBehaviour
{
    public float duration = 0.5f;
    public AnimationCurve AnimationCurve;
    public void StartShaking()
    {
        StartCoroutine(Shaker());
    }
    IEnumerator Shaker()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = AnimationCurve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength * 5/2;
            yield return null;
        }
        transform.position = startPosition;
    }
}
