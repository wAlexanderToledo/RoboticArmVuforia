using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour {

    private Animator BrazoAnim;
    int cont = 0;

	void Start () {
        BrazoAnim = GetComponent<Animator>();
      /*  BrazoAnim["Take 001"].enabled = true;
        BrazoAnim.Sample();
        BrazoAnim["Take 002"].enabled = false;
        BrazoAnim["Take 003"].enabled = false;
        BrazoAnim["Take 004"].enabled = false;
        BrazoAnim["Take 005"].enabled = false;
        BrazoAnim["Take 006"].enabled = false;
        BrazoAnim["Take 007"].enabled = false;
        BrazoAnim["Take 008"].enabled = false;
        BrazoAnim["Take 009"].enabled = false;
        BrazoAnim["Take 010"].enabled = false;*/
    }

    // Update is called once per frame
    void Update() {
        //if()[]
        if (Input.GetButtonDown("Fire1"))
        {
            cont++;
            cont = cont % 11;
            Debug.Log(cont);
            // BrazoAnim.SetBool("anim3", true); 
            BrazoAnim.SetInteger("contador", cont);
        }  
    }

    public void reInit()
    {
        cont = 0;
    }
}
