using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelAndExperience : MonoBehaviour
{
    [SerializeField] private float _maximumLV;
    [SerializeField] private float _minimumExperience;
    private float _currentLevel;
    private float _currentExperience;
    [SerializeField] private float _increaseToExperience;
    [SerializeField] private float _currentThreshold;
    [SerializeField] private float _increaseToThreshhold;
    // Start is called before the first frame update
    private void Awake()
    {
        _currentExperience = 0;
        _currentLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            _currentExperience = _currentExperience + _increaseToExperience;
            Debug.Log("Current Level is:" + _currentLevel);
            Debug.Log("experience: " + _currentExperience);
        }
        if(_currentExperience >= _currentThreshold)
        {
            _currentLevel++;
            _currentThreshold = _currentThreshold + _increaseToThreshhold;
        }
        if(_currentLevel== _maximumLV)
        {
            _increaseToExperience = 0;
        }
       

    }
}
