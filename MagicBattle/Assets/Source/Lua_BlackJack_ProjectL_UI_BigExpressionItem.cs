using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013D1 RID: 5073
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BigExpressionItem : LuaObject
{
	// Token: 0x0601C61D RID: 116253 RVA: 0x008CABBC File Offset: 0x008C8DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBigExpressionInfo bigExpressionInfo;
			LuaObject.checkType<ConfigDataBigExpressionInfo>(l, 2, out bigExpressionInfo);
			GameObject expression;
			LuaObject.checkType<GameObject>(l, 3, out expression);
			Action<int> click;
			LuaObject.checkDelegate<Action<int>>(l, 4, out click);
			BigExpressionItem o = new BigExpressionItem(bigExpressionInfo, expression, click);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C61E RID: 116254 RVA: 0x008CAC2C File Offset: 0x008C8E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			bigExpressionItem.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C61F RID: 116255 RVA: 0x008CAC80 File Offset: 0x008C8E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionItem.m_luaExportHelper.__callDele_m_onClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C620 RID: 116256 RVA: 0x008CACDC File Offset: 0x008C8EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			bigExpressionItem.m_luaExportHelper.__clearDele_m_onClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C621 RID: 116257 RVA: 0x008CAD38 File Offset: 0x008C8F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onClick(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			Action<int> action;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out action);
			if (num == 0)
			{
				bigExpressionItem.m_luaExportHelper.m_onClick = action;
			}
			else if (num == 1)
			{
				BigExpressionItem.LuaExportHelper luaExportHelper = bigExpressionItem.m_luaExportHelper;
				luaExportHelper.m_onClick = (Action<int>)Delegate.Combine(luaExportHelper.m_onClick, action);
			}
			else if (num == 2)
			{
				BigExpressionItem.LuaExportHelper luaExportHelper2 = bigExpressionItem.m_luaExportHelper;
				luaExportHelper2.m_onClick = (Action<int>)Delegate.Remove(luaExportHelper2.m_onClick, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C622 RID: 116258 RVA: 0x008CADEC File Offset: 0x008C8FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigExpressionInfo(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionItem.m_bigExpressionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C623 RID: 116259 RVA: 0x008CAE40 File Offset: 0x008C9040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigExpressionInfo(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			ConfigDataBigExpressionInfo bigExpressionInfo;
			LuaObject.checkType<ConfigDataBigExpressionInfo>(l, 2, out bigExpressionInfo);
			bigExpressionItem.m_bigExpressionInfo = bigExpressionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C624 RID: 116260 RVA: 0x008CAE98 File Offset: 0x008C9098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionItem.m_expression);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C625 RID: 116261 RVA: 0x008CAEEC File Offset: 0x008C90EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expression(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			GameObject expression;
			LuaObject.checkType<GameObject>(l, 2, out expression);
			bigExpressionItem.m_expression = expression;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C626 RID: 116262 RVA: 0x008CAF44 File Offset: 0x008C9144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_imageIcon(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bigExpressionItem.m_luaExportHelper.imageIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C627 RID: 116263 RVA: 0x008CAF9C File Offset: 0x008C919C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_imageIcon(IntPtr l)
	{
		int result;
		try
		{
			BigExpressionItem bigExpressionItem = (BigExpressionItem)LuaObject.checkSelf(l);
			Image imageIcon;
			LuaObject.checkType<Image>(l, 2, out imageIcon);
			bigExpressionItem.m_luaExportHelper.imageIcon = imageIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C628 RID: 116264 RVA: 0x008CAFF8 File Offset: 0x008C91F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BigExpressionItem");
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.__callDele_m_onClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.__clearDele_m_onClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache2);
		string name = "m_onClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.set_m_onClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache3, true);
		string name2 = "m_bigExpressionInfo";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.get_m_bigExpressionInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.set_m_bigExpressionInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache5, true);
		string name3 = "m_expression";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.get_m_expression);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.set_m_expression);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache7, true);
		string name4 = "imageIcon";
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.get_imageIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.set_imageIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BigExpressionItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BigExpressionItem.<>f__mg$cacheA, typeof(BigExpressionItem));
	}

	// Token: 0x0401285D RID: 75869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401285E RID: 75870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401285F RID: 75871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012860 RID: 75872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012861 RID: 75873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012862 RID: 75874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012863 RID: 75875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012864 RID: 75876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012865 RID: 75877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012866 RID: 75878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012867 RID: 75879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
