using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    public AudioSource song1;
    public AudioSource song2;
    public AudioSource song3;
    public AudioSource staticRadio;
    public GameEvent SongEv1, SongEv2, SongEv3, SongOff;
    public GameEvent carShowsUpEvent;
    int songIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.R))
         
{       carShowsUpEvent.Fire();    
        switch (songIndex)
    {
        case 0:
            songIndex=1;
            SongEv1.Fire();
            staticRadio.Play();
            song1.Play();
            break;
        case 1:
           songIndex=2;
            staticRadio.Play();
            SongEv2.Fire();
            song1.Stop();
            song2.Play();
            break;
        case 2:
            songIndex=3;
            staticRadio.Play();
            SongEv3.Fire();
            song2.Stop();
            song3.Play();
            break;
        case 3:
            songIndex=0;
            SongOff.Fire();
            staticRadio.Play();
            song3.Stop();
            break;
        default:
            break;
    }

}

    }
}
