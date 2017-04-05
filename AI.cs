using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class AI : MonoBehaviour {

    public float speed;

    public Actions state;
   
	// Use this for initialization
	void Start () {
        state = Actions.patrolHall;

    }
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case Actions.patrolHall: patrolHall() ;
                break;
            default: break;
            case Actions.patrolLivingroom:
                patrolLivingroom();
                break;
            case Actions.patrolKitchen:
                patrolKitchen();
                break;
            case Actions.patrolLaundryRoom:
                patrolLaundryRoom();
                break;
            case Actions.patrolBedroom:
                patrolBedroom();
                break;
            case Actions.patrolBedroom2:
                patrolBedroom2();
                break;
            case Actions.patrolMasterBedroom:
                patrolMasterBedroom();
                break;

        }

        /*     patrolling();
             kitchen();
             livingroom();
             laundryroom();
             bedroom();
             bedroom();
             masterbedroom();

             patrolHall,
        patrolLivingroom,
        patrolKitchen,
        patrolLaundryRoom,
        patrolBedroom,
        patrolBedroom2,
        patrolMasterBedroom,*/

    }

    public List<Vector3> hall = new List<Vector3>();
    public List<Vector3> kitchen = new List<Vector3>();
    public List<Vector3> livingroom = new List<Vector3>();
    public List<Vector3> laundryroom = new List<Vector3>();
    public List<Vector3> bedroom = new List<Vector3>();
    public List<Vector3> bedroom2 = new List<Vector3>();
    public List<Vector3> masterbedroom = new List<Vector3>();

    public Vector3 outsidelivingroom;
    public Vector3 outsidekitchen;
    public Vector3 outsidelaundryroom;
    public Vector3 outsidebedroom;
    public Vector3 outsidebedroom2;
    public Vector3 outsidemasterbedroom;
    public Vector3 endofhallway;

    int index = 0;

    void patrolHall()
    {

        transform.position = Vector3.MoveTowards(transform.position, hall[index], speed);

        if (transform.position == hall[index])
        {
            index++;
            if (hall[index - 1] == outsidelivingroom)
            {
               
                state = Actions.patrolLivingroom;
              
            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= hall.Count){
            index = 0;
        }

    }
    void patrolKitchen()

    {

        transform.position = Vector3.MoveTowards(transform.position, kitchen[index], speed);

        if (transform.position == kitchen[index])
        {
            index++;
            if (kitchen[index - 1] == outsidelaundryroom)
            {

                state = Actions.patrolLaundryRoom;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= kitchen.Count)
        {
            index = 0;
        }

    }
    void patrolLivingroom()
    {

        transform.position = Vector3.MoveTowards(transform.position, livingroom[index], speed);

        if (transform.position == livingroom[index])
        {
            index++;
            if (livingroom[index - 1] == outsidekitchen)
            {

                state = Actions.patrolKitchen;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= livingroom.Count)
        {
            index = 0;
        }

    }
    void patrolLaundryRoom()
    {

        transform.position = Vector3.MoveTowards(transform.position, laundryroom[index], speed);

        if (transform.position == laundryroom[index])
        {
            index++;
            if (laundryroom[index - 1] == outsidebedroom)
            {

                state = Actions.patrolBedroom;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= laundryroom.Count)
        {
            index = 0;
        }

    }

    void patrolBedroom()
    {

        transform.position = Vector3.MoveTowards(transform.position, bedroom[index], speed);

        if (transform.position == bedroom[index])
        {
            index++;
            if (bedroom[index - 1] == outsidebedroom2)
            {

                state = Actions.patrolBedroom2;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= bedroom.Count)
        {
            index = 0;
        }

    }
    void patrolBedroom2()
    {

        transform.position = Vector3.MoveTowards(transform.position, bedroom2[index], speed);

        if (transform.position == bedroom2[index])
        {
            index++;
            if (bedroom2[index - 1] == outsidemasterbedroom)
            {

                state = Actions.patrolMasterBedroom;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= bedroom2.Count)
        {
            index = 0;
        }

    }

    void patrolMasterBedroom()
    {

        transform.position = Vector3.MoveTowards(transform.position, masterbedroom[index], speed);

        if (transform.position == masterbedroom[index])
        {
            index++;
            if (masterbedroom[index - 1] == endofhallway)
            {

                state = Actions.patrolHall;

            }
        }

        // If run through all the positions of that list it resets the patrol index
        if (index >= masterbedroom.Count)
        {
            index = 0;
        }

    }
}
    public enum Actions
    {
        patrolHall,
        patrolLivingroom,
        patrolKitchen,
        patrolLaundryRoom,
        patrolBedroom,
        patrolBedroom2,
        patrolMasterBedroom,

    }
