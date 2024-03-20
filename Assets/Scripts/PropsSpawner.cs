using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PropsSpawner : MonoBehaviour
{
    [SerializeField] private ARPlaneManager planeManager;
    private bool isPropSpawned;
    [SerializeField] private GameObject propPrefab;
    public GameObject prop;
    private void Start()
    {
        SubscribeToPlanesChanged();
    }
    public void OnPlanesChanged(ARPlanesChangedEventArgs changes)
    {
        foreach (var plane in changes.added)
        {
            if (!isPropSpawned)
            {
                prop = Instantiate(propPrefab, plane.transform.position, plane.transform.rotation);
                isPropSpawned = true;
            }
            // handle added planes
        }

        foreach (var plane in changes.updated)
        {
            // handle updated planes
        }

        foreach (var plane in changes.removed)
        {
            // handle removed planes
        }
    }
    void SubscribeToPlanesChanged()
    {
        planeManager.planesChanged += OnPlanesChanged;
    }
}
