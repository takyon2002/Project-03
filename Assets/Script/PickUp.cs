using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("General Stats")]
    [SerializeField]
    private string _name;
    [SerializeField]
    [Range(0f, 100f)]
    private float _chanceToDropObjet;
    
    [SerializeField] private GameObject _playerObjectToCollide;

    [SerializeField] private int _damageToDeal;
    [SerializeField] private GameObject _objectToDrop;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
