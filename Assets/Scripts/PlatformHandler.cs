using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandler : MonoBehaviour
{
    [SerializeField] private PlatformEffector2D effector;
    [SerializeField] private new bool collider;


    private void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }


    private void Update()
    {
        if (collider && Input.GetKeyDown(KeyCode.S) || collider && Input.GetKeyDown(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 180f;
            effector.surfaceArc = 210f;
            StartCoroutine(Wait());
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           collider = true;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           collider = false;
        }
    }


    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.25f);
        effector.rotationalOffset = 0f;
        effector.surfaceArc = 150f;
    }
}
