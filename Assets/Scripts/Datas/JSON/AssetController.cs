
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
/// load and control datas in the scene 
/// attached to the GameObject -> "Asset_Controller"
/// </summary>

public class AssetController : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    [SerializeField]
    private AssetDatas _assetData;
    #endregion
    #region PUBLIC_VARIABLES
    public static AssetController Instance { get; set; }
    #endregion
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }



        _assetData.parsFromJson("json-for-test.json");
        _assetData.LoadFiles("testbundle");
    }
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment

    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC

    public AssetDatas data()
    {
        return _assetData;
    }
    /*public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            
            NewNewJsonTutorial("json-for-test.json");
        }
    }


    public void GetDataFromJSON(string jsonName)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, jsonName);

        Debug.Log(filePath);
        string jsonData = File.ReadAllText(filePath);
        Debug.Log(jsonData);
        //string jsonString = "";
        data = JsonUtility.FromJson<JsonData>(jsonData);
        foreach (string urlInList in data.URL)
        {
            Debug.Log("URL: " + urlInList);
        }

    }*/

    #endregion
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS
    #region NON_MONOBEHAVIOUR_METHODS_PRIVATE
    #endregion
    #region NON_MONOBEHAVIOUR_METHODS_PUBLIC
    #endregion
    #endregion
}

