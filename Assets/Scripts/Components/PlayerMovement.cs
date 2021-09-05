
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
/// Player movement Scripts
/// Joystick İntegration
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private float _gravity = -9.81f;
    [SerializeField]
    private Transform _groundCheck;
    [SerializeField]
    private float _distance = 0.4f;
    bool _onGround;
    Vector3 velocity;
    #endregion
    #region PUBLIC_VARIABLES
    public CharacterController controller;
    public LayerMask groundMask;
    public Joystick joyStick;
    #endregion
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    void Update()
    {
        _onGround = Physics.CheckSphere(_groundCheck.position, _distance, groundMask);

        if (_onGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = joyStick.Horizontal;
        float z = joyStick.Vertical;


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * _speed * Time.deltaTime);

        velocity.y += _gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
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

