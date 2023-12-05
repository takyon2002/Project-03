using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider))]
public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("General Stats")]
    [SerializeField]
    private string _name;
    [SerializeField]
    private CollectibleType _type = CollectibleType.None;
    [SerializeField]
    [Range(0f, 100f)]
    private float _chanceToDropObjet;
    [SerializeField]
    private GameObject _artToDisable;

    private Collider _collider;
    [SerializeField]
    private float _collectibleDuration;

    [SerializeField] private int _damageToDeal;
    [SerializeField] private GameObject _objectToDrop;

    void Awake()
    {
        _collider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement _playerObject = other.gameObject.GetComponent<PlayerMovement>();
        if(_playerObject != null)
        {
            //sequence

            StartCoroutine(CollectibleSequence(_playerObject));
            
        }


    }

    public IEnumerator CollectibleSequence(PlayerMovement playerMovement)
    {
        _collider.enabled = false;
        _artToDisable.SetActive(false);
        yield return new WaitForSeconds(_collectibleDuration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
