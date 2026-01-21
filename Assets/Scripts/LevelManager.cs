using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentLevel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelChange(GameObject level, Transform spawnPoint)
    {
        currentLevel.SetActive(false);
        level.SetActive(true);
    }
}
