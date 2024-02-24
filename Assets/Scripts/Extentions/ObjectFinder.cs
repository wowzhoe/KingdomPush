using UnityEngine;
using System;

public class ObjectFinder : System.Object
{
	public static UnityEngine.Object Find(string name, System.Type type)
	{
		UnityEngine.Object[] objs = Resources.FindObjectsOfTypeAll(type);

		foreach (UnityEngine.Object obj in objs) {
			if (obj.name == name) {
				return obj;
			}
		}

		return null;
	}
}
