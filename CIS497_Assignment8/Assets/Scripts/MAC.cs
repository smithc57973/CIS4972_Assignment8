/*
 * Chris Smith
 * MAC
 * Assignment 8
 * A class defining MAC Desktops.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAC : Desktop
{
    public override string AddCPU()
    {
        return "Installing generic Intel i5\n";
    }

    public override string AddGPU()
    {
        return "Using CPU graphics\n";
    }

    public override string AddMobo()
    {
        return "It definitely has a motherboard\n";
    }

    public override string AddOS()
    {
        return "Booting into MacOS\n";
    }

    public override bool LikesLinux()
    {
        return false;
    }
}
