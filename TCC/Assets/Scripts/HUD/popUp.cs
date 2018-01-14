using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popUp : MonoBehaviour {

    public GameObject popUpPause;
    public GameObject popUpHome;
    public GameObject popUpGameOver;
    public AudioSource button;
    public string fase;
    //public Player player;

    // Use this for initialization
    void Start() {
        popUpPause.SetActive(false);
        popUpGameOver.SetActive(false);
        popUpHome.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        /*if (player.isDead == true)
        {
            popUpGameOver.SetActive(true);
            Time.timeScale = 0;
        }*/
    }

    public void pauseGame()
    {
        popUpPause.SetActive(true);
        button.Play();
        Time.timeScale = 0;
    }

    public void continueGame(){
        button.Play();
        Time.timeScale = 1;
        popUpPause.SetActive(false);
    }

    public void homeGame()
    {
        popUpHome.SetActive(true);
        button.Play();
    }

    public void confirmGame()
    {
        button.Play();
        StartCoroutine("menuGame");
    }

    public void restartGame()
    {
        button.Play();
        StartCoroutine("restart");
    }

    public void denyGame()
    {
        button.Play();
        popUpHome.SetActive(false);
    }

    IEnumerator menuGame()
    {
        Time.timeScale = 1;
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/Menu/Menu");
    }

    IEnumerator restart()
    {
        Time.timeScale = 1;
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Official/" + fase);
    }
}
