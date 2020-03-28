using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpriteSelector : MonoBehaviour {
	
	public GameObject 	spU, spD, spR, spL,
			spUD, spRL, spUR, spUL, spDR, spDL,
			spULD, spRUL, spDRU, spLDR, spUDRL;
	public bool up, down, left, right;
	public int type; // 0: normal, 1: enter
	public Color normalColor, enterColor;
	Color mainColor;

    public GameObject rend;
    public LevelGeneration gen;

    private Vector2 position;   
    private Vector3 rotation;

    void Start () {
        //rend = GetComponent<SpriteRenderer>();
        mainColor = normalColor;
        PickSprite();
        Instantiate(rend, transform.position, transform.rotation);
    }
	void PickSprite(){ //picks correct GameObject based on the four door bools
        if (up)
        {
            if (down)
            {
                if (right)
                {
                    if (left)
                    {
                        rend = spUDRL;
                    }
                    else
                    {
                        rend = spDRU;
                    }
                }
                else if (left)
                {
                    rend = spULD;
                }
                else
                {
                    rend = spUD;
                }
            }
            else
            {
                if (right)
                {
                    if (left)
                    {
                        rend = spRUL;
                    }
                    else
                    {
                        rend = spUR;
                    }
                }
                else if (left)
                {
                    rend = spUL;
                }
                else
                {
                    rend = spU;
                }
            }
            return;
        }
        if (down)
        {
            if (right)
            {
                if (left)
                {
                    rend = spLDR;
                }
                else
                {
                    rend = spDR;
                }
            }
            else if (left)
            {
                rend = spDL;
            }
            else
            {
                rend = spD;
            }
            return;
        }
        if (right)
        {
            if (left)
            {
                rend = spRL;
            }
            else
            {
                rend = spR;
            }
        }
        else
        {
            rend = spL;
            Debug.Log("asd");
        }
    }

}