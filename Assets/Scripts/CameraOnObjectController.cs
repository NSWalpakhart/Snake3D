using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnObjectController : MonoBehaviour
{
    private Camera _camera;
    [Range(1, 2)][SerializeField] private bool _cameraView;
    private void Start()
    {
        _camera = GetComponent<Camera>();
    }
    private void Update()
    {
        CameraChange();
    }

    public void CameraChange()
    {
        if (_cameraView)
            _camera.enabled = false;
        else _camera.enabled = true;
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (_cameraView)
                _cameraView = false;
            else
                _cameraView=true;
        }
    }
    public void CameraClickChange()
    {
        _cameraView=!_cameraView;
    }
}

