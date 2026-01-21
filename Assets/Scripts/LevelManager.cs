using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject currentLevel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelChange(GameObject level, Transform spawnPoint, GameObject player)
    {
        currentLevel.SetActive(false);
        level.SetActive(true);
        player.transform.position = spawnPoint.position;
        currentLevel = level;
    }
}
