using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera deerCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        deerCamera.enabled = false;
    }

    public void ShowDeerCamera()
    {
        Debug.Log("Showing deer camera");
        mainCamera.enabled = false;
        deerCamera.enabled = true;
    }
    
    
    public void ShowMainCamera()
    {
        mainCamera.enabled = true;
        deerCamera.enabled = false;
    }

}
