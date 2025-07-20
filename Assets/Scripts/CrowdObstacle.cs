using UnityEngine;

public class CrowdObstacle : MonoBehaviour
{
    void Awake()
    {
        var mainRenderer = GetComponent<Renderer>();
        // Only build details if main sphere is visible (not a prefab with children)
        if (mainRenderer == null || !mainRenderer.enabled) return;

        // Create a group of spheres to represent a crowd
        int crowdSize = 6;
        Vector3[] positions = new Vector3[] {
            new Vector3(0, 0.5f, 0),
            new Vector3(-0.5f, 0.5f, 0.3f),
            new Vector3(0.5f, 0.5f, -0.3f),
            new Vector3(-0.3f, 0.5f, -0.5f),
            new Vector3(0.3f, 0.5f, 0.5f),
            new Vector3(0, 0.5f, -0.6f)
        };
        Color[] colors = new Color[] {
            new Color(1f, 0.8f, 0.2f), // Yellow
            new Color(0.2f, 0.8f, 1f), // Blue
            new Color(0.8f, 0.2f, 0.2f), // Red
            new Color(0.2f, 1f, 0.2f), // Green
            new Color(1f, 0.2f, 0.8f), // Pink
            new Color(0.8f, 0.8f, 0.8f) // Light gray
        };
        for (int i = 0; i < crowdSize; i++)
        {
            GameObject person = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            person.transform.parent = transform;
            person.transform.localPosition = positions[i];
            person.transform.localScale = new Vector3(0.5f, 0.8f, 0.5f);
            var renderer = person.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = colors[i];
            }
        }
        // Hide main sphere
        mainRenderer.enabled = false;
    }
}
