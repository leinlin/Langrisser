using System;
using SLua;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Scene
{
	// Token: 0x020000B6 RID: 182
	[CustomLuaClass]
	public class LayerLayoutDesc : MonoBehaviour
	{
		// Token: 0x04000468 RID: 1128
		public bool Opaque;

		// Token: 0x04000469 RID: 1129
		public bool FullScreen;

		// Token: 0x0400046A RID: 1130
		public bool StayOnTop;
	}
}
