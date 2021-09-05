
/// ----ToofanTahmoures---2021-----
/// This is a template Script for MonoBehaviors Scripts suggested for editing
/// Please check out the naming convention Manuals Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Editable version Here: https://docs.google.com/document/d/1vzuU7_5R87vpJurMWJ-YK_bC2hhZVlmN/edit?usp=sharing&ouid=106315773441854825686&rtpof=true&sd=true
/// Please duplicate the scripts ligns bellow in the "TemplatesScriptsMonoBehaviour.c" or script and leave it empty, you can duplicate this into a script newly made by you in the editor, 
/// or set up this template as a default unity emplate Script each time you generate a new empty script with replacing this file: https://1drv.ms/t/s!AgDnFacvwTrJgaQ2RrAA6EKnFilrAA?e=TJsnDj :)



using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


/// <summary>
/// Please mention your classe use or introduction here (this is  a template class for demo)
/// </summary>

public class SpawnManager : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    [SerializeField]
    private GameObject _playerPrefab;
    [SerializeField]
    private Transform _spawnLocation;
    [SerializeField]
    private Transform _camera;
    private Transform player;
    #endregion
    #region PUBLIC_VARIABLES
    public static SpawnManager Instance { get; set; }

    #endregion
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        AssetDatas data = AssetController.Instance.data();
        SpawnAssets(data);
    }
    #region MONOBEHAVIOUR_METHODS
    #region MONOBEHAVIOUR_METHODS_PRIVATE
    //Example Method and comment
    private void Update()
    {
    }
    #endregion
    #region PMONOBEHAVIOUR_METHODS_PUBLIC

    public void SpawnAssets(AssetDatas data)
    {
        for (int i = 0; i < data.data.positions.Count; i++)
        {
            string assetName = data.data.positions[i].prefab;
            Vector3 pos = data.data.positions[i].position;
            Quaternion rot = data.data.positions[i].rotation;
            GameObject prefab = data.assetBundle.LoadAsset<GameObject>(assetName).gameObject;

            Transform transform = Instantiate(prefab, pos, rot).transform;
        }
    }

    public void SpawnPlayer()
    {


        _camera.gameObject.SetActive(false);
        _playerPrefab.gameObject.SetActive(true);
        
    }

    public void PerspectiveView()
    {
        _playerPrefab.SetActive(false);
        _camera.gameObject.SetActive(true);
        
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

