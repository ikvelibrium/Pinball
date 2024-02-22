using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] List<Transform> _bonusesSpawnPoints = new List<Transform>();
    [SerializeField] List<int> _spawnedBonuses = new List<int>();
    [SerializeField] List<GameObject> _prefs = new List<GameObject>();
    [SerializeField] private float bonusSpawnInSecMin;
    [SerializeField] private float bonusSpawnInSecMax;
    Dictionary<string, object> aaa = new Dictionary<string, object>();
    private float _actualBonusSpawnInSec;
    private bool _spawendFirstOne = false;


    


    private void Start()
    {
        aaa.Add("a",1);
        aaa.Add("b",2);
        aaa.Add("c",3);
        _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
        Debug.Log(_actualBonusSpawnInSec);

        
        
    }

    private void Update()
    {
        _actualBonusSpawnInSec -= Time.deltaTime;
        if (_actualBonusSpawnInSec <= 0)
        {
            
            int a = Random.Range(0, _bonusesSpawnPoints.Count);
            if (_spawendFirstOne == false)
            {
                
                Instantiate(_prefs[Random.Range(0, _prefs.Count)], _bonusesSpawnPoints[a]);
                _spawnedBonuses.Add(a);
                _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
                _spawendFirstOne = true;
            } else
            {
                for (int i = 0; i < _spawnedBonuses.Count; i++)
                {
                    if (a != _spawnedBonuses[i])
                    { 
                        Instantiate(_prefs[Random.Range(0, _prefs.Count)], _bonusesSpawnPoints[a]);
                        _spawnedBonuses.Add(a);
                        _actualBonusSpawnInSec = Random.Range(bonusSpawnInSecMin, bonusSpawnInSecMax);
                        AppMetrica.Instance.ReportEvent("a",aaa);
                    }
                }
            }
            
        }
       
    }
}
