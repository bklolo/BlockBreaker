using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] AudioClip loseSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(loseSound, Camera.main.transform.position);
        SceneManager.LoadScene("Game Over");
    }
}
