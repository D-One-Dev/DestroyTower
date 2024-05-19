using System.Collections;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float lifetime;
    void Start()
    {
        StartCoroutine(Lifetime());
    }

    private IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
