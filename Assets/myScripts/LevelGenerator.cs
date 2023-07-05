using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    
    [SerializeField] private Transform basamakStart;
    [SerializeField] private List<Transform> basamaklar;
    private Vector3 lastEndPosition;
    
    private void Awake()
    {
        Transform chosenLevelPart = basamaklar[Random.Range(0, basamaklar.Count)];
        Transform lastlevelTransform;
        lastlevelTransform = spawnLevelPart(chosenLevelPart,new Vector3(-45,1));
        
        for (int i = 0; i < 5; i++)
        {
            chosenLevelPart = basamaklar[Random.Range(0, basamaklar.Count)];
            lastlevelTransform = spawnLevelPart(chosenLevelPart,new Vector3(lastlevelTransform.position.x + 30, lastlevelTransform.position.y));
        }

    }
  

    private Transform spawnLevelPart(Transform _basamaklar,Vector3 spawnPosition)
    {
        
        Transform levetpartTransform = Instantiate(_basamaklar, spawnPosition, Quaternion.identity);
        return levetpartTransform;  
    }
}
