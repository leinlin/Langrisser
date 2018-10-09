using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181C RID: 6172
[Preserve]
public class Lua_UnityEngine_UI_Dropdown : LuaObject
{
	// Token: 0x06024005 RID: 147461 RVA: 0x00CA2D24 File Offset: 0x00CA0F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshShownValue(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			dropdown.RefreshShownValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024006 RID: 147462 RVA: 0x00CA2D70 File Offset: 0x00CA0F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddOptions(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<Dropdown.OptionData>)))
			{
				Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
				List<Dropdown.OptionData> options;
				LuaObject.checkType<List<Dropdown.OptionData>>(l, 2, out options);
				dropdown.AddOptions(options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<string>)))
			{
				Dropdown dropdown2 = (Dropdown)LuaObject.checkSelf(l);
				List<string> options2;
				LuaObject.checkType<List<string>>(l, 2, out options2);
				dropdown2.AddOptions(options2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<Sprite>)))
			{
				Dropdown dropdown3 = (Dropdown)LuaObject.checkSelf(l);
				List<Sprite> options3;
				LuaObject.checkType<List<Sprite>>(l, 2, out options3);
				dropdown3.AddOptions(options3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddOptions to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024007 RID: 147463 RVA: 0x00CA2E8C File Offset: 0x00CA108C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearOptions(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			dropdown.ClearOptions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024008 RID: 147464 RVA: 0x00CA2ED8 File Offset: 0x00CA10D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			dropdown.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024009 RID: 147465 RVA: 0x00CA2F30 File Offset: 0x00CA1130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			dropdown.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400A RID: 147466 RVA: 0x00CA2F88 File Offset: 0x00CA1188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancel(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			dropdown.OnCancel(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400B RID: 147467 RVA: 0x00CA2FE0 File Offset: 0x00CA11E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			dropdown.Show();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400C RID: 147468 RVA: 0x00CA302C File Offset: 0x00CA122C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Hide(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			dropdown.Hide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400D RID: 147469 RVA: 0x00CA3078 File Offset: 0x00CA1278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_template(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.template);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400E RID: 147470 RVA: 0x00CA30CC File Offset: 0x00CA12CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_template(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			RectTransform template;
			LuaObject.checkType<RectTransform>(l, 2, out template);
			dropdown.template = template;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602400F RID: 147471 RVA: 0x00CA3124 File Offset: 0x00CA1324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_captionText(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.captionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024010 RID: 147472 RVA: 0x00CA3178 File Offset: 0x00CA1378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_captionText(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			Text captionText;
			LuaObject.checkType<Text>(l, 2, out captionText);
			dropdown.captionText = captionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024011 RID: 147473 RVA: 0x00CA31D0 File Offset: 0x00CA13D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_captionImage(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.captionImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024012 RID: 147474 RVA: 0x00CA3224 File Offset: 0x00CA1424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_captionImage(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			Image captionImage;
			LuaObject.checkType<Image>(l, 2, out captionImage);
			dropdown.captionImage = captionImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024013 RID: 147475 RVA: 0x00CA327C File Offset: 0x00CA147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_itemText(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.itemText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024014 RID: 147476 RVA: 0x00CA32D0 File Offset: 0x00CA14D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_itemText(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			Text itemText;
			LuaObject.checkType<Text>(l, 2, out itemText);
			dropdown.itemText = itemText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024015 RID: 147477 RVA: 0x00CA3328 File Offset: 0x00CA1528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_itemImage(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.itemImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024016 RID: 147478 RVA: 0x00CA337C File Offset: 0x00CA157C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_itemImage(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			Image itemImage;
			LuaObject.checkType<Image>(l, 2, out itemImage);
			dropdown.itemImage = itemImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024017 RID: 147479 RVA: 0x00CA33D4 File Offset: 0x00CA15D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_options(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.options);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024018 RID: 147480 RVA: 0x00CA3428 File Offset: 0x00CA1628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_options(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			List<Dropdown.OptionData> options;
			LuaObject.checkType<List<Dropdown.OptionData>>(l, 2, out options);
			dropdown.options = options;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024019 RID: 147481 RVA: 0x00CA3480 File Offset: 0x00CA1680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602401A RID: 147482 RVA: 0x00CA34D4 File Offset: 0x00CA16D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			Dropdown.DropdownEvent onValueChanged;
			LuaObject.checkType<Dropdown.DropdownEvent>(l, 2, out onValueChanged);
			dropdown.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602401B RID: 147483 RVA: 0x00CA352C File Offset: 0x00CA172C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropdown.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602401C RID: 147484 RVA: 0x00CA3580 File Offset: 0x00CA1780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_value(IntPtr l)
	{
		int result;
		try
		{
			Dropdown dropdown = (Dropdown)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			dropdown.value = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602401D RID: 147485 RVA: 0x00CA35D8 File Offset: 0x00CA17D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Dropdown");
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.RefreshShownValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.AddOptions);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.ClearOptions);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.OnCancel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.Show);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.Hide);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache7);
		string name = "template";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_template);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Dropdown.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_template);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache9, true);
		string name2 = "captionText";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_captionText);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_captionText);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheB, true);
		string name3 = "captionImage";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_captionImage);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_captionImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheD, true);
		string name4 = "itemText";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_itemText);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_itemText);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Dropdown.<>f__mg$cacheF, true);
		string name5 = "itemImage";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_itemImage);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_itemImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache11, true);
		string name6 = "options";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_options);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_options);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache13, true);
		string name7 = "onValueChanged";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_onValueChanged);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_onValueChanged);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache15, true);
		string name8 = "value";
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.get_value);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_Dropdown.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_Dropdown.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Dropdown.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown.set_value);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_Dropdown.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(Dropdown), typeof(Selectable));
	}

	// Token: 0x04019C2B RID: 105515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C2C RID: 105516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C2D RID: 105517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C2E RID: 105518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C2F RID: 105519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C30 RID: 105520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C31 RID: 105521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C32 RID: 105522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C33 RID: 105523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C34 RID: 105524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C35 RID: 105525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019C36 RID: 105526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019C37 RID: 105527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019C38 RID: 105528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019C39 RID: 105529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019C3A RID: 105530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019C3B RID: 105531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019C3C RID: 105532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019C3D RID: 105533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019C3E RID: 105534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019C3F RID: 105535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019C40 RID: 105536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019C41 RID: 105537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019C42 RID: 105538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
