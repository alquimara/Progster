﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject pieceDragging;
    Vector3 startPosition;
	Transform startParent;
    Transform DragParent;
  
  private void Start() 
    {
        DragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       
        pieceDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(DragParent);
        Debug.Log(pieceDragging);

    }

    public void OnDrag(PointerEventData eventData)
    {
        
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
        pieceDragging = null;
        if(transform.parent == DragParent){
            transform.position = startPosition;
            transform.SetParent(startParent);

        }

    }
    



    private void Update()
    {

    }
}