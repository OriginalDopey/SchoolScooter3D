using UnityEngine;

public class ChairObstacle : MonoBehaviour
{
    void Awake()
    {
        var mainRenderer = GetComponent<Renderer>();
        // Only build details if main cube is visible (not a prefab with children)
        if (mainRenderer == null || !mainRenderer.enabled) return;

        // Chair seat
        GameObject seat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        seat.transform.parent = transform;
        seat.transform.localPosition = new Vector3(0, 0.3f, 0);
        seat.transform.localScale = new Vector3(0.8f, 0.1f, 0.8f);
        var seatRenderer = seat.GetComponent<Renderer>();
        if (seatRenderer != null)
        {
            seatRenderer.material.color = new Color(0.2f, 0.2f, 0.8f); // Blue
        }

        // Chair backrest
        GameObject backrest = GameObject.CreatePrimitive(PrimitiveType.Cube);
        backrest.transform.parent = transform;
        backrest.transform.localPosition = new Vector3(0, 0.6f, -0.35f);
        backrest.transform.localScale = new Vector3(0.8f, 0.5f, 0.1f);
        var backRenderer = backrest.GetComponent<Renderer>();
        if (backRenderer != null)
        {
            backRenderer.material.color = new Color(0.2f, 0.2f, 0.8f); // Blue
        }

        // Chair legs (4 legs)
        float legHeight = 0.3f;
        float legThickness = 0.08f;
        Vector3[] legPositions = new Vector3[] {
            new Vector3(-0.35f, 0, -0.35f),
            new Vector3(0.35f, 0, -0.35f),
            new Vector3(-0.35f, 0, 0.35f),
            new Vector3(0.35f, 0, 0.35f)
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
                legRenderer.material.color = new Color(0.1f, 0.1f, 0.3f); // Dark blue
            }
        }
        // Hide main cube
        mainRenderer.enabled = false;
    }
}
