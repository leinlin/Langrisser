using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200183F RID: 6207
[Preserve]
public class Lua_UnityEngine_UI_InputField : LuaObject
{
	// Token: 0x06024115 RID: 147733 RVA: 0x00CA96B8 File Offset: 0x00CA78B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTextEnd(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			bool shift;
			LuaObject.checkType(l, 2, out shift);
			inputField.MoveTextEnd(shift);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024116 RID: 147734 RVA: 0x00CA9710 File Offset: 0x00CA7910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTextStart(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			bool shift;
			LuaObject.checkType(l, 2, out shift);
			inputField.MoveTextStart(shift);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024117 RID: 147735 RVA: 0x00CA9768 File Offset: 0x00CA7968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			inputField.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024118 RID: 147736 RVA: 0x00CA97C0 File Offset: 0x00CA79C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			inputField.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024119 RID: 147737 RVA: 0x00CA9818 File Offset: 0x00CA7A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			inputField.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602411A RID: 147738 RVA: 0x00CA9870 File Offset: 0x00CA7A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			inputField.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602411B RID: 147739 RVA: 0x00CA98C8 File Offset: 0x00CA7AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProcessEvent(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			Event e;
			LuaObject.checkType<Event>(l, 2, out e);
			inputField.ProcessEvent(e);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0602411C RID: 147740 RVA: 0x00CA9920 File Offset: 0x00CA7B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUpdateSelected(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			inputField.OnUpdateSelected(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602411D RID: 147741 RVA: 0x00CA9978 File Offset: 0x00CA7B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceLabelUpdate(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.ForceLabelUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602411E RID: 147742 RVA: 0x00CA99C4 File Offset: 0x00CA7BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			CanvasUpdate update;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out update);
			inputField.Rebuild(update);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602411F RID: 147743 RVA: 0x00CA9A1C File Offset: 0x00CA7C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024120 RID: 147744 RVA: 0x00CA9A68 File Offset: 0x00CA7C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024121 RID: 147745 RVA: 0x00CA9AB4 File Offset: 0x00CA7CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateInputField(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.ActivateInputField();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024122 RID: 147746 RVA: 0x00CA9B00 File Offset: 0x00CA7D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelect(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			inputField.OnSelect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024123 RID: 147747 RVA: 0x00CA9B58 File Offset: 0x00CA7D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			inputField.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024124 RID: 147748 RVA: 0x00CA9BB0 File Offset: 0x00CA7DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeactivateInputField(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.DeactivateInputField();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024125 RID: 147749 RVA: 0x00CA9BFC File Offset: 0x00CA7DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeselect(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			inputField.OnDeselect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024126 RID: 147750 RVA: 0x00CA9C54 File Offset: 0x00CA7E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			inputField.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024127 RID: 147751 RVA: 0x00CA9CAC File Offset: 0x00CA7EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024128 RID: 147752 RVA: 0x00CA9CF8 File Offset: 0x00CA7EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			inputField.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024129 RID: 147753 RVA: 0x00CA9D44 File Offset: 0x00CA7F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shouldHideMobileInput(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.shouldHideMobileInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412A RID: 147754 RVA: 0x00CA9D98 File Offset: 0x00CA7F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shouldHideMobileInput(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			bool shouldHideMobileInput;
			LuaObject.checkType(l, 2, out shouldHideMobileInput);
			inputField.shouldHideMobileInput = shouldHideMobileInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412B RID: 147755 RVA: 0x00CA9DF0 File Offset: 0x00CA7FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412C RID: 147756 RVA: 0x00CA9E44 File Offset: 0x00CA8044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_text(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			inputField.text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412D RID: 147757 RVA: 0x00CA9E9C File Offset: 0x00CA809C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFocused(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.isFocused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412E RID: 147758 RVA: 0x00CA9EF0 File Offset: 0x00CA80F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_caretBlinkRate(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.caretBlinkRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602412F RID: 147759 RVA: 0x00CA9F44 File Offset: 0x00CA8144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_caretBlinkRate(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			float caretBlinkRate;
			LuaObject.checkType(l, 2, out caretBlinkRate);
			inputField.caretBlinkRate = caretBlinkRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024130 RID: 147760 RVA: 0x00CA9F9C File Offset: 0x00CA819C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_caretWidth(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.caretWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024131 RID: 147761 RVA: 0x00CA9FF0 File Offset: 0x00CA81F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_caretWidth(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			int caretWidth;
			LuaObject.checkType(l, 2, out caretWidth);
			inputField.caretWidth = caretWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024132 RID: 147762 RVA: 0x00CAA048 File Offset: 0x00CA8248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textComponent(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.textComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024133 RID: 147763 RVA: 0x00CAA09C File Offset: 0x00CA829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_textComponent(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			Text textComponent;
			LuaObject.checkType<Text>(l, 2, out textComponent);
			inputField.textComponent = textComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024134 RID: 147764 RVA: 0x00CAA0F4 File Offset: 0x00CA82F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_placeholder(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.placeholder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024135 RID: 147765 RVA: 0x00CAA148 File Offset: 0x00CA8348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_placeholder(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			Graphic placeholder;
			LuaObject.checkType<Graphic>(l, 2, out placeholder);
			inputField.placeholder = placeholder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024136 RID: 147766 RVA: 0x00CAA1A0 File Offset: 0x00CA83A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_caretColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.caretColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024137 RID: 147767 RVA: 0x00CAA1F4 File Offset: 0x00CA83F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_caretColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			Color caretColor;
			LuaObject.checkType(l, 2, out caretColor);
			inputField.caretColor = caretColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024138 RID: 147768 RVA: 0x00CAA24C File Offset: 0x00CA844C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_customCaretColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.customCaretColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024139 RID: 147769 RVA: 0x00CAA2A0 File Offset: 0x00CA84A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_customCaretColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			bool customCaretColor;
			LuaObject.checkType(l, 2, out customCaretColor);
			inputField.customCaretColor = customCaretColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413A RID: 147770 RVA: 0x00CAA2F8 File Offset: 0x00CA84F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectionColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.selectionColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413B RID: 147771 RVA: 0x00CAA34C File Offset: 0x00CA854C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectionColor(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			Color selectionColor;
			LuaObject.checkType(l, 2, out selectionColor);
			inputField.selectionColor = selectionColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413C RID: 147772 RVA: 0x00CAA3A4 File Offset: 0x00CA85A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onEndEdit(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.onEndEdit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413D RID: 147773 RVA: 0x00CAA3F8 File Offset: 0x00CA85F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onEndEdit(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.SubmitEvent onEndEdit;
			LuaObject.checkType<InputField.SubmitEvent>(l, 2, out onEndEdit);
			inputField.onEndEdit = onEndEdit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413E RID: 147774 RVA: 0x00CAA450 File Offset: 0x00CA8650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602413F RID: 147775 RVA: 0x00CAA4A4 File Offset: 0x00CA86A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.OnChangeEvent onValueChanged;
			LuaObject.checkType<InputField.OnChangeEvent>(l, 2, out onValueChanged);
			inputField.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024140 RID: 147776 RVA: 0x00CAA4FC File Offset: 0x00CA86FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onValidateInput(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.OnValidateInput onValidateInput;
			int num = LuaObject.checkDelegate<InputField.OnValidateInput>(l, 2, out onValidateInput);
			if (num == 0)
			{
				inputField.onValidateInput = onValidateInput;
			}
			else if (num == 1)
			{
				InputField inputField2 = inputField;
				inputField2.onValidateInput = (InputField.OnValidateInput)Delegate.Combine(inputField2.onValidateInput, onValidateInput);
			}
			else if (num == 2)
			{
				InputField inputField3 = inputField;
				inputField3.onValidateInput = (InputField.OnValidateInput)Delegate.Remove(inputField3.onValidateInput, onValidateInput);
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

	// Token: 0x06024141 RID: 147777 RVA: 0x00CAA5A4 File Offset: 0x00CA87A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_characterLimit(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.characterLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024142 RID: 147778 RVA: 0x00CAA5F8 File Offset: 0x00CA87F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_characterLimit(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			int characterLimit;
			LuaObject.checkType(l, 2, out characterLimit);
			inputField.characterLimit = characterLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024143 RID: 147779 RVA: 0x00CAA650 File Offset: 0x00CA8850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contentType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)inputField.contentType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024144 RID: 147780 RVA: 0x00CAA6A4 File Offset: 0x00CA88A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_contentType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.ContentType contentType;
			LuaObject.checkEnum<InputField.ContentType>(l, 2, out contentType);
			inputField.contentType = contentType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024145 RID: 147781 RVA: 0x00CAA6FC File Offset: 0x00CA88FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)inputField.lineType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024146 RID: 147782 RVA: 0x00CAA750 File Offset: 0x00CA8950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lineType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.LineType lineType;
			LuaObject.checkEnum<InputField.LineType>(l, 2, out lineType);
			inputField.lineType = lineType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024147 RID: 147783 RVA: 0x00CAA7A8 File Offset: 0x00CA89A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inputType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)inputField.inputType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024148 RID: 147784 RVA: 0x00CAA7FC File Offset: 0x00CA89FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inputType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.InputType inputType;
			LuaObject.checkEnum<InputField.InputType>(l, 2, out inputType);
			inputField.inputType = inputType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024149 RID: 147785 RVA: 0x00CAA854 File Offset: 0x00CA8A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keyboardType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)inputField.keyboardType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414A RID: 147786 RVA: 0x00CAA8A8 File Offset: 0x00CA8AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_keyboardType(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			TouchScreenKeyboardType keyboardType;
			LuaObject.checkEnum<TouchScreenKeyboardType>(l, 2, out keyboardType);
			inputField.keyboardType = keyboardType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414B RID: 147787 RVA: 0x00CAA900 File Offset: 0x00CA8B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_characterValidation(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)inputField.characterValidation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414C RID: 147788 RVA: 0x00CAA954 File Offset: 0x00CA8B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_characterValidation(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			InputField.CharacterValidation characterValidation;
			LuaObject.checkEnum<InputField.CharacterValidation>(l, 2, out characterValidation);
			inputField.characterValidation = characterValidation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414D RID: 147789 RVA: 0x00CAA9AC File Offset: 0x00CA8BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_readOnly(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.readOnly);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414E RID: 147790 RVA: 0x00CAAA00 File Offset: 0x00CA8C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_readOnly(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			bool readOnly;
			LuaObject.checkType(l, 2, out readOnly);
			inputField.readOnly = readOnly;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602414F RID: 147791 RVA: 0x00CAAA58 File Offset: 0x00CA8C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_multiLine(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.multiLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024150 RID: 147792 RVA: 0x00CAAAAC File Offset: 0x00CA8CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_asteriskChar(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.asteriskChar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024151 RID: 147793 RVA: 0x00CAAB00 File Offset: 0x00CA8D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_asteriskChar(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			char asteriskChar;
			LuaObject.checkType(l, 2, out asteriskChar);
			inputField.asteriskChar = asteriskChar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024152 RID: 147794 RVA: 0x00CAAB58 File Offset: 0x00CA8D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wasCanceled(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.wasCanceled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024153 RID: 147795 RVA: 0x00CAABAC File Offset: 0x00CA8DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_caretPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.caretPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024154 RID: 147796 RVA: 0x00CAAC00 File Offset: 0x00CA8E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_caretPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			int caretPosition;
			LuaObject.checkType(l, 2, out caretPosition);
			inputField.caretPosition = caretPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024155 RID: 147797 RVA: 0x00CAAC58 File Offset: 0x00CA8E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectionAnchorPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.selectionAnchorPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024156 RID: 147798 RVA: 0x00CAACAC File Offset: 0x00CA8EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectionAnchorPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			int selectionAnchorPosition;
			LuaObject.checkType(l, 2, out selectionAnchorPosition);
			inputField.selectionAnchorPosition = selectionAnchorPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024157 RID: 147799 RVA: 0x00CAAD04 File Offset: 0x00CA8F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectionFocusPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.selectionFocusPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024158 RID: 147800 RVA: 0x00CAAD58 File Offset: 0x00CA8F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectionFocusPosition(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			int selectionFocusPosition;
			LuaObject.checkType(l, 2, out selectionFocusPosition);
			inputField.selectionFocusPosition = selectionFocusPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024159 RID: 147801 RVA: 0x00CAADB0 File Offset: 0x00CA8FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415A RID: 147802 RVA: 0x00CAAE04 File Offset: 0x00CA9004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415B RID: 147803 RVA: 0x00CAAE58 File Offset: 0x00CA9058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415C RID: 147804 RVA: 0x00CAAEAC File Offset: 0x00CA90AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415D RID: 147805 RVA: 0x00CAAF00 File Offset: 0x00CA9100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415E RID: 147806 RVA: 0x00CAAF54 File Offset: 0x00CA9154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602415F RID: 147807 RVA: 0x00CAAFA8 File Offset: 0x00CA91A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			InputField inputField = (InputField)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputField.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024160 RID: 147808 RVA: 0x00CAAFFC File Offset: 0x00CA91FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.InputField");
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.MoveTextEnd);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.MoveTextStart);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.ProcessEvent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnUpdateSelected);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.ForceLabelUpdate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_InputField.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheA);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_InputField.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheB);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_InputField.ActivateInputField);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheC);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnSelect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheD);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheE);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_InputField.DeactivateInputField);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cacheF);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnDeselect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache10);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache11);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache12);
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_InputField.<>f__mg$cache13);
		string name = "shouldHideMobileInput";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_shouldHideMobileInput);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_InputField.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_shouldHideMobileInput);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_InputField.<>f__mg$cache15, true);
		string name2 = "text";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_text);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_InputField.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_text);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_InputField.<>f__mg$cache17, true);
		string name3 = "isFocused";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_isFocused);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_UI_InputField.<>f__mg$cache18, null, true);
		string name4 = "caretBlinkRate";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_caretBlinkRate);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_InputField.<>f__mg$cache19;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_caretBlinkRate);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_UI_InputField.<>f__mg$cache1A, true);
		string name5 = "caretWidth";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_caretWidth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_InputField.<>f__mg$cache1B;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_caretWidth);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_UI_InputField.<>f__mg$cache1C, true);
		string name6 = "textComponent";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_textComponent);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_InputField.<>f__mg$cache1D;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_textComponent);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_UI_InputField.<>f__mg$cache1E, true);
		string name7 = "placeholder";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_placeholder);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_InputField.<>f__mg$cache1F;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_placeholder);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_UI_InputField.<>f__mg$cache20, true);
		string name8 = "caretColor";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_caretColor);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_InputField.<>f__mg$cache21;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_caretColor);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_UI_InputField.<>f__mg$cache22, true);
		string name9 = "customCaretColor";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_customCaretColor);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_InputField.<>f__mg$cache23;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_customCaretColor);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_UI_InputField.<>f__mg$cache24, true);
		string name10 = "selectionColor";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_selectionColor);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_InputField.<>f__mg$cache25;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_selectionColor);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_UI_InputField.<>f__mg$cache26, true);
		string name11 = "onEndEdit";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_onEndEdit);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_InputField.<>f__mg$cache27;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_onEndEdit);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_UI_InputField.<>f__mg$cache28, true);
		string name12 = "onValueChanged";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_onValueChanged);
		}
		LuaCSFunction get11 = Lua_UnityEngine_UI_InputField.<>f__mg$cache29;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_onValueChanged);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_UI_InputField.<>f__mg$cache2A, true);
		string name13 = "onValidateInput";
		LuaCSFunction get12 = null;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_onValidateInput);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_UI_InputField.<>f__mg$cache2B, true);
		string name14 = "characterLimit";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_characterLimit);
		}
		LuaCSFunction get13 = Lua_UnityEngine_UI_InputField.<>f__mg$cache2C;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_characterLimit);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_UI_InputField.<>f__mg$cache2D, true);
		string name15 = "contentType";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_contentType);
		}
		LuaCSFunction get14 = Lua_UnityEngine_UI_InputField.<>f__mg$cache2E;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_contentType);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_UI_InputField.<>f__mg$cache2F, true);
		string name16 = "lineType";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_lineType);
		}
		LuaCSFunction get15 = Lua_UnityEngine_UI_InputField.<>f__mg$cache30;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_lineType);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_UI_InputField.<>f__mg$cache31, true);
		string name17 = "inputType";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_inputType);
		}
		LuaCSFunction get16 = Lua_UnityEngine_UI_InputField.<>f__mg$cache32;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_inputType);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_UI_InputField.<>f__mg$cache33, true);
		string name18 = "keyboardType";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_keyboardType);
		}
		LuaCSFunction get17 = Lua_UnityEngine_UI_InputField.<>f__mg$cache34;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_keyboardType);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_UI_InputField.<>f__mg$cache35, true);
		string name19 = "characterValidation";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_characterValidation);
		}
		LuaCSFunction get18 = Lua_UnityEngine_UI_InputField.<>f__mg$cache36;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_characterValidation);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_UI_InputField.<>f__mg$cache37, true);
		string name20 = "readOnly";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_readOnly);
		}
		LuaCSFunction get19 = Lua_UnityEngine_UI_InputField.<>f__mg$cache38;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_readOnly);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_UI_InputField.<>f__mg$cache39, true);
		string name21 = "multiLine";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_multiLine);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_UI_InputField.<>f__mg$cache3A, null, true);
		string name22 = "asteriskChar";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_asteriskChar);
		}
		LuaCSFunction get20 = Lua_UnityEngine_UI_InputField.<>f__mg$cache3B;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_asteriskChar);
		}
		LuaObject.addMember(l, name22, get20, Lua_UnityEngine_UI_InputField.<>f__mg$cache3C, true);
		string name23 = "wasCanceled";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_wasCanceled);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_UI_InputField.<>f__mg$cache3D, null, true);
		string name24 = "caretPosition";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_caretPosition);
		}
		LuaCSFunction get21 = Lua_UnityEngine_UI_InputField.<>f__mg$cache3E;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_caretPosition);
		}
		LuaObject.addMember(l, name24, get21, Lua_UnityEngine_UI_InputField.<>f__mg$cache3F, true);
		string name25 = "selectionAnchorPosition";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_selectionAnchorPosition);
		}
		LuaCSFunction get22 = Lua_UnityEngine_UI_InputField.<>f__mg$cache40;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_selectionAnchorPosition);
		}
		LuaObject.addMember(l, name25, get22, Lua_UnityEngine_UI_InputField.<>f__mg$cache41, true);
		string name26 = "selectionFocusPosition";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_selectionFocusPosition);
		}
		LuaCSFunction get23 = Lua_UnityEngine_UI_InputField.<>f__mg$cache42;
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.set_selectionFocusPosition);
		}
		LuaObject.addMember(l, name26, get23, Lua_UnityEngine_UI_InputField.<>f__mg$cache43, true);
		string name27 = "minWidth";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache44 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache44 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_minWidth);
		}
		LuaObject.addMember(l, name27, Lua_UnityEngine_UI_InputField.<>f__mg$cache44, null, true);
		string name28 = "preferredWidth";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache45 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache45 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_preferredWidth);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_UI_InputField.<>f__mg$cache45, null, true);
		string name29 = "flexibleWidth";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache46 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache46 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_flexibleWidth);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_UI_InputField.<>f__mg$cache46, null, true);
		string name30 = "minHeight";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache47 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache47 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_minHeight);
		}
		LuaObject.addMember(l, name30, Lua_UnityEngine_UI_InputField.<>f__mg$cache47, null, true);
		string name31 = "preferredHeight";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache48 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache48 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_preferredHeight);
		}
		LuaObject.addMember(l, name31, Lua_UnityEngine_UI_InputField.<>f__mg$cache48, null, true);
		string name32 = "flexibleHeight";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache49 == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache49 = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_flexibleHeight);
		}
		LuaObject.addMember(l, name32, Lua_UnityEngine_UI_InputField.<>f__mg$cache49, null, true);
		string name33 = "layoutPriority";
		if (Lua_UnityEngine_UI_InputField.<>f__mg$cache4A == null)
		{
			Lua_UnityEngine_UI_InputField.<>f__mg$cache4A = new LuaCSFunction(Lua_UnityEngine_UI_InputField.get_layoutPriority);
		}
		LuaObject.addMember(l, name33, Lua_UnityEngine_UI_InputField.<>f__mg$cache4A, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(InputField), typeof(Selectable));
	}

	// Token: 0x04019CF5 RID: 105717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CF6 RID: 105718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CF7 RID: 105719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CF8 RID: 105720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CF9 RID: 105721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019CFA RID: 105722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019CFB RID: 105723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019CFC RID: 105724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019CFD RID: 105725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019CFE RID: 105726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019CFF RID: 105727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019D00 RID: 105728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019D01 RID: 105729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019D02 RID: 105730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019D03 RID: 105731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019D04 RID: 105732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019D05 RID: 105733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019D06 RID: 105734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019D07 RID: 105735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019D08 RID: 105736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019D09 RID: 105737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019D0A RID: 105738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019D0B RID: 105739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019D0C RID: 105740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019D0D RID: 105741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019D0E RID: 105742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019D0F RID: 105743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019D10 RID: 105744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019D11 RID: 105745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019D12 RID: 105746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019D13 RID: 105747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019D14 RID: 105748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019D15 RID: 105749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019D16 RID: 105750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019D17 RID: 105751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019D18 RID: 105752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019D19 RID: 105753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019D1A RID: 105754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019D1B RID: 105755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019D1C RID: 105756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019D1D RID: 105757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019D1E RID: 105758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019D1F RID: 105759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019D20 RID: 105760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019D21 RID: 105761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019D22 RID: 105762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019D23 RID: 105763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019D24 RID: 105764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019D25 RID: 105765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019D26 RID: 105766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019D27 RID: 105767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019D28 RID: 105768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019D29 RID: 105769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019D2A RID: 105770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019D2B RID: 105771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019D2C RID: 105772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019D2D RID: 105773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019D2E RID: 105774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019D2F RID: 105775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019D30 RID: 105776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019D31 RID: 105777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019D32 RID: 105778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04019D33 RID: 105779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04019D34 RID: 105780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04019D35 RID: 105781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04019D36 RID: 105782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04019D37 RID: 105783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04019D38 RID: 105784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04019D39 RID: 105785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04019D3A RID: 105786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04019D3B RID: 105787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04019D3C RID: 105788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04019D3D RID: 105789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04019D3E RID: 105790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04019D3F RID: 105791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;
}
