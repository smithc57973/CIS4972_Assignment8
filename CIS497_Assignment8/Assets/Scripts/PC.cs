/*
 * Chris Smith
 * PC
 * Assignment 8
 * A class defining PC Desktops.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : Desktop
{
    public override string AddCPU()
    {
        return "Installing Ryzen 9 5950x\n";
    }

    public override string AddGPU()
    {
        return "Installing Asus RTX 3090 Strix\n";
    }

    public override string AddMobo()
    {
        return "Installing the cheapest motherboard because you ran out of money\n";
    }

    public override string AddOS()
    {
        return "Booting into Windows\n";
    }

}
