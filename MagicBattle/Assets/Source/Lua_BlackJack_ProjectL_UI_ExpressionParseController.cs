using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001434 RID: 5172
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ExpressionParseController : LuaObject
{
	// Token: 0x0601DA83 RID: 121475 RVA: 0x0096CCF4 File Offset: 0x0096AEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			GameObject image;
			LuaObject.checkType<GameObject>(l, 2, out image);
			int gap;
			LuaObject.checkType(l, 3, out gap);
			float offsetX;
			LuaObject.checkType(l, 4, out offsetX);
			float offsetY;
			LuaObject.checkType(l, 5, out offsetY);
			float fontSize;
			LuaObject.checkType(l, 6, out fontSize);
			expressionParseController.Init(image, gap, offsetX, offsetY, fontSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA84 RID: 121476 RVA: 0x0096CD80 File Offset: 0x0096AF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChatItemWithTextAndSmallExpression(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			string inputString;
			LuaObject.checkType(l, 3, out inputString);
			expressionParseController.SetChatItemWithTextAndSmallExpression(text, inputString);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA85 RID: 121477 RVA: 0x0096CDE4 File Offset: 0x0096AFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUITextWithSmallExpression(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			Text textToEdit;
			LuaObject.checkType<Text>(l, 2, out textToEdit);
			string inputString;
			LuaObject.checkType(l, 3, out inputString);
			IEnumerator o = expressionParseController.m_luaExportHelper.SetUITextWithSmallExpression(textToEdit, inputString);
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

	// Token: 0x0601DA86 RID: 121478 RVA: 0x0096CE58 File Offset: 0x0096B058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ParseEmoji(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			string inputString;
			LuaObject.checkType(l, 2, out inputString);
			string s;
			List<ExpressionParseController.PosStringTuple> o = expressionParseController.m_luaExportHelper.ParseEmoji(inputString, out s);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, s);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA87 RID: 121479 RVA: 0x0096CECC File Offset: 0x0096B0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_imageToClone(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_imageToClone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA88 RID: 121480 RVA: 0x0096CF24 File Offset: 0x0096B124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_imageToClone(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			Image imageToClone;
			LuaObject.checkType<Image>(l, 2, out imageToClone);
			expressionParseController.m_luaExportHelper.m_imageToClone = imageToClone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA89 RID: 121481 RVA: 0x0096CF80 File Offset: 0x0096B180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_regexParamStr(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_regexParamStr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8A RID: 121482 RVA: 0x0096CFD8 File Offset: 0x0096B1D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_regexParamStr(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			string regexParamStr;
			LuaObject.checkType(l, 2, out regexParamStr);
			expressionParseController.m_luaExportHelper.m_regexParamStr = regexParamStr;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8B RID: 121483 RVA: 0x0096D034 File Offset: 0x0096B234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offsetX(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_offsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8C RID: 121484 RVA: 0x0096D08C File Offset: 0x0096B28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offsetX(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			float offsetX;
			LuaObject.checkType(l, 2, out offsetX);
			expressionParseController.m_luaExportHelper.m_offsetX = offsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8D RID: 121485 RVA: 0x0096D0E8 File Offset: 0x0096B2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offsetY(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_offsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8E RID: 121486 RVA: 0x0096D140 File Offset: 0x0096B340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offsetY(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			float offsetY;
			LuaObject.checkType(l, 2, out offsetY);
			expressionParseController.m_luaExportHelper.m_offsetY = offsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA8F RID: 121487 RVA: 0x0096D19C File Offset: 0x0096B39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fontSize(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA90 RID: 121488 RVA: 0x0096D1F4 File Offset: 0x0096B3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fontSize(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			float fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			expressionParseController.m_luaExportHelper.m_fontSize = fontSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA91 RID: 121489 RVA: 0x0096D250 File Offset: 0x0096B450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_richTextIndexOffSet(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_richTextIndexOffSet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA92 RID: 121490 RVA: 0x0096D2A8 File Offset: 0x0096B4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_richTextIndexOffSet(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			int richTextIndexOffSet;
			LuaObject.checkType(l, 2, out richTextIndexOffSet);
			expressionParseController.m_luaExportHelper.m_richTextIndexOffSet = richTextIndexOffSet;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA93 RID: 121491 RVA: 0x0096D304 File Offset: 0x0096B504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gapSize(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_gapSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA94 RID: 121492 RVA: 0x0096D35C File Offset: 0x0096B55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gapSize(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			float gapSize;
			LuaObject.checkType(l, 2, out gapSize);
			expressionParseController.m_luaExportHelper.m_gapSize = gapSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA95 RID: 121493 RVA: 0x0096D3B8 File Offset: 0x0096B5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_emSpace(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.emSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA96 RID: 121494 RVA: 0x0096D410 File Offset: 0x0096B610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_emSpace(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			string emSpace;
			LuaObject.checkType(l, 2, out emSpace);
			expressionParseController.m_luaExportHelper.emSpace = emSpace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA97 RID: 121495 RVA: 0x0096D46C File Offset: 0x0096B66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isInited(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_isInited);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA98 RID: 121496 RVA: 0x0096D4C4 File Offset: 0x0096B6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isInited(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			bool isInited;
			LuaObject.checkType(l, 2, out isInited);
			expressionParseController.m_luaExportHelper.m_isInited = isInited;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA99 RID: 121497 RVA: 0x0096D520 File Offset: 0x0096B720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expressionParseController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA9A RID: 121498 RVA: 0x0096D578 File Offset: 0x0096B778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController expressionParseController = (ExpressionParseController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			expressionParseController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA9B RID: 121499 RVA: 0x0096D5D4 File Offset: 0x0096B7D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ExpressionParseController");
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.SetChatItemWithTextAndSmallExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.SetUITextWithSmallExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.ParseEmoji);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache3);
		string name = "m_imageToClone";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_imageToClone);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_imageToClone);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache5, true);
		string name2 = "m_regexParamStr";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_regexParamStr);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_regexParamStr);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache7, true);
		string name3 = "m_offsetX";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_offsetX);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_offsetX);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache9, true);
		string name4 = "m_offsetY";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_offsetY);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_offsetY);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheB, true);
		string name5 = "m_fontSize";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_fontSize);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_fontSize);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheD, true);
		string name6 = "m_richTextIndexOffSet";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_richTextIndexOffSet);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_richTextIndexOffSet);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cacheF, true);
		string name7 = "m_gapSize";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_gapSize);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_gapSize);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache11, true);
		string name8 = "emSpace";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_emSpace);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_emSpace);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache13, true);
		string name9 = "m_isInited";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_isInited);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_isInited);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache15, true);
		string name10 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.get_m_configDataLoader);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ExpressionParseController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(ExpressionParseController), typeof(MonoBehaviour));
	}

	// Token: 0x04013BFD RID: 80893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013BFE RID: 80894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013BFF RID: 80895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013C00 RID: 80896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013C01 RID: 80897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013C02 RID: 80898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013C03 RID: 80899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013C04 RID: 80900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013C05 RID: 80901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013C06 RID: 80902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013C07 RID: 80903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013C08 RID: 80904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013C09 RID: 80905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013C0A RID: 80906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013C0B RID: 80907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013C0C RID: 80908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013C0D RID: 80909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013C0E RID: 80910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013C0F RID: 80911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013C10 RID: 80912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013C11 RID: 80913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013C12 RID: 80914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013C13 RID: 80915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013C14 RID: 80916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
