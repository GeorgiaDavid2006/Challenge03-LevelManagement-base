using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentLevel;

    public GameObject level1;
    public GameObject level2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelChange()
    {
        level1.SetActive(false);
        level2.SetActive(true);
    }
}
