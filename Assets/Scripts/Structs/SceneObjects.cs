
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



/// <summary>
/// struct for scene objects
/// </summary>
[System.Serializable]
public struct SceneObjects
{
    public string name;
    public GameObject prefab;
    public int ID;
    public Vector3 position;
    public Vector3 scale;
    public Quaternion rotation;

    public bool Parent()
    {
        if(ID == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public SceneObjects( Transform transform, int id = -1)
    {
        if (PrefabUtility.IsPartOfRegularPrefab(transform))
        {
            prefab = PrefabUtility.GetCorrespondingObjectFromOriginalSource(transform).gameObject;
        }
        else
        {
            prefab = PrefabUtility.GetCorrespondingObjectFromSource(transform).gameObject;
        }

        ID = id;
        name = transform.name;
        position = transform.position;
        rotation = transform.rotation;
        scale = transform.localScale;

    }
}

