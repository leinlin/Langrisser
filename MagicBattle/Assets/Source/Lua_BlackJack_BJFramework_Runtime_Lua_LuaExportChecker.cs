using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200110B RID: 4363
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker : LuaObject
{
	// Token: 0x06015B31 RID: 88881 RVA: 0x00594428 File Offset: 0x00592628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker o = new LuaExportChecker();
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

	// Token: 0x06015B32 RID: 88882 RVA: 0x00594470 File Offset: 0x00592670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PublicMethod(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.PublicMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B33 RID: 88883 RVA: 0x005944BC File Offset: 0x005926BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReturnAction(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action o = luaExportChecker.ReturnAction();
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

	// Token: 0x06015B34 RID: 88884 RVA: 0x00594510 File Offset: 0x00592710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PublicStaticMethod_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.PublicStaticMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B35 RID: 88885 RVA: 0x00594550 File Offset: 0x00592750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ProtectedMethod(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.ProtectedMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B36 RID: 88886 RVA: 0x005945A4 File Offset: 0x005927A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrivateMethod(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.PrivateMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B37 RID: 88887 RVA: 0x005945F8 File Offset: 0x005927F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_PublicEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__callDele_PublicEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B38 RID: 88888 RVA: 0x0059464C File Offset: 0x0059284C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_PublicEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__clearDele_PublicEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B39 RID: 88889 RVA: 0x005946A0 File Offset: 0x005928A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_ProtectedEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__callDele_ProtectedEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3A RID: 88890 RVA: 0x005946F4 File Offset: 0x005928F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ProtectedEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__clearDele_ProtectedEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3B RID: 88891 RVA: 0x00594748 File Offset: 0x00592948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_PrivateEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__callDele_PrivateEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3C RID: 88892 RVA: 0x0059479C File Offset: 0x0059299C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_PrivateEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__clearDele_PrivateEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3D RID: 88893 RVA: 0x005947F0 File Offset: 0x005929F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_ReturnIntEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int a;
			LuaObject.checkType(l, 2, out a);
			int i = luaExportChecker.m_luaExportHelper.__callDele_ReturnIntEvent(a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3E RID: 88894 RVA: 0x00594858 File Offset: 0x00592A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ReturnIntEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int a;
			LuaObject.checkType(l, 2, out a);
			luaExportChecker.m_luaExportHelper.__clearDele_ReturnIntEvent(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B3F RID: 88895 RVA: 0x005948B4 File Offset: 0x00592AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_protectedDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__callDele_m_protectedDelegate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B40 RID: 88896 RVA: 0x00594908 File Offset: 0x00592B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_m_protectedDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__clearDele_m_protectedDelegate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B41 RID: 88897 RVA: 0x0059495C File Offset: 0x00592B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_privateDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__callDele_m_privateDelegate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B42 RID: 88898 RVA: 0x005949B0 File Offset: 0x00592BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_privateDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			luaExportChecker.m_luaExportHelper.__clearDele_m_privateDelegate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B43 RID: 88899 RVA: 0x00594A04 File Offset: 0x00592C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_ReturnInt(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int a;
			LuaObject.checkType(l, 2, out a);
			int i = luaExportChecker.m_luaExportHelper.__callDele_ReturnInt(a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B44 RID: 88900 RVA: 0x00594A6C File Offset: 0x00592C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ReturnInt(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int a;
			LuaObject.checkType(l, 2, out a);
			luaExportChecker.m_luaExportHelper.__clearDele_ReturnInt(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B45 RID: 88901 RVA: 0x00594AC8 File Offset: 0x00592CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProtectedStaticMethod_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.ProtectedStaticMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B46 RID: 88902 RVA: 0x00594B08 File Offset: 0x00592D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrivateStaticMethod_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.PrivateStaticMethod();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B47 RID: 88903 RVA: 0x00594B48 File Offset: 0x00592D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_PublicStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__callDele_PublicStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B48 RID: 88904 RVA: 0x00594B88 File Offset: 0x00592D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_PublicStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__clearDele_PublicStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B49 RID: 88905 RVA: 0x00594BC8 File Offset: 0x00592DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_ProtectedStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__callDele_ProtectedStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4A RID: 88906 RVA: 0x00594C08 File Offset: 0x00592E08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ProtectedStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__clearDele_ProtectedStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4B RID: 88907 RVA: 0x00594C48 File Offset: 0x00592E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_PrivateStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__callDele_PrivateStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4C RID: 88908 RVA: 0x00594C88 File Offset: 0x00592E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_PrivateStaticEvent_s(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker.LuaExportHelper.__clearDele_PrivateStaticEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4D RID: 88909 RVA: 0x00594CC8 File Offset: 0x00592EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_publicStaticField(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.m_publicStaticField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4E RID: 88910 RVA: 0x00594D10 File Offset: 0x00592F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_publicStaticField(IntPtr l)
	{
		int result;
		try
		{
			int publicStaticField;
			LuaObject.checkType(l, 2, out publicStaticField);
			LuaExportChecker.m_publicStaticField = publicStaticField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B4F RID: 88911 RVA: 0x00594D5C File Offset: 0x00592F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protectedStaticField(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.LuaExportHelper.m_protectedStaticField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B50 RID: 88912 RVA: 0x00594DA4 File Offset: 0x00592FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protectedStaticField(IntPtr l)
	{
		int result;
		try
		{
			int protectedStaticField;
			LuaObject.checkType(l, 2, out protectedStaticField);
			LuaExportChecker.LuaExportHelper.m_protectedStaticField = protectedStaticField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B51 RID: 88913 RVA: 0x00594DF0 File Offset: 0x00592FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_privateStaticField(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.LuaExportHelper.m_privateStaticField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B52 RID: 88914 RVA: 0x00594E38 File Offset: 0x00593038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_privateStaticField(IntPtr l)
	{
		int result;
		try
		{
			int privateStaticField;
			LuaObject.checkType(l, 2, out privateStaticField);
			LuaExportChecker.LuaExportHelper.m_privateStaticField = privateStaticField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B53 RID: 88915 RVA: 0x00594E84 File Offset: 0x00593084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_publicField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.m_publicField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B54 RID: 88916 RVA: 0x00594ED8 File Offset: 0x005930D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_publicField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int publicField;
			LuaObject.checkType(l, 2, out publicField);
			luaExportChecker.m_publicField = publicField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B55 RID: 88917 RVA: 0x00594F30 File Offset: 0x00593130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_protectedField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.m_luaExportHelper.m_protectedField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B56 RID: 88918 RVA: 0x00594F88 File Offset: 0x00593188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_protectedField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int protectedField;
			LuaObject.checkType(l, 2, out protectedField);
			luaExportChecker.m_luaExportHelper.m_protectedField = protectedField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B57 RID: 88919 RVA: 0x00594FE4 File Offset: 0x005931E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_privateField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.m_luaExportHelper.m_privateField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B58 RID: 88920 RVA: 0x0059503C File Offset: 0x0059323C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_privateField(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int privateField;
			LuaObject.checkType(l, 2, out privateField);
			luaExportChecker.m_luaExportHelper.m_privateField = privateField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B59 RID: 88921 RVA: 0x00595098 File Offset: 0x00593298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PublicStaticEvent(IntPtr l)
	{
		int result;
		try
		{
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					LuaExportChecker.PublicStaticEvent += value;
				}
				else if (num == 2)
				{
					LuaExportChecker.PublicStaticEvent -= value;
				}
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

	// Token: 0x06015B5A RID: 88922 RVA: 0x00595108 File Offset: 0x00593308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProtectedStaticEvent(IntPtr l)
	{
		int result;
		try
		{
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					LuaExportChecker.LuaExportHelper.ProtectedStaticEvent += value;
				}
				else if (num == 2)
				{
					LuaExportChecker.LuaExportHelper.ProtectedStaticEvent -= value;
				}
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

	// Token: 0x06015B5B RID: 88923 RVA: 0x00595178 File Offset: 0x00593378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrivateStaticEvent(IntPtr l)
	{
		int result;
		try
		{
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					LuaExportChecker.LuaExportHelper.PrivateStaticEvent += value;
				}
				else if (num == 2)
				{
					LuaExportChecker.LuaExportHelper.PrivateStaticEvent -= value;
				}
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

	// Token: 0x06015B5C RID: 88924 RVA: 0x005951E8 File Offset: 0x005933E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PublicEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					luaExportChecker.PublicEvent += value;
				}
				else if (num == 2)
				{
					luaExportChecker.PublicEvent -= value;
				}
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

	// Token: 0x06015B5D RID: 88925 RVA: 0x00595268 File Offset: 0x00593468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProtectedEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					luaExportChecker.m_luaExportHelper.ProtectedEvent += value;
				}
				else if (num == 2)
				{
					luaExportChecker.m_luaExportHelper.ProtectedEvent -= value;
				}
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

	// Token: 0x06015B5E RID: 88926 RVA: 0x005952F0 File Offset: 0x005934F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrivateEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					luaExportChecker.m_luaExportHelper.PrivateEvent += value;
				}
				else if (num == 2)
				{
					luaExportChecker.m_luaExportHelper.PrivateEvent -= value;
				}
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

	// Token: 0x06015B5F RID: 88927 RVA: 0x00595378 File Offset: 0x00593578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_publicDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				luaExportChecker.m_publicDelegate = action;
			}
			else if (num == 1)
			{
				LuaExportChecker luaExportChecker2 = luaExportChecker;
				luaExportChecker2.m_publicDelegate = (Action)Delegate.Combine(luaExportChecker2.m_publicDelegate, action);
			}
			else if (num == 2)
			{
				LuaExportChecker luaExportChecker3 = luaExportChecker;
				luaExportChecker3.m_publicDelegate = (Action)Delegate.Remove(luaExportChecker3.m_publicDelegate, action);
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

	// Token: 0x06015B60 RID: 88928 RVA: 0x00595420 File Offset: 0x00593620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_protectedDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				luaExportChecker.m_luaExportHelper.m_protectedDelegate = action;
			}
			else if (num == 1)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper = luaExportChecker.m_luaExportHelper;
				luaExportHelper.m_protectedDelegate = (Action)Delegate.Combine(luaExportHelper.m_protectedDelegate, action);
			}
			else if (num == 2)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper2 = luaExportChecker.m_luaExportHelper;
				luaExportHelper2.m_protectedDelegate = (Action)Delegate.Remove(luaExportHelper2.m_protectedDelegate, action);
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

	// Token: 0x06015B61 RID: 88929 RVA: 0x005954D4 File Offset: 0x005936D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_privateDelegate(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				luaExportChecker.m_luaExportHelper.m_privateDelegate = action;
			}
			else if (num == 1)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper = luaExportChecker.m_luaExportHelper;
				luaExportHelper.m_privateDelegate = (Action)Delegate.Combine(luaExportHelper.m_privateDelegate, action);
			}
			else if (num == 2)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper2 = luaExportChecker.m_luaExportHelper;
				luaExportHelper2.m_privateDelegate = (Action)Delegate.Remove(luaExportHelper2.m_privateDelegate, action);
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

	// Token: 0x06015B62 RID: 88930 RVA: 0x00595588 File Offset: 0x00593788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReturnIntEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaExportChecker.ReturnIntDelegate value;
			int num = LuaObject.checkDelegate<LuaExportChecker.ReturnIntDelegate>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					luaExportChecker.ReturnIntEvent += value;
				}
				else if (num == 2)
				{
					luaExportChecker.ReturnIntEvent -= value;
				}
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

	// Token: 0x06015B63 RID: 88931 RVA: 0x00595608 File Offset: 0x00593808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReturnInt(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaExportChecker.ReturnIntDelegate returnIntDelegate;
			int num = LuaObject.checkDelegate<LuaExportChecker.ReturnIntDelegate>(l, 2, out returnIntDelegate);
			if (num == 0)
			{
				luaExportChecker.m_luaExportHelper.ReturnInt = returnIntDelegate;
			}
			else if (num == 1)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper = luaExportChecker.m_luaExportHelper;
				luaExportHelper.ReturnInt = (LuaExportChecker.ReturnIntDelegate)Delegate.Combine(luaExportHelper.ReturnInt, returnIntDelegate);
			}
			else if (num == 2)
			{
				LuaExportChecker.LuaExportHelper luaExportHelper2 = luaExportChecker.m_luaExportHelper;
				luaExportHelper2.ReturnInt = (LuaExportChecker.ReturnIntDelegate)Delegate.Remove(luaExportHelper2.ReturnInt, returnIntDelegate);
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

	// Token: 0x06015B64 RID: 88932 RVA: 0x005956BC File Offset: 0x005938BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PublicStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.PublicStaticProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B65 RID: 88933 RVA: 0x00595704 File Offset: 0x00593904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PublicStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			int publicStaticProperty;
			LuaObject.checkType(l, 2, out publicStaticProperty);
			LuaExportChecker.PublicStaticProperty = publicStaticProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B66 RID: 88934 RVA: 0x00595750 File Offset: 0x00593950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ProtectedStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.LuaExportHelper.ProtectedStaticProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B67 RID: 88935 RVA: 0x00595798 File Offset: 0x00593998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProtectedStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			int protectedStaticProperty;
			LuaObject.checkType(l, 2, out protectedStaticProperty);
			LuaExportChecker.LuaExportHelper.ProtectedStaticProperty = protectedStaticProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B68 RID: 88936 RVA: 0x005957E4 File Offset: 0x005939E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PrivateStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaExportChecker.LuaExportHelper.PrivateStaticProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B69 RID: 88937 RVA: 0x0059582C File Offset: 0x00593A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrivateStaticProperty(IntPtr l)
	{
		int result;
		try
		{
			int privateStaticProperty;
			LuaObject.checkType(l, 2, out privateStaticProperty);
			LuaExportChecker.LuaExportHelper.PrivateStaticProperty = privateStaticProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6A RID: 88938 RVA: 0x00595878 File Offset: 0x00593A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PublicProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.PublicProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6B RID: 88939 RVA: 0x005958CC File Offset: 0x00593ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PublicProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int publicProperty;
			LuaObject.checkType(l, 2, out publicProperty);
			luaExportChecker.PublicProperty = publicProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6C RID: 88940 RVA: 0x00595924 File Offset: 0x00593B24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ProtectedProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.m_luaExportHelper.ProtectedProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6D RID: 88941 RVA: 0x0059597C File Offset: 0x00593B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProtectedProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int protectedProperty;
			LuaObject.checkType(l, 2, out protectedProperty);
			luaExportChecker.m_luaExportHelper.ProtectedProperty = protectedProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6E RID: 88942 RVA: 0x005959D8 File Offset: 0x00593BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrivateProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaExportChecker.m_luaExportHelper.PrivateProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B6F RID: 88943 RVA: 0x00595A30 File Offset: 0x00593C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrivateProperty(IntPtr l)
	{
		int result;
		try
		{
			LuaExportChecker luaExportChecker = (LuaExportChecker)LuaObject.checkSelf(l);
			int privateProperty;
			LuaObject.checkType(l, 2, out privateProperty);
			luaExportChecker.m_luaExportHelper.PrivateProperty = privateProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B70 RID: 88944 RVA: 0x00595A8C File Offset: 0x00593C8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaExportChecker");
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.PublicMethod);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.ReturnAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.PublicStaticMethod_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.ProtectedMethod);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.PrivateMethod);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_PublicEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_PublicEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_ProtectedEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_ProtectedEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_PrivateEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_PrivateEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_ReturnIntEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_ReturnIntEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_m_protectedDelegate);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_m_protectedDelegate);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_m_privateDelegate);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_m_privateDelegate);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_ReturnInt);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_ReturnInt);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.ProtectedStaticMethod_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.PrivateStaticMethod_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_PublicStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_PublicStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_ProtectedStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_ProtectedStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__callDele_PrivateStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.__clearDele_PrivateStaticEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1A);
		string name = "m_publicStaticField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_publicStaticField);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1B;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_publicStaticField);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1C, false);
		string name2 = "m_protectedStaticField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_protectedStaticField);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1D;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_protectedStaticField);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1E, false);
		string name3 = "m_privateStaticField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_privateStaticField);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache1F;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_privateStaticField);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache20, false);
		string name4 = "m_publicField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_publicField);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache21;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_publicField);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache22, true);
		string name5 = "m_protectedField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_protectedField);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache23;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_protectedField);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache24, true);
		string name6 = "m_privateField";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_m_privateField);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache25;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_privateField);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache26, true);
		string name7 = "PublicStaticEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PublicStaticEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache27, false);
		string name8 = "ProtectedStaticEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ProtectedStaticEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache28, false);
		string name9 = "PrivateStaticEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PrivateStaticEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache29, false);
		string name10 = "PublicEvent";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PublicEvent);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2A, true);
		string name11 = "ProtectedEvent";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ProtectedEvent);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2B, true);
		string name12 = "PrivateEvent";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PrivateEvent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2C, true);
		string name13 = "m_publicDelegate";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_publicDelegate);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2D, true);
		string name14 = "m_protectedDelegate";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_protectedDelegate);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2E, true);
		string name15 = "m_privateDelegate";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_m_privateDelegate);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache2F, true);
		string name16 = "ReturnIntEvent";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ReturnIntEvent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache30, true);
		string name17 = "ReturnInt";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ReturnInt);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache31, true);
		string name18 = "PublicStaticProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_PublicStaticProperty);
		}
		LuaCSFunction get18 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache32;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PublicStaticProperty);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache33, false);
		string name19 = "ProtectedStaticProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_ProtectedStaticProperty);
		}
		LuaCSFunction get19 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache34;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ProtectedStaticProperty);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache35, false);
		string name20 = "PrivateStaticProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_PrivateStaticProperty);
		}
		LuaCSFunction get20 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache36;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PrivateStaticProperty);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache37, false);
		string name21 = "PublicProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_PublicProperty);
		}
		LuaCSFunction get21 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache38;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PublicProperty);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache39, true);
		string name22 = "ProtectedProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_ProtectedProperty);
		}
		LuaCSFunction get22 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3A;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_ProtectedProperty);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3B, true);
		string name23 = "PrivateProperty";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.get_PrivateProperty);
		}
		LuaCSFunction get23 = Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3C;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.set_PrivateProperty);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3D, true);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.<>f__mg$cache3E, typeof(LuaExportChecker));
	}

	// Token: 0x0400C2FD RID: 49917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2FE RID: 49918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2FF RID: 49919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C300 RID: 49920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C301 RID: 49921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C302 RID: 49922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C303 RID: 49923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C304 RID: 49924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C305 RID: 49925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C306 RID: 49926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C307 RID: 49927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C308 RID: 49928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C309 RID: 49929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C30A RID: 49930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C30B RID: 49931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C30C RID: 49932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C30D RID: 49933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C30E RID: 49934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C30F RID: 49935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C310 RID: 49936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C311 RID: 49937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C312 RID: 49938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C313 RID: 49939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C314 RID: 49940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C315 RID: 49941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C316 RID: 49942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C317 RID: 49943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C318 RID: 49944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C319 RID: 49945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C31A RID: 49946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C31B RID: 49947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C31C RID: 49948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C31D RID: 49949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C31E RID: 49950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C31F RID: 49951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C320 RID: 49952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C321 RID: 49953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C322 RID: 49954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C323 RID: 49955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C324 RID: 49956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C325 RID: 49957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C326 RID: 49958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C327 RID: 49959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C328 RID: 49960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C329 RID: 49961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C32A RID: 49962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C32B RID: 49963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C32C RID: 49964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C32D RID: 49965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C32E RID: 49966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C32F RID: 49967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C330 RID: 49968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C331 RID: 49969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C332 RID: 49970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C333 RID: 49971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C334 RID: 49972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C335 RID: 49973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C336 RID: 49974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C337 RID: 49975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C338 RID: 49976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C339 RID: 49977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C33A RID: 49978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C33B RID: 49979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;
}
