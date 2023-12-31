using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class LevelLoader : MonoBehaviour
    {
        public Animator transition;

        public float transitionTime = 1f;

        public int sceneNum;

        private void Start()
        {
            LoadNextLevel();
        }

        public void LoadNextLevel()
        {
            Time.timeScale = 1;
            //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
            StartCoroutine(LoadLevel(sceneNum));
        }

        IEnumerator LoadLevel(int levelIndex)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(levelIndex);
        }

    }
}