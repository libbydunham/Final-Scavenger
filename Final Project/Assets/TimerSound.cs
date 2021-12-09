using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSound : MonoBehaviour
{
    public float interval = 1;
    public AudioClip tick = null;
    // Start is called before the first frame update
    void Start()
    {
        if (tick !=null)
        {
            StartCoroutine(Repeat(interval));
        }
    }

   IEnumerator Repeat(float interval)
    {
        var source = GetComponent<AudioSource>();
        if (!source) { yield break; }
        source.clip = tick;
        while (this)
        {
            source.Play();
            yield return new WaitForSeconds(interval);
        }
    }
}
