using UnityEngine;

public class DeerTriggerCollider : MonoBehaviour
{
    public CameraController cameraController;
    public Animator deerCameraAnimator;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) cameraController.ShowDeerCamera();

        Debug.Log("panning out");
        deerCameraAnimator.SetBool("panOut", true);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) cameraController.ShowMainCamera();
        deerCameraAnimator.SetBool("panOut", false);
    }
}
