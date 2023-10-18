using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] List<Transform> _bonusesSpawnPoints = new List<Transform>();
    [SerializeField] List<int> _spawnedBonuses = new List<int>();
    [SerializeField] private GameObject _smallBonusPref;  
    [SerializeField] private float bonusSpawnInSecMin;
    [SerializeField] private float bonusSpawnInSecMax;
    private float _actualBonusSpawnInSec;
    private bool _spawendFirstOne = false;
    private void Start()
    {
        _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
        Debug.Log(_actualBonusSpawnInSec);
    }

    private void Update()
    {
        _actualBonusSpawnInSec -= Time.deltaTime;
        if (_actualBonusSpawnInSec <= 0)
        {
            int a = Random.Range(0, _bonusesSpawnPoints.Count);
            if (_spawendFirstOne)
            {
               
                Instantiate(_smallBonusPref, _bonusesSpawnPoints[a]);
                _spawnedBonuses.Add(a);
                _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
            } else
            {
                for (int i = 0; i < _spawnedBonuses.Count; i++)
                {
                    if (a != _spawnedBonuses[i])
                    { 
                        Instantiate(_smallBonusPref, _bonusesSpawnPoints[a]);
                        _spawnedBonuses.Add(a);
                        _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
                    }
                }
            }
            
        }
       
    }
}
