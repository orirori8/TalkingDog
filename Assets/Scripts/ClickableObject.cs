using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [Header("Optional Settings")]
    public GameObject targetObject; // Reference to any GameObject
    public bool disableOnClick = false; // Defaults to false

    private bool isActiveState = true; // Tracks current state for toggling

    public void OnObjectClicked()
    {
        Debug.Log(name + " was clicked!");

        if (disableOnClick && targetObject != null)
        {
            isActiveState = !isActiveState; // Toggle state
            targetObject.SetActive(isActiveState);
        }
        else
        {
            // Normal click logic here
        }
    }
}
