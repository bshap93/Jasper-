using UnityEngine;

public class POI01CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera poi01Camera;
    // Start is called before the first frame update
    void Start()
    {
        poi01Camera.enabled = false;
    }

    public void ShowPOI01Camera()
    {
        Debug.Log("Showing POI01 camera");
        mainCamera.enabled = false;
        poi01Camera.enabled = true;
    }

    public void ShowMainCamera()
    {
        mainCamera.enabled = true;
        poi01Camera.enabled = false;
    }
}
