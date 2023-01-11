using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankS : MonoBehaviour
{
    private bool occupied = false;
    private GameObject occupant = null;
    private BoxCollider2D _collider;

    public string blanktype = "";

    void Start()
    {
        Controller.recordBlank(this.gameObject);
        _collider = this.GetComponent<BoxCollider2D>();
    }

    public bool isIn(Vector3 position)
    {
        return _collider.bounds.Contains(position);
    }

    public bool isFree()
    {
        return !occupied;
    }

    public void addOccupant(GameObject occupant)
    {
        this.occupant = occupant;

        // if a function, give a blank
        if (occupant.GetComponent<Draggable>().bricktype == "function")
        {
            occupant.GetComponent<Draggable>().addBlank();
        }

        this.occupant.transform.position = this.transform.position;
        this.occupant.transform.SetParent(this.transform);
        this.occupied = true;
    }

    public void removeOccupant()
    {
        this.occupant = null;
        this.occupied = false;
    }

    public void killOccupant()
    {
        // if occupant is a function, remove blank
        if (occupant.GetComponent<Draggable>().bricktype == "function")
        {
            Controller.removeBlank(occupant.GetComponent<Draggable>().blank);
        }

        Destroy(this.occupant);
        this.removeOccupant();
    }

    public void setLeftpanel()
    {
        // set leftpanel to the correct type
        var leftpanel = GameObject.Find("Leftpanel");
        // find panel in leftpanel that corresponds to blanktype and set it as active
        foreach (Transform child in leftpanel.transform)
        {
            if (child.name == this.blanktype +"Panel")
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    public GameObject getOccupant()
    {
        return occupant;
    }
}
