using UnityEngine;

public class RefinedScooterBoyBuilder : MonoBehaviour
{
    [Header("Animation")]
    public bool animateKick = true;
    public float kickSpeed = 2.5f;
    public float kickAngle = 45f;

    private Transform leftLeg, rightLeg;

    void Awake()
    {
        // Body (Capsule)
        var body = gameObject;
        var bodyRenderer = body.GetComponent<Renderer>();
        if (bodyRenderer != null)
            bodyRenderer.material.color = new Color(0.1f, 0.2f, 0.4f); // Navy blue shirt
        body.transform.localScale = new Vector3(0.5f, 1.2f, 0.5f);

        // Head
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        head.transform.parent = transform;
        head.transform.localPosition = new Vector3(0, 1.4f, 0);
        head.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
        var headRenderer = head.GetComponent<Renderer>();
        if (headRenderer != null)
            headRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Left Arm (holding handlebar)
        GameObject leftArm = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftArm.transform.parent = transform;
        leftArm.transform.localPosition = new Vector3(-0.25f, 1.0f, 0.2f);
        leftArm.transform.localScale = new Vector3(0.12f, 0.5f, 0.12f);
        leftArm.transform.localRotation = Quaternion.Euler(0, 0, 60);
        var leftArmRenderer = leftArm.GetComponent<Renderer>();
        if (leftArmRenderer != null)
            leftArmRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Right Arm (holding handlebar)
        GameObject rightArm = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightArm.transform.parent = transform;
        rightArm.transform.localPosition = new Vector3(0.25f, 1.0f, 0.2f);
        rightArm.transform.localScale = new Vector3(0.12f, 0.5f, 0.12f);
        rightArm.transform.localRotation = Quaternion.Euler(0, 0, -60);
        var rightArmRenderer = rightArm.GetComponent<Renderer>();
        if (rightArmRenderer != null)
            rightArmRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Left Leg (on scooter deck)
        leftLeg = GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform;
        leftLeg.parent = transform;
        leftLeg.localPosition = new Vector3(-0.12f, 0.2f, 0.1f);
        leftLeg.localScale = new Vector3(0.15f, 0.7f, 0.15f);
        leftLeg.localRotation = Quaternion.Euler(0, 0, 0);
        var leftLegRenderer = leftLeg.GetComponent<Renderer>();
        if (leftLegRenderer != null)
            leftLegRenderer.material.color = new Color(0.8f, 0.7f, 0.5f); // Khaki pants

        // Right Leg (kicking)
        rightLeg = GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform;
        rightLeg.parent = transform;
        rightLeg.localPosition = new Vector3(0.12f, 0.2f, 0.1f);
        rightLeg.localScale = new Vector3(0.15f, 0.7f, 0.15f);
        rightLeg.localRotation = Quaternion.Euler(0, 0, 0);
        var rightLegRenderer = rightLeg.GetComponent<Renderer>();
        if (rightLegRenderer != null)
            rightLegRenderer.material.color = new Color(0.8f, 0.7f, 0.5f); // Khaki pants

        // Scooter Deck
        GameObject deck = GameObject.CreatePrimitive(PrimitiveType.Cube);
        deck.transform.parent = transform;
        deck.transform.localPosition = new Vector3(0, 0.05f, 0.25f);
        deck.transform.localScale = new Vector3(0.5f, 0.08f, 1.0f);
        var deckRenderer = deck.GetComponent<Renderer>();
        if (deckRenderer != null)
            deckRenderer.material.color = new Color(0.3f, 0.3f, 0.3f); // Dark gray

        // Scooter Handlebar
        GameObject handlebar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        handlebar.transform.parent = transform;
        handlebar.transform.localPosition = new Vector3(0, 1.1f, 0.45f);
        handlebar.transform.localScale = new Vector3(0.05f, 0.5f, 0.05f);
        handlebar.transform.localRotation = Quaternion.Euler(90, 0, 0);
        var handlebarRenderer = handlebar.GetComponent<Renderer>();
        if (handlebarRenderer != null)
            handlebarRenderer.material.color = new Color(0.2f, 0.2f, 0.2f); // Black

        // Scooter Wheels
        for (int i = -1; i <= 1; i += 2)
        {
            GameObject wheel = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            wheel.transform.parent = transform;
            wheel.transform.localPosition = new Vector3(0, 0.0f, 0.25f + i * 0.45f);
            wheel.transform.localScale = new Vector3(0.18f, 0.05f, 0.18f);
            wheel.transform.localRotation = Quaternion.Euler(90, 0, 0);
            var wheelRenderer = wheel.GetComponent<Renderer>();
            if (wheelRenderer != null)
                wheelRenderer.material.color = new Color(0.1f, 0.1f, 0.1f); // Black
        }
    }

    void Update()
    {
        // Animate the kicking leg
        if (animateKick && rightLeg != null)
        {
            float angle = Mathf.Sin(Time.time * kickSpeed) * kickAngle;
            rightLeg.localRotation = Quaternion.Euler(angle, 0, 0);
        }
    }
}
