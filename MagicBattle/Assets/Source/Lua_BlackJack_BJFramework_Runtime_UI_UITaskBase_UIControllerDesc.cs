using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200112E RID: 4398
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc : LuaObject
{
	// Token: 0x06015EC4 RID: 89796 RVA: 0x005AF874 File Offset: 0x005ADA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc o = new UITaskBase.UIControllerDesc();
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

	// Token: 0x06015EC5 RID: 89797 RVA: 0x005AF8BC File Offset: 0x005ADABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ctrlName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerDesc.m_ctrlName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC6 RID: 89798 RVA: 0x005AF910 File Offset: 0x005ADB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ctrlName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			uicontrollerDesc.m_ctrlName = ctrlName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC7 RID: 89799 RVA: 0x005AF968 File Offset: 0x005ADB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_luaModuleName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerDesc.m_luaModuleName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC8 RID: 89800 RVA: 0x005AF9BC File Offset: 0x005ADBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_luaModuleName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			string luaModuleName;
			LuaObject.checkType(l, 2, out luaModuleName);
			uicontrollerDesc.m_luaModuleName = luaModuleName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC9 RID: 89801 RVA: 0x005AFA14 File Offset: 0x005ADC14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ctrlTypeDNName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerDesc.m_ctrlTypeDNName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECA RID: 89802 RVA: 0x005AFA68 File Offset: 0x005ADC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ctrlTypeDNName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			TypeDNName ctrlTypeDNName;
			LuaObject.checkType<TypeDNName>(l, 2, out ctrlTypeDNName);
			uicontrollerDesc.m_ctrlTypeDNName = ctrlTypeDNName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECB RID: 89803 RVA: 0x005AFAC0 File Offset: 0x005ADCC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_attachLayerName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerDesc.m_attachLayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECC RID: 89804 RVA: 0x005AFB14 File Offset: 0x005ADD14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_attachLayerName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			string attachLayerName;
			LuaObject.checkType(l, 2, out attachLayerName);
			uicontrollerDesc.m_attachLayerName = attachLayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECD RID: 89805 RVA: 0x005AFB6C File Offset: 0x005ADD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attachPath(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicontrollerDesc.m_attachPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECE RID: 89806 RVA: 0x005AFBC0 File Offset: 0x005ADDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attachPath(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.UIControllerDesc uicontrollerDesc = (UITaskBase.UIControllerDesc)LuaObject.checkSelf(l);
			string attachPath;
			LuaObject.checkType(l, 2, out attachPath);
			uicontrollerDesc.m_attachPath = attachPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ECF RID: 89807 RVA: 0x005AFC18 File Offset: 0x005ADE18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UITaskBase.UIControllerDesc");
		string name = "m_ctrlName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.get_m_ctrlName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.set_m_ctrlName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache1, true);
		string name2 = "m_luaModuleName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.get_m_luaModuleName);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.set_m_luaModuleName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache3, true);
		string name3 = "m_ctrlTypeDNName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.get_m_ctrlTypeDNName);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache4;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.set_m_ctrlTypeDNName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache5, true);
		string name4 = "m_attachLayerName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.get_m_attachLayerName);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache6;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.set_m_attachLayerName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache7, true);
		string name5 = "m_attachPath";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.get_m_attachPath);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache8;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.set_m_attachPath);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cache9, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.<>f__mg$cacheA, typeof(UITaskBase.UIControllerDesc));
	}

	// Token: 0x0400C64A RID: 50762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C64B RID: 50763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C64C RID: 50764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C64D RID: 50765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C64E RID: 50766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C64F RID: 50767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C650 RID: 50768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C651 RID: 50769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C652 RID: 50770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C653 RID: 50771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C654 RID: 50772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
