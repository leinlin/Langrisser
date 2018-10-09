using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200160D RID: 5645
[Preserve]
public class Lua_UnityEngine_AnchoredJoint2D : LuaObject
{
	// Token: 0x060229E9 RID: 141801 RVA: 0x00BEC58C File Offset: 0x00BEA78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anchoredJoint2D.anchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229EA RID: 141802 RVA: 0x00BEC5E0 File Offset: 0x00BEA7E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_anchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			Vector2 anchor;
			LuaObject.checkType(l, 2, out anchor);
			anchoredJoint2D.anchor = anchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229EB RID: 141803 RVA: 0x00BEC638 File Offset: 0x00BEA838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_connectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anchoredJoint2D.connectedAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229EC RID: 141804 RVA: 0x00BEC68C File Offset: 0x00BEA88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_connectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			Vector2 connectedAnchor;
			LuaObject.checkType(l, 2, out connectedAnchor);
			anchoredJoint2D.connectedAnchor = connectedAnchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229ED RID: 141805 RVA: 0x00BEC6E4 File Offset: 0x00BEA8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureConnectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anchoredJoint2D.autoConfigureConnectedAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229EE RID: 141806 RVA: 0x00BEC738 File Offset: 0x00BEA938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_autoConfigureConnectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			AnchoredJoint2D anchoredJoint2D = (AnchoredJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureConnectedAnchor;
			LuaObject.checkType(l, 2, out autoConfigureConnectedAnchor);
			anchoredJoint2D.autoConfigureConnectedAnchor = autoConfigureConnectedAnchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229EF RID: 141807 RVA: 0x00BEC790 File Offset: 0x00BEA990
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnchoredJoint2D");
		string name = "anchor";
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.get_anchor);
		}
		LuaCSFunction get = Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.set_anchor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache1, true);
		string name2 = "connectedAnchor";
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.get_connectedAnchor);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.set_connectedAnchor);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache3, true);
		string name3 = "autoConfigureConnectedAnchor";
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.get_autoConfigureConnectedAnchor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache4;
		if (Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnchoredJoint2D.set_autoConfigureConnectedAnchor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_AnchoredJoint2D.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(AnchoredJoint2D), typeof(Joint2D));
	}

	// Token: 0x04018A2D RID: 100909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A2E RID: 100910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A2F RID: 100911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A30 RID: 100912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A31 RID: 100913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A32 RID: 100914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
