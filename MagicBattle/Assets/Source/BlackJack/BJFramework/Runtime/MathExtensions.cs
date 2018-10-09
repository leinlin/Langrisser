using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x02000123 RID: 291
	public static class MathExtensions
	{
		// Token: 0x06000BF4 RID: 3060 RVA: 0x000331C4 File Offset: 0x000313C4
		public static bool AlmostEquals(this Vector3 target, Vector3 second, float sqrMagnitudePrecision)
		{
			return (target - second).sqrMagnitude < sqrMagnitudePrecision;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000331E4 File Offset: 0x000313E4
		public static bool AlmostEquals(this Vector2 target, Vector2 second, float sqrMagnitudePrecision)
		{
			return (target - second).sqrMagnitude < sqrMagnitudePrecision;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00033204 File Offset: 0x00031404
		public static bool AlmostEquals(this Quaternion target, Quaternion second, float maxAngle)
		{
			return Quaternion.Angle(target, second) < maxAngle;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00033210 File Offset: 0x00031410
		public static bool AlmostEquals(this float target, float second, float floatDiff)
		{
			return Mathf.Abs(target - second) < floatDiff;
		}
	}
}
