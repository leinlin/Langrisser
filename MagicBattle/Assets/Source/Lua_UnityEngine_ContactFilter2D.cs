using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001676 RID: 5750
[Preserve]
public class Lua_UnityEngine_ContactFilter2D : LuaObject
{
	// Token: 0x06022F8C RID: 143244 RVA: 0x00C1A6CC File Offset: 0x00C188CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D = default(ContactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F8D RID: 143245 RVA: 0x00C1A71C File Offset: 0x00C1891C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NoFilter(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			ContactFilter2D contactFilter2D2 = contactFilter2D.NoFilter();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F8E RID: 143246 RVA: 0x00C1A774 File Offset: 0x00C18974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			contactFilter2D.ClearLayerMask();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F8F RID: 143247 RVA: 0x00C1A7CC File Offset: 0x00C189CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LayerMask layerMask;
			LuaObject.checkValueType<LayerMask>(l, 2, out layerMask);
			contactFilter2D.SetLayerMask(layerMask);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F90 RID: 143248 RVA: 0x00C1A830 File Offset: 0x00C18A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			contactFilter2D.ClearDepth();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F91 RID: 143249 RVA: 0x00C1A888 File Offset: 0x00C18A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float minDepth;
			LuaObject.checkType(l, 2, out minDepth);
			float maxDepth;
			LuaObject.checkType(l, 3, out maxDepth);
			contactFilter2D.SetDepth(minDepth, maxDepth);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F92 RID: 143250 RVA: 0x00C1A8F8 File Offset: 0x00C18AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			contactFilter2D.ClearNormalAngle();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F93 RID: 143251 RVA: 0x00C1A950 File Offset: 0x00C18B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float minNormalAngle;
			LuaObject.checkType(l, 2, out minNormalAngle);
			float maxNormalAngle;
			LuaObject.checkType(l, 3, out maxNormalAngle);
			contactFilter2D.SetNormalAngle(minNormalAngle, maxNormalAngle);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, contactFilter2D);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F94 RID: 143252 RVA: 0x00C1A9C0 File Offset: 0x00C18BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFilteringTrigger(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			Collider2D collider;
			LuaObject.checkType<Collider2D>(l, 2, out collider);
			bool b = contactFilter2D.IsFilteringTrigger(collider);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F95 RID: 143253 RVA: 0x00C1AA20 File Offset: 0x00C18C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFilteringLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = contactFilter2D.IsFilteringLayerMask(obj);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F96 RID: 143254 RVA: 0x00C1AA80 File Offset: 0x00C18C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFilteringDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = contactFilter2D.IsFilteringDepth(obj);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F97 RID: 143255 RVA: 0x00C1AAE0 File Offset: 0x00C18CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFilteringNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Vector2)))
			{
				ContactFilter2D contactFilter2D;
				LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
				Vector2 normal;
				LuaObject.checkType(l, 2, out normal);
				bool b = contactFilter2D.IsFilteringNormalAngle(normal);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(float)))
			{
				ContactFilter2D contactFilter2D2;
				LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D2);
				float angle;
				LuaObject.checkType(l, 2, out angle);
				bool b2 = contactFilter2D2.IsFilteringNormalAngle(angle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsFilteringNormalAngle to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F98 RID: 143256 RVA: 0x00C1ABC8 File Offset: 0x00C18DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useTriggers(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useTriggers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F99 RID: 143257 RVA: 0x00C1AC1C File Offset: 0x00C18E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useTriggers(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useTriggers;
			LuaObject.checkType(l, 2, out useTriggers);
			contactFilter2D.useTriggers = useTriggers;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9A RID: 143258 RVA: 0x00C1AC80 File Offset: 0x00C18E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useLayerMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9B RID: 143259 RVA: 0x00C1ACD4 File Offset: 0x00C18ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useLayerMask;
			LuaObject.checkType(l, 2, out useLayerMask);
			contactFilter2D.useLayerMask = useLayerMask;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9C RID: 143260 RVA: 0x00C1AD38 File Offset: 0x00C18F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9D RID: 143261 RVA: 0x00C1AD8C File Offset: 0x00C18F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useDepth;
			LuaObject.checkType(l, 2, out useDepth);
			contactFilter2D.useDepth = useDepth;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9E RID: 143262 RVA: 0x00C1ADF0 File Offset: 0x00C18FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useOutsideDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useOutsideDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F9F RID: 143263 RVA: 0x00C1AE44 File Offset: 0x00C19044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useOutsideDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useOutsideDepth;
			LuaObject.checkType(l, 2, out useOutsideDepth);
			contactFilter2D.useOutsideDepth = useOutsideDepth;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA0 RID: 143264 RVA: 0x00C1AEA8 File Offset: 0x00C190A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useNormalAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA1 RID: 143265 RVA: 0x00C1AEFC File Offset: 0x00C190FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useNormalAngle;
			LuaObject.checkType(l, 2, out useNormalAngle);
			contactFilter2D.useNormalAngle = useNormalAngle;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA2 RID: 143266 RVA: 0x00C1AF60 File Offset: 0x00C19160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useOutsideNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.useOutsideNormalAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA3 RID: 143267 RVA: 0x00C1AFB4 File Offset: 0x00C191B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useOutsideNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			bool useOutsideNormalAngle;
			LuaObject.checkType(l, 2, out useOutsideNormalAngle);
			contactFilter2D.useOutsideNormalAngle = useOutsideNormalAngle;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA4 RID: 143268 RVA: 0x00C1B018 File Offset: 0x00C19218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.layerMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA5 RID: 143269 RVA: 0x00C1B070 File Offset: 0x00C19270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_layerMask(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LayerMask layerMask;
			LuaObject.checkValueType<LayerMask>(l, 2, out layerMask);
			contactFilter2D.layerMask = layerMask;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA6 RID: 143270 RVA: 0x00C1B0D4 File Offset: 0x00C192D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.minDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA7 RID: 143271 RVA: 0x00C1B128 File Offset: 0x00C19328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float minDepth;
			LuaObject.checkType(l, 2, out minDepth);
			contactFilter2D.minDepth = minDepth;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA8 RID: 143272 RVA: 0x00C1B18C File Offset: 0x00C1938C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.maxDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FA9 RID: 143273 RVA: 0x00C1B1E0 File Offset: 0x00C193E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxDepth(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float maxDepth;
			LuaObject.checkType(l, 2, out maxDepth);
			contactFilter2D.maxDepth = maxDepth;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAA RID: 143274 RVA: 0x00C1B244 File Offset: 0x00C19444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.minNormalAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAB RID: 143275 RVA: 0x00C1B298 File Offset: 0x00C19498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float minNormalAngle;
			LuaObject.checkType(l, 2, out minNormalAngle);
			contactFilter2D.minNormalAngle = minNormalAngle;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAC RID: 143276 RVA: 0x00C1B2FC File Offset: 0x00C194FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.maxNormalAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAD RID: 143277 RVA: 0x00C1B350 File Offset: 0x00C19550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxNormalAngle(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			float maxNormalAngle;
			LuaObject.checkType(l, 2, out maxNormalAngle);
			contactFilter2D.maxNormalAngle = maxNormalAngle;
			LuaObject.setBack(l, contactFilter2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAE RID: 143278 RVA: 0x00C1B3B4 File Offset: 0x00C195B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NormalAngleUpperLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 359.9999f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FAF RID: 143279 RVA: 0x00C1B3FC File Offset: 0x00C195FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFiltering(IntPtr l)
	{
		int result;
		try
		{
			ContactFilter2D contactFilter2D;
			LuaObject.checkValueType<ContactFilter2D>(l, 1, out contactFilter2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, contactFilter2D.isFiltering);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FB0 RID: 143280 RVA: 0x00C1B450 File Offset: 0x00C19650
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ContactFilter2D");
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.NoFilter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache0);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.ClearLayerMask);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.SetLayerMask);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache2);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.ClearDepth);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache3);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.SetDepth);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache4);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.ClearNormalAngle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache5);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.SetNormalAngle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache6);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.IsFilteringTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache7);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.IsFilteringLayerMask);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache8);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.IsFilteringDepth);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache9);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.IsFilteringNormalAngle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheA);
		string name = "useTriggers";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useTriggers);
		}
		LuaCSFunction get = Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheB;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useTriggers);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheC, true);
		string name2 = "useLayerMask";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useLayerMask);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheD;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useLayerMask);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheE, true);
		string name3 = "useDepth";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useDepth);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cacheF;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useDepth);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache10, true);
		string name4 = "useOutsideDepth";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useOutsideDepth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache11;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useOutsideDepth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache12, true);
		string name5 = "useNormalAngle";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useNormalAngle);
		}
		LuaCSFunction get5 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache13;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useNormalAngle);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache14, true);
		string name6 = "useOutsideNormalAngle";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_useOutsideNormalAngle);
		}
		LuaCSFunction get6 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache15;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_useOutsideNormalAngle);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache16, true);
		string name7 = "layerMask";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_layerMask);
		}
		LuaCSFunction get7 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache17;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_layerMask);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache18, true);
		string name8 = "minDepth";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_minDepth);
		}
		LuaCSFunction get8 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache19;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_minDepth);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1A, true);
		string name9 = "maxDepth";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_maxDepth);
		}
		LuaCSFunction get9 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1B;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_maxDepth);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1C, true);
		string name10 = "minNormalAngle";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_minNormalAngle);
		}
		LuaCSFunction get10 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1D;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_minNormalAngle);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1E, true);
		string name11 = "maxNormalAngle";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_maxNormalAngle);
		}
		LuaCSFunction get11 = Lua_UnityEngine_ContactFilter2D.<>f__mg$cache1F;
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.set_maxNormalAngle);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache20, true);
		string name12 = "NormalAngleUpperLimit";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_NormalAngleUpperLimit);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache21, null, false);
		string name13 = "isFiltering";
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.get_isFiltering);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache22, null, true);
		if (Lua_UnityEngine_ContactFilter2D.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_ContactFilter2D.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_ContactFilter2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ContactFilter2D.<>f__mg$cache23, typeof(ContactFilter2D), typeof(ValueType));
	}

	// Token: 0x04018EFE RID: 102142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018EFF RID: 102143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F00 RID: 102144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F01 RID: 102145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F02 RID: 102146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F03 RID: 102147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F04 RID: 102148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F05 RID: 102149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F06 RID: 102150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F07 RID: 102151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018F08 RID: 102152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018F09 RID: 102153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018F0A RID: 102154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018F0B RID: 102155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018F0C RID: 102156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018F0D RID: 102157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018F0E RID: 102158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018F0F RID: 102159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018F10 RID: 102160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018F11 RID: 102161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018F12 RID: 102162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018F13 RID: 102163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018F14 RID: 102164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018F15 RID: 102165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018F16 RID: 102166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018F17 RID: 102167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018F18 RID: 102168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018F19 RID: 102169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018F1A RID: 102170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018F1B RID: 102171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018F1C RID: 102172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018F1D RID: 102173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018F1E RID: 102174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018F1F RID: 102175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018F20 RID: 102176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018F21 RID: 102177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
