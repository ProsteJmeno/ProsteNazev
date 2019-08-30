using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Nove_Ui.Scripts
{
    public class LevelSelect : MonoBehaviour
    {
        public static int CurrentLevel;
        
        [Header("References")]
        [SerializeField] private GridLayoutGroup grid;
        [SerializeField] private LevelButton buttonPrefab;

        [Header("Parameters")]
        [SerializeField] private int totalLevels;
        [SerializeField] private int unlockedLevels;

        private void Awake()
        {
            // Remove all previous buttons from the grid
            foreach (Transform child in grid.transform)
            {
                Destroy(child.gameObject);
            }
            
            for (var i = 0; i < totalLevels; i++)
            {
                var instance = Instantiate(buttonPrefab, grid.transform);

                var levelId = i + 1;
                instance.Label = levelId.ToString();
                instance.Unlocked = i < unlockedLevels;
                
                // Need to cache the current value
                var i1 = i;
                instance.OnButtonClicked += () =>
                {
                    CurrentLevel = i1;
                    SceneManager.LoadScene($"easy-lvl-{levelId}");
                };
            }
        }
    }
}