using UnityEngine;

public class DissolveController : MonoBehaviour
{
    [SerializeField] private Material dissolveMaterial;
    [SerializeField, Range(0.0f, 1f)] private float dissolveDuration = 1f;
    [SerializeField] private Color edgeColor = Color.yellow;

    private float dissolveAmount = 1f;

    private void Start()
    {
        if (dissolveMaterial)
        {
            dissolveMaterial.SetFloat("_DissolveAmount", dissolveAmount);
            dissolveMaterial.SetColor("_EdgeColor", edgeColor);
        }
    }

    private void Update()
    {
        if (dissolveAmount > 0f)
        {
            dissolveAmount -= Time.deltaTime / dissolveDuration;
            dissolveMaterial.SetFloat("_DissolveAmount", dissolveAmount);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
