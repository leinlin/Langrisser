using System;
using UnityEngine;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010D1 RID: 4305
	[Serializable]
	public class SmallExpressionParseDesc : MonoBehaviour
	{
		// Token: 0x0400BCA8 RID: 48296
		[Header("表情和文字的间隙的大小(正方形，左右间隙一致):")]
		public int m_gapBetweenEmAndText;

		// Token: 0x0400BCA9 RID: 48297
		[Header("Emoji所占位置大小(和表情自身大小无关):")]
		public int m_emSpace;

		// Token: 0x0400BCAA RID: 48298
		[Header("表情坐标在X轴的偏移:")]
		public float m_offsetX;

		// Token: 0x0400BCAB RID: 48299
		[Header("表情坐标在Y轴的偏移:")]
		public float m_offsetY;
	}
}
