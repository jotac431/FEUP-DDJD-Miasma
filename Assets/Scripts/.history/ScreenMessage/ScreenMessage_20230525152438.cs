using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMessage : MonoBehaviour
{

    private UnityEvent startEvents;
    private UnityEvent endEvents;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(RunEvents());
        }
    }

    IEnumerator RunEvents()
    {
        startEvents.Invoke();
        yield return new WaitForSeconds(5);
        endEvents.Invoke();
    }
}