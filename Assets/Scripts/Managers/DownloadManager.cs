
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Networking;


/// <summary>
/// A class for downloading streaming İmages from provided URLs
/// Assigne to GameObject -> "Download_Manager"
/// </summary>

public class DownloadManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    #endregion
    #region PUBLIC_VARIABLES
    public static DownloadManager Instance { get; set; }
    #endregion

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #region MONOBEHAVIOUR_METHODS
    #region PMONOBEHAVIOUR_METHODS_PUBLIC
    public void DownloadTextures(string[] URL, Action<Texture2D[]> IMG)
    {
        StartCoroutine(DTCoroutine(URL, IMG));
    }
    #endregion
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {
    }

    private IEnumerator DTCoroutine(string[] URL, Action<Texture2D[]> Images)
    {
        //define Textures 
        Texture2D[] texture = new Texture2D[URL.Length];
        //Download Texture with UnityWebRequest
        for (int i = 0; i < texture.Length; i++)
        {
            using (UnityWebRequest Req = UnityWebRequestTexture.GetTexture(URL[i]))
            {
                yield return Req.SendWebRequest();

                /*if (Req.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(Req.error);
                }*/
                if (!Req.isNetworkError)
                {
                    DownloadHandlerTexture dhs = Req.downloadHandler as DownloadHandlerTexture;
                    texture[i] = dhs.texture;
                }
            }
        }

        Images.Invoke(texture);
    }
    #endregion

    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
}

