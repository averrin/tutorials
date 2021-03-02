using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

namespace InkRain {
	public class Quest : MonoBehaviour
	{

		[VerticalGroup("row1/left"), LabelWidth(70)]
		public string Title;
		[HideLabel, HorizontalGroup("row1", 20), VerticalGroup("row1/right")]
		[PreviewField(60, ObjectFieldAlignment.Right)]
		public Texture2D Icon;
		[MultiLineProperty(3)]
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public string Text;
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public bool Active = false;
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public bool Complete = false;
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public int Step = 0;
		
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public Item RewardItem;
		[VerticalGroup("row1/left"), LabelWidth(70)]
		public int RewardGold = 0;
		
		public void ApplyReward(CharacterData character) {
			character.AddCoins(RewardGold);
			if(RewardItem!=null) {
				character.AddItem(RewardItem);
			}
		}
	}
}