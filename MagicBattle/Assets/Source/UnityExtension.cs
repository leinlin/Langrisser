using System;
using System.Collections;
using UnityEngine;

namespace SLua
{
	// Token: 0x02000004 RID: 4
	public static class UnityExtension
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00009534 File Offset: 0x00007734
		public static void StartCoroutine(this MonoBehaviour mb, LuaFunction func)
		{
			mb.StartCoroutine(UnityExtension.LuaCoroutine(func));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00009544 File Offset: 0x00007744
		internal static IEnumerator LuaCoroutine(LuaFunction func)
		{
			LuaThreadWrapper thread = new LuaThreadWrapper(func);
			object obj;
			while (thread.Resume(out obj))
			{
				yield return obj;
			}
			yield break;
			yield break;
		}
	}
}
