
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Please mention your classe use or introduction here (this is  a template class for demo)
/// </summary>

public class PerspectiveCamera : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    Vector2 rotation;
    private float _currentZoom = 20;
    [SerializeField]
    private float _maxZoom = 60;
    [SerializeField]
    private float _minZoom = 20;
    [SerializeField]
    private float _zoomSmooth = 10;
    [SerializeField]
    private float _rotationSens = 1;
    [SerializeField]
    private float _distance = 50;
    #endregion
    #region PUBLIC_VARIABLES
    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    void Update()
    {
        Rotation();
        Zoom();

    }

    private void Rotation()
    {
        Vector2 rot = Vector2.zero;
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            rot = touch.deltaPosition;
        }
        else
        {
            rot.x = Input.GetAxis("Mouse X");
            rot.y = Input.GetAxis("Mouse Y");
        }

        rotation.x += rot.x;
        rotation.y -= rot.y;

        Vector3 finalRotation = new Vector3(rotation.y * _rotationSens, rotation.x * _rotationSens);
        transform.eulerAngles = finalRotation;
    }

    private void Zoom()
    {
        if (Input.touchCount < 2) //for PC use
        {
            _currentZoom += Input.GetAxis("Mouse ScrollWheel") * _zoomSmooth;
        }
        else
        {
            Touch touchZ = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchzPrevPose = touchZ.position - touchZ.deltaPosition;
            Vector2 touchOnePrevPose = touchOne.position - touchOne.deltaPosition;


            float touchPrevDeltaMag = (touchzPrevPose - touchOnePrevPose).magnitude;
            float touchDeltaMAG = (touchZ.position - touchOne.position).magnitude;
            
            //getting diffrence of deltas
            float deltaMagSub = touchPrevDeltaMag - touchDeltaMAG;

            _currentZoom += deltaMagSub * _zoomSmooth;
        }

        _currentZoom = Mathf.Clamp(_currentZoom, _minZoom, _maxZoom);
        float final = _currentZoom - _distance;
        transform.position = transform.forward * (final);
    }
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
}

