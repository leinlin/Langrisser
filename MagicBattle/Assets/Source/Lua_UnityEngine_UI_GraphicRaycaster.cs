using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001823 RID: 6179
[Preserve]
public class Lua_UnityEngine_UI_GraphicRaycaster : LuaObject
{
	// Token: 0x06024072 RID: 147570 RVA: 0x00CA5D80 File Offset: 0x00CA3F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			List<RaycastResult> resultAppendList;
			LuaObject.checkType<List<RaycastResult>>(l, 3, out resultAppendList);
			graphicRaycaster.Raycast(eventData, resultAppendList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024073 RID: 147571 RVA: 0x00CA5DE4 File Offset: 0x00CA3FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortOrderPriority(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicRaycaster.sortOrderPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024074 RID: 147572 RVA: 0x00CA5E38 File Offset: 0x00CA4038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderOrderPriority(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicRaycaster.renderOrderPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024075 RID: 147573 RVA: 0x00CA5E8C File Offset: 0x00CA408C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ignoreReversedGraphics(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicRaycaster.ignoreReversedGraphics);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024076 RID: 147574 RVA: 0x00CA5EE0 File Offset: 0x00CA40E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ignoreReversedGraphics(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			bool ignoreReversedGraphics;
			LuaObject.checkType(l, 2, out ignoreReversedGraphics);
			graphicRaycaster.ignoreReversedGraphics = ignoreReversedGraphics;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024077 RID: 147575 RVA: 0x00CA5F38 File Offset: 0x00CA4138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blockingObjects(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)graphicRaycaster.blockingObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024078 RID: 147576 RVA: 0x00CA5F8C File Offset: 0x00CA418C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_blockingObjects(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			GraphicRaycaster.BlockingObjects blockingObjects;
			LuaObject.checkEnum<GraphicRaycaster.BlockingObjects>(l, 2, out blockingObjects);
			graphicRaycaster.blockingObjects = blockingObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024079 RID: 147577 RVA: 0x00CA5FE4 File Offset: 0x00CA41E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventCamera(IntPtr l)
	{
		int result;
		try
		{
			GraphicRaycaster graphicRaycaster = (GraphicRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicRaycaster.eventCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602407A RID: 147578 RVA: 0x00CA6038 File Offset: 0x00CA4238
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.GraphicRaycaster");
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache0);
		string name = "sortOrderPriority";
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.get_sortOrderPriority);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache1, null, true);
		string name2 = "renderOrderPriority";
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.get_renderOrderPriority);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache2, null, true);
		string name3 = "ignoreReversedGraphics";
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.get_ignoreReversedGraphics);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache3;
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.set_ignoreReversedGraphics);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache4, true);
		string name4 = "blockingObjects";
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.get_blockingObjects);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache5;
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.set_blockingObjects);
		}
		LuaObject.addMember(l, name4, get2, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache6, true);
		string name5 = "eventCamera";
		if (Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRaycaster.get_eventCamera);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_UI_GraphicRaycaster.<>f__mg$cache7, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(GraphicRaycaster), typeof(BaseRaycaster));
	}

	// Token: 0x04019C8A RID: 105610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C8B RID: 105611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C8C RID: 105612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C8D RID: 105613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C8E RID: 105614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C8F RID: 105615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C90 RID: 105616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C91 RID: 105617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
