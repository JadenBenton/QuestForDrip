using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour
{
    public int sceneIndex;
    public GameObject LoadScreen;
    public Animator LoadScreenAnimation;

    public GameObject Player;

    GameObject Transporter;

    IEnumerator Wait()
    {
        //Before
        Debug.Log("Started CoRoutine");
        LoadScreen.SetActive(true);
        LoadScreenAnimation.SetBool("LoadLevel", true);
        yield return new WaitForSeconds(3);
        //After
        SceneManager.LoadScene(sceneIndex);
    }

    private void Start()
    {
        LoadScreen.SetActive(false);
        LoadScreenAnimation.SetBool("LoadLevel", false);
    }

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
