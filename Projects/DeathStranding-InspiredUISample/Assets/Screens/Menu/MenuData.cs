using UnityEngine;
using System.Collections.Generic;
using System;

namespace PanelSettings.DeathStranding {

	[ CreateAssetMenu( menuName = "PanelSettings/Death Stranding/Menu Data" ) ]
	public class MenuData : ScriptableObject
	{
		[Serializable]
		public struct MenuItem {
			public string name;
			public Texture2D icon;
		}

		public List< MenuItem > menuItems;
	}

}
