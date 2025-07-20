using UnityEngine;

public class MiddleSchoolBoyBuilder : MonoBehaviour
{
    void Awake()
    {
        // Body (Capsule)
        var body = gameObject;
        var bodyRenderer = body.GetComponent<Renderer>();
        if (bodyRenderer != null)
            bodyRenderer.material.color = new Color(1f, 1f, 1f); // White shirt

        // Head
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        head.transform.parent = transform;
        head.transform.localPosition = new Vector3(0, 1.2f, 0);
        head.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        var headRenderer = head.GetComponent<Renderer>();
        if (headRenderer != null)
            headRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Left Arm
        GameObject leftArm = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftArm.transform.parent = transform;
        leftArm.transform.localPosition = new Vector3(-0.4f, 0.8f, 0);
        leftArm.transform.localScale = new Vector3(0.15f, 0.5f, 0.15f);
        leftArm.transform.localRotation = Quaternion.Euler(0, 0, 30);
        var leftArmRenderer = leftArm.GetComponent<Renderer>();
        if (leftArmRenderer != null)
            leftArmRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Right Arm
        GameObject rightArm = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightArm.transform.parent = transform;
        rightArm.transform.localPosition = new Vector3(0.4f, 0.8f, 0);
        rightArm.transform.localScale = new Vector3(0.15f, 0.5f, 0.15f);
        rightArm.transform.localRotation = Quaternion.Euler(0, 0, -30);
        var rightArmRenderer = rightArm.GetComponent<Renderer>();
        if (rightArmRenderer != null)
            rightArmRenderer.material.color = new Color(1f, 0.85f, 0.7f); // Skin tone

        // Left Leg
        GameObject leftLeg = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        leftLeg.transform.parent = transform;
        leftLeg.transform.localPosition = new Vector3(-0.15f, 0.2f, 0);
        leftLeg.transform.localScale = new Vector3(0.18f, 0.7f, 0.18f);
        leftLeg.transform.localRotation = Quaternion.Euler(0, 0, 10);
        var leftLegRenderer = leftLeg.GetComponent<Renderer>();
        if (leftLegRenderer != null)
            leftLegRenderer.material.color = new Color(0.2f, 0.3f, 0.8f); // Blue pants

        // Right Leg
        GameObject rightLeg = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        rightLeg.transform.parent = transform;
        rightLeg.transform.localPosition = new Vector3(0.15f, 0.2f, 0);
        rightLeg.transform.localScale = new Vector3(0.18f, 0.7f, 0.18f);
        rightLeg.transform.localRotation = Quaternion.Euler(0, 0, -10);
        var rightLegRenderer = rightLeg.GetComponent<Renderer>();
        if (rightLegRenderer != null)
            rightLegRenderer.material.color = new Color(0.2f, 0.3f, 0.8f); // Blue pants

        // Backpack
        GameObject backpack = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        backpack.transform.parent = transform;
        backpack.transform.localPosition = new Vector3(0, 0.8f, -0.3f);
        backpack.transform.localScale = new Vector3(0.2f, 0.4f, 0.2f);
        var backpackRenderer = backpack.GetComponent<Renderer>();
        if (backpackRenderer != null)
            backpackRenderer.material.color = new Color(0.1f, 0.7f, 0.2f); // Green backpack
    }
}
