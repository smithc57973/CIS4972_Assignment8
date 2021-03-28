using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class Desktop : MonoBehaviour
{
    public string BuildComputer()
	{
		StringBuilder sb = new StringBuilder();

		sb.Append(AddCPU());
		sb.Append(AddMobo());
		sb.Append(AddGPU());
		sb.Append(AddOS());
        /*if (LikesLinux())
        {
			sb.Append("Installing a virtual machine to run Linux\n");
        }*/
		return sb.ToString();
	}

	public abstract string AddCPU();
	public abstract string AddMobo();
	public abstract string AddGPU();
	public virtual string AddOS()
    {
		return "Booting into Linux\n";
    }

	public virtual bool LikesLinux()
    {
		return true;
    }
}
