using System;
using UnityEngine;

namespace Almond {
	/// <summary>
	/// Custom Fields
	/// 
	/// Thema : Write custom thema names
	/// ThemaColorType : Color types in each thema
	/// ThemaColors : Colos in each thema
	/// </summary>

	public enum Thema {
		CityScape,
		Futurism,
		PurplePalm,
		RadiumBloom,
		Blacklight,
		Sunset80s,
		GlacierLake,

		Max,
	}
	public enum ThemaColorType {
		Main1,
		Main2,
		Main3,
		Main4,
		Main5,

		Light,
		Dark,

		SelectedUI,
		DisabledUI,
		Max
	}

	[Serializable]
	public class ThemaColors {
		public Thema thema;
		[SerializeField] private Color[] colors = new Color[(int)ThemaColorType.Max];
		public Color GetColor(ThemaColorType colorType) {
			var index = (int)colorType;
			if(index >= colors.Length) {
				Debug.LogWarning("index out of range :: Check color table");
				return Color.black;
			}
			return colors[index];
		}
	}
}