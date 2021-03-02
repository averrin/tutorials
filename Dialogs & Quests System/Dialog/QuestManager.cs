using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Linq;

namespace InkRain {
	public class QuestManager : MonoBehaviour
	{
		public List<Quest> Quests => GetComponentsInChildren<Quest>().ToList().Where((q) => q.Active).ToList();
	}
}
