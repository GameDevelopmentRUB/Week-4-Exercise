using UnityEngine;

// This script uses the events on the 'Event Trigger' Component, which needs to be on the Image itself
// Here the PointerDown and Drag events are used to make the Image draggable. You could accomplish the
// same thing with other events like BeginDrag and EndDrag.

public class ImageDragger : MonoBehaviour
{
    Vector3 offset;

    // This is connected to the 'PointerDown' event. The method calculates the difference
    // between position and mouse, so that the Image doesn't snap to the center of the mouse.
    public void CalculateOffset()
    {
        offset = transform.position - Input.mousePosition;
    }

    // This is connected to the 'Drag' event. Input.mousePosition does not need to be converted,
    // because the Canvas is set to 'Screen Space - Overlay', which is already in pixel coordinates.
    // The code won't work for 'Screen Space - Camera', as that would require World Units
    public void FollowMouse()
    {
        transform.position = Input.mousePosition + offset;
    }
}
