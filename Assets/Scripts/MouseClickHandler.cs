using UnityEngine;

public class MouseClickHandler : MonoBehaviour
{
    // This layer mask lets you choose which layers can be clicked
    public LayerMask clickableLayers;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse click
        {
            CheckClick();
        }
    }

    void CheckClick()
    {
        // Get mouse position in screen space
        Vector3 mousePos = Input.mousePosition;

        // Convert to a ray from the camera
        Ray ray = Camera.main.ScreenPointToRay(mousePos);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickableLayers))
        {
            Debug.Log("Clicked on: " + hit.collider.name);

            // If the object has a script with an OnObjectClicked method
            hit.collider.gameObject.SendMessage("OnObjectClicked", SendMessageOptions.DontRequireReceiver);
        }
    }
}
