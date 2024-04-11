using UnityEngine;

public class ObjectDuplicator : MonoBehaviour
{
    [SerializeField]
    private GameObject original;
    [SerializeField]
    private int objectCount = 10000;

    private void Awake()
    {
        for (var count = 0; count < objectCount; count++)
        {
            var screenPoint = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(5f, 20f));
            var position = Camera.main.ViewportToWorldPoint(screenPoint);
            var go = Instantiate(original, transform);
            go.transform.position = position;
        }
    }
}
