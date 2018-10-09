using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001683 RID: 5763
[Preserve]
public class Lua_UnityEngine_CustomRenderTextureUpdateZone : LuaObject
{
	// Token: 0x06023033 RID: 143411 RVA: 0x00C1F7EC File Offset: 0x00C1D9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone = default(CustomRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023034 RID: 143412 RVA: 0x00C1F83C File Offset: 0x00C1DA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateZoneCenter(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone.updateZoneCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023035 RID: 143413 RVA: 0x00C1F890 File Offset: 0x00C1DA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateZoneCenter(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			Vector3 updateZoneCenter;
			LuaObject.checkType(l, 2, out updateZoneCenter);
			customRenderTextureUpdateZone.updateZoneCenter = updateZoneCenter;
			LuaObject.setBack(l, customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023036 RID: 143414 RVA: 0x00C1F8F4 File Offset: 0x00C1DAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateZoneSize(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone.updateZoneSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023037 RID: 143415 RVA: 0x00C1F948 File Offset: 0x00C1DB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateZoneSize(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			Vector3 updateZoneSize;
			LuaObject.checkType(l, 2, out updateZoneSize);
			customRenderTextureUpdateZone.updateZoneSize = updateZoneSize;
			LuaObject.setBack(l, customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023038 RID: 143416 RVA: 0x00C1F9AC File Offset: 0x00C1DBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023039 RID: 143417 RVA: 0x00C1FA00 File Offset: 0x00C1DC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			float rotation;
			LuaObject.checkType(l, 2, out rotation);
			customRenderTextureUpdateZone.rotation = rotation;
			LuaObject.setBack(l, customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602303A RID: 143418 RVA: 0x00C1FA64 File Offset: 0x00C1DC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_passIndex(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone.passIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602303B RID: 143419 RVA: 0x00C1FAB8 File Offset: 0x00C1DCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_passIndex(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			int passIndex;
			LuaObject.checkType(l, 2, out passIndex);
			customRenderTextureUpdateZone.passIndex = passIndex;
			LuaObject.setBack(l, customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602303C RID: 143420 RVA: 0x00C1FB1C File Offset: 0x00C1DD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_needSwap(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTextureUpdateZone.needSwap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602303D RID: 143421 RVA: 0x00C1FB70 File Offset: 0x00C1DD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_needSwap(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTextureUpdateZone customRenderTextureUpdateZone;
			LuaObject.checkValueType<CustomRenderTextureUpdateZone>(l, 1, out customRenderTextureUpdateZone);
			bool needSwap;
			LuaObject.checkType(l, 2, out needSwap);
			customRenderTextureUpdateZone.needSwap = needSwap;
			LuaObject.setBack(l, customRenderTextureUpdateZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602303E RID: 143422 RVA: 0x00C1FBD4 File Offset: 0x00C1DDD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CustomRenderTextureUpdateZone");
		string name = "updateZoneCenter";
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.get_updateZoneCenter);
		}
		LuaCSFunction get = Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache0;
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.set_updateZoneCenter);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache1, true);
		string name2 = "updateZoneSize";
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.get_updateZoneSize);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache2;
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.set_updateZoneSize);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache3, true);
		string name3 = "rotation";
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.get_rotation);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache4;
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.set_rotation);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache5, true);
		string name4 = "passIndex";
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.get_passIndex);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache6;
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.set_passIndex);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache7, true);
		string name5 = "needSwap";
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.get_needSwap);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache8;
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.set_needSwap);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cache9, true);
		if (Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CustomRenderTextureUpdateZone.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CustomRenderTextureUpdateZone.<>f__mg$cacheA, typeof(CustomRenderTextureUpdateZone), typeof(ValueType));
	}

	// Token: 0x04018F8B RID: 102283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F8C RID: 102284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F8D RID: 102285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F8E RID: 102286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F8F RID: 102287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F90 RID: 102288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F91 RID: 102289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F92 RID: 102290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F93 RID: 102291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F94 RID: 102292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018F95 RID: 102293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
