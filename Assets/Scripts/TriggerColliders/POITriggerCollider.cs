using UnityEngine;

public class POITriggerCollider : MonoBehaviour
{
    public CameraController cameraController;
    public Animator poiController; // Start is called before the first frame update
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
        poiController.SetBool("panOut", true);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) cameraController.ShowMainCamera();
        poiController.SetBool("panOut", false);
    }
}
