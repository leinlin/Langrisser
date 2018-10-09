using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200157B RID: 5499
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SkillDesc : LuaObject
{
	// Token: 0x06021133 RID: 135475 RVA: 0x00B1FEA8 File Offset: 0x00B1E0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkill(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skill);
			skillDesc.SetSkill(skill);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021134 RID: 135476 RVA: 0x00B1FF00 File Offset: 0x00B1E100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			skillDesc.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021135 RID: 135477 RVA: 0x00B1FF54 File Offset: 0x00B1E154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021136 RID: 135478 RVA: 0x00B1FFAC File Offset: 0x00B1E1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			skillDesc.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021137 RID: 135479 RVA: 0x00B20008 File Offset: 0x00B1E208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_title(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021138 RID: 135480 RVA: 0x00B20060 File Offset: 0x00B1E260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_title(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Text title;
			LuaObject.checkType<Text>(l, 2, out title);
			skillDesc.m_luaExportHelper.m_title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021139 RID: 135481 RVA: 0x00B200BC File Offset: 0x00B1E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_desc(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113A RID: 135482 RVA: 0x00B20114 File Offset: 0x00B1E314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_desc(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Text desc;
			LuaObject.checkType<Text>(l, 2, out desc);
			skillDesc.m_luaExportHelper.m_desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113B RID: 135483 RVA: 0x00B20170 File Offset: 0x00B1E370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cd(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_cd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113C RID: 135484 RVA: 0x00B201C8 File Offset: 0x00B1E3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cd(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Text cd;
			LuaObject.checkType<Text>(l, 2, out cd);
			skillDesc.m_luaExportHelper.m_cd = cd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113D RID: 135485 RVA: 0x00B20224 File Offset: 0x00B1E424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_range(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_range);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113E RID: 135486 RVA: 0x00B2027C File Offset: 0x00B1E47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_range(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Text range;
			LuaObject.checkType<Text>(l, 2, out range);
			skillDesc.m_luaExportHelper.m_range = range;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602113F RID: 135487 RVA: 0x00B202D8 File Offset: 0x00B1E4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_distance(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDesc.m_luaExportHelper.m_distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021140 RID: 135488 RVA: 0x00B20330 File Offset: 0x00B1E530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_distance(IntPtr l)
	{
		int result;
		try
		{
			SkillDesc skillDesc = (SkillDesc)LuaObject.checkSelf(l);
			Text distance;
			LuaObject.checkType<Text>(l, 2, out distance);
			skillDesc.m_luaExportHelper.m_distance = distance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021141 RID: 135489 RVA: 0x00B2038C File Offset: 0x00B1E58C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SkillDesc");
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.SetSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache1);
		string name = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_icon);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_icon);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache3, true);
		string name2 = "m_title";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_title);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_title);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache5, true);
		string name3 = "m_desc";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_desc);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_desc);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache7, true);
		string name4 = "m_cd";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_cd);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_cd);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cache9, true);
		string name5 = "m_range";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_range);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_range);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheB, true);
		string name6 = "m_distance";
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.get_m_distance);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDesc.set_m_distance);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SkillDesc.<>f__mg$cacheD, true);
		LuaObject.createTypeMetatable(l, null, typeof(SkillDesc), typeof(MonoBehaviour));
	}

	// Token: 0x0401701F RID: 94239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017020 RID: 94240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017021 RID: 94241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017022 RID: 94242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017023 RID: 94243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017024 RID: 94244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017025 RID: 94245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017026 RID: 94246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017027 RID: 94247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017028 RID: 94248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017029 RID: 94249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401702A RID: 94250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401702B RID: 94251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401702C RID: 94252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
