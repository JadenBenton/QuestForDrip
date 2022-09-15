using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator animator;
    public void PlayGame() {

        IEnumerator Wait() {
            animator.SetBool("LoadLevel", true);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(1);
        }
        StartCoroutine(Wait());
    }
    public void QuitGame() { 
        Application.Quit();
    }
}
