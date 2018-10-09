using System;
using UnityEngine;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x02001085 RID: 4229
	[Serializable]
	public class EmojiParseDesc : MonoBehaviour
	{
		// Token: 0x0400BA86 RID: 47750
		[Header("表情的大小(正方形，x,y大小一致):")]
		public Vector2 m_emojiSize;

		// Token: 0x0400BA87 RID: 47751
		[Header("Emoji所占位置大小(和表情自身大小无关):")]
		public int m_emSpace;

		// Token: 0x0400BA88 RID: 47752
		[Header("表情坐标在X轴的偏移:")]
		public float m_offsetX;

		// Token: 0x0400BA89 RID: 47753
		[Header("表情坐标在Y轴的偏移:")]
		public float m_offsetY;
	}
}
