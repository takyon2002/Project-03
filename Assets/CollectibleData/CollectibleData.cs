using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectibleData_",menuName = "Unitdata/CollectibleData")]
public class CollectibleData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField]
    private string _name ;
    [SerializeField]
    private CollectibleType _type = CollectibleType.None;
    [SerializeField]
    [Range(0f, 100f)]
    private float _chanceToDropObjet= 20;

    [SeperatorAttibute(2, 20)]

    

    [SerializeField] private int _damageToDeal;
    [SerializeField] private GameObject _objectToDrop;
}
