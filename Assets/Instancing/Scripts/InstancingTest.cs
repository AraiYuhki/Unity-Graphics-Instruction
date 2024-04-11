using UnityEngine;

public class InstancingTest : MonoBehaviour
{
    [SerializeField]
    private new MeshRenderer renderer;
    private MaterialPropertyBlock propertyBlock;

    private void Awake()
    {
        propertyBlock = new MaterialPropertyBlock();
        propertyBlock.SetColor("_Color", new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f));
        renderer.SetPropertyBlock(propertyBlock);
    }
}
