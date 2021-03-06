/*
 * Chris Smith
 * PlayerController
 * Assignment 8
 * A script for managing player inputs.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool linux;
    public Text controls;
    public Text output;
    public Desktop selected;

    PC pc = new PC();
    MAC mac = new MAC();

    private void Start()
    {
        selected = pc;
    }

    // Update is called once per frame
    void Update()
    {
        controls.text = "Press 1 to see how a PC is built.\nPress 2 to see how a Mac is built.\nLikes Linux? " + linux;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selected = pc;
            linux = selected.LikesLinux();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selected = mac;
            linux = selected.LikesLinux();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            linux = !linux;
        }

        if (selected == pc || selected == mac)
        {
            output.text = selected.BuildComputer();
            if (linux)
            {
                output.text += "Installing a virtual machine to run Linux\n";
            }
        }
    }
}
