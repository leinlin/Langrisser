using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013D3 RID: 5075
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BuffDesc : LuaObject
{
	// Token: 0x0601C643 RID: 116291 RVA: 0x008CBF3C File Offset: 0x008CA13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuff(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buff;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buff);
			buffDesc.SetBuff(buff);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C644 RID: 116292 RVA: 0x008CBF94 File Offset: 0x008CA194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AppendDebugText(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			buffDesc.AppendDebugText(txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C645 RID: 116293 RVA: 0x008CBFEC File Offset: 0x008CA1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTime(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			int time;
			LuaObject.checkType(l, 2, out time);
			buffDesc.SetTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C646 RID: 116294 RVA: 0x008CC044 File Offset: 0x008CA244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			buffDesc.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C647 RID: 116295 RVA: 0x008CC098 File Offset: 0x008CA298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffDesc.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C648 RID: 116296 RVA: 0x008CC0F0 File Offset: 0x008CA2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			buffDesc.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C649 RID: 116297 RVA: 0x008CC14C File Offset: 0x008CA34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffDesc.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64A RID: 116298 RVA: 0x008CC1A4 File Offset: 0x008CA3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			buffDesc.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64B RID: 116299 RVA: 0x008CC200 File Offset: 0x008CA400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffDesc.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64C RID: 116300 RVA: 0x008CC258 File Offset: 0x008CA458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			buffDesc.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64D RID: 116301 RVA: 0x008CC2B4 File Offset: 0x008CA4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffDesc.m_luaExportHelper.m_buffInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64E RID: 116302 RVA: 0x008CC30C File Offset: 0x008CA50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffInfo(IntPtr l)
	{
		int result;
		try
		{
			BuffDesc buffDesc = (BuffDesc)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
			buffDesc.m_luaExportHelper.m_buffInfo = buffInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C64F RID: 116303 RVA: 0x008CC368 File Offset: 0x008CA568
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BuffDesc");
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.SetBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.AppendDebugText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.SetTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache3);
		string name = "m_image";
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.get_m_image);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.set_m_image);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache5, true);
		string name2 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.set_m_text);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache7, true);
		string name3 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.get_m_timeText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.set_m_timeText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cache9, true);
		string name4 = "m_buffInfo";
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.get_m_buffInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuffDesc.set_m_buffInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BuffDesc.<>f__mg$cacheB, true);
		LuaObject.createTypeMetatable(l, null, typeof(BuffDesc), typeof(MonoBehaviour));
	}

	// Token: 0x0401287F RID: 75903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012880 RID: 75904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012881 RID: 75905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012882 RID: 75906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012883 RID: 75907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012884 RID: 75908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012885 RID: 75909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012886 RID: 75910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012887 RID: 75911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012888 RID: 75912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012889 RID: 75913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401288A RID: 75914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
