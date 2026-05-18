using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelScroll : MonoBehaviour
{
    public GameObject [] games;

    public FadeController fade;
    private int currentIndex = 0;

    private Vector3 centerPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        centerPos = new Vector3(0,0,0);

        for(int i = 0; i < games.Length; i++)
        {
            if(i == 0)
            {
                games[i].transform.position = centerPos;
                games[i].SetActive(true);
            }
            else
            {
                games[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(ChangeScene("Game1"));
        }
    }

    IEnumerator ChangeScene(string gameName)
    {
        fade.fadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(gameName);
    }
}
