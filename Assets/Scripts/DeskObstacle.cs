using UnityEngine;

public class DeskObstacle : MonoBehaviour
{
    void Awake()
    {
        var mainRenderer = GetComponent<Renderer>();
        // Only build details if main cube is visible (not a prefab with children)
        if (mainRenderer == null || !mainRenderer.enabled) return;

        // Desk top
        GameObject top = GameObject.CreatePrimitive(PrimitiveType.Cube);
        top.transform.parent = transform;
        top.transform.localPosition = new Vector3(0, 0.5f, 0);
        top.transform.localScale = new Vector3(2f, 0.2f, 1f);
        var topRenderer = top.GetComponent<Renderer>();
        if (topRenderer != null)
        {
            topRenderer.material.color = new Color(0.8f, 0.5f, 0.2f); // Brown
        }

        // Desk legs (4 legs)
        float legHeight = 0.5f;
        float legThickness = 0.1f;
        Vector3[] legPositions = new Vector3[] {
            new Vector3(-0.9f, 0, -0.4f),
            new Vector3(0.9f, 0, -0.4f),
            new Vector3(-0.9f, 0, 0.4f),
            new Vector3(0.9f, 0, 0.4f)
        };
        foreach (var pos in legPositions)
        {
            GameObject leg = GameObject.CreatePrimitive(PrimitiveType.Cube);
            leg.transform.parent = transform;
            leg.transform.localPosition = pos;
            leg.transform.localScale = new Vector3(legThickness, legHeight, legThickness);
            var legRenderer = leg.GetComponent<Renderer>();
            if (legRenderer != null)
            {
                legRenderer.material.color = new Color(0.4f, 0.2f, 0.1f); // Dark brown
            }
        }
        // Hide main cube
        mainRenderer.enabled = false;
    }
}
