using System.Collections;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;
    [SerializeField]
    private  Vector3 _spawnPosition;
    [SerializeField]
    private ConfigUnit _configUnit;
    private WaitForSeconds _waitForTimeBetweenCreations = new(7);
    
    private void Start()
    {
        StartCoroutine(Creater());
    }

    private IEnumerator Creater()
    {
        int iterator = 0;
        while(true)
        {
            Instantiate(_playerPrefab, _spawnPosition, Quaternion.identity);
            iterator++;
            yield return _waitForTimeBetweenCreations;
        }
    }
}


