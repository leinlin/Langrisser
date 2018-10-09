using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001834 RID: 6196
[Preserve]
public class Lua_UnityEngine_UI_Image : LuaObject
{
	// Token: 0x060240D5 RID: 147669 RVA: 0x00CA7FC8 File Offset: 0x00CA61C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeforeSerialize(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			image.OnBeforeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240D6 RID: 147670 RVA: 0x00CA8014 File Offset: 0x00CA6214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAfterDeserialize(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			image.OnAfterDeserialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240D7 RID: 147671 RVA: 0x00CA8060 File Offset: 0x00CA6260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNativeSize(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			image.SetNativeSize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240D8 RID: 147672 RVA: 0x00CA80AC File Offset: 0x00CA62AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			image.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240D9 RID: 147673 RVA: 0x00CA80F8 File Offset: 0x00CA62F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			image.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DA RID: 147674 RVA: 0x00CA8144 File Offset: 0x00CA6344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaycastLocationValid(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Vector2 screenPoint;
			LuaObject.checkType(l, 2, out screenPoint);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = image.IsRaycastLocationValid(screenPoint, eventCamera);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DB RID: 147675 RVA: 0x00CA81B4 File Offset: 0x00CA63B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sprite(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.sprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DC RID: 147676 RVA: 0x00CA8208 File Offset: 0x00CA6408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sprite(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 2, out sprite);
			image.sprite = sprite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DD RID: 147677 RVA: 0x00CA8260 File Offset: 0x00CA6460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_overrideSprite(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.overrideSprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DE RID: 147678 RVA: 0x00CA82B4 File Offset: 0x00CA64B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_overrideSprite(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Sprite overrideSprite;
			LuaObject.checkType<Sprite>(l, 2, out overrideSprite);
			image.overrideSprite = overrideSprite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240DF RID: 147679 RVA: 0x00CA830C File Offset: 0x00CA650C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_type(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)image.type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E0 RID: 147680 RVA: 0x00CA8360 File Offset: 0x00CA6560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_type(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Image.Type type;
			LuaObject.checkEnum<Image.Type>(l, 2, out type);
			image.type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E1 RID: 147681 RVA: 0x00CA83B8 File Offset: 0x00CA65B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preserveAspect(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.preserveAspect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E2 RID: 147682 RVA: 0x00CA840C File Offset: 0x00CA660C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_preserveAspect(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			bool preserveAspect;
			LuaObject.checkType(l, 2, out preserveAspect);
			image.preserveAspect = preserveAspect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E3 RID: 147683 RVA: 0x00CA8464 File Offset: 0x00CA6664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillCenter(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.fillCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E4 RID: 147684 RVA: 0x00CA84B8 File Offset: 0x00CA66B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillCenter(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			bool fillCenter;
			LuaObject.checkType(l, 2, out fillCenter);
			image.fillCenter = fillCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E5 RID: 147685 RVA: 0x00CA8510 File Offset: 0x00CA6710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillMethod(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)image.fillMethod);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E6 RID: 147686 RVA: 0x00CA8564 File Offset: 0x00CA6764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillMethod(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Image.FillMethod fillMethod;
			LuaObject.checkEnum<Image.FillMethod>(l, 2, out fillMethod);
			image.fillMethod = fillMethod;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E7 RID: 147687 RVA: 0x00CA85BC File Offset: 0x00CA67BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillAmount(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.fillAmount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E8 RID: 147688 RVA: 0x00CA8610 File Offset: 0x00CA6810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillAmount(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			float fillAmount;
			LuaObject.checkType(l, 2, out fillAmount);
			image.fillAmount = fillAmount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240E9 RID: 147689 RVA: 0x00CA8668 File Offset: 0x00CA6868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillClockwise(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.fillClockwise);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240EA RID: 147690 RVA: 0x00CA86BC File Offset: 0x00CA68BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillClockwise(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			bool fillClockwise;
			LuaObject.checkType(l, 2, out fillClockwise);
			image.fillClockwise = fillClockwise;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240EB RID: 147691 RVA: 0x00CA8714 File Offset: 0x00CA6914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fillOrigin(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.fillOrigin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240EC RID: 147692 RVA: 0x00CA8768 File Offset: 0x00CA6968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fillOrigin(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			int fillOrigin;
			LuaObject.checkType(l, 2, out fillOrigin);
			image.fillOrigin = fillOrigin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240ED RID: 147693 RVA: 0x00CA87C0 File Offset: 0x00CA69C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alphaHitTestMinimumThreshold(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.alphaHitTestMinimumThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240EE RID: 147694 RVA: 0x00CA8814 File Offset: 0x00CA6A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alphaHitTestMinimumThreshold(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			float alphaHitTestMinimumThreshold;
			LuaObject.checkType(l, 2, out alphaHitTestMinimumThreshold);
			image.alphaHitTestMinimumThreshold = alphaHitTestMinimumThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240EF RID: 147695 RVA: 0x00CA886C File Offset: 0x00CA6A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultETC1GraphicMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Image.defaultETC1GraphicMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F0 RID: 147696 RVA: 0x00CA88B4 File Offset: 0x00CA6AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.mainTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F1 RID: 147697 RVA: 0x00CA8908 File Offset: 0x00CA6B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasBorder(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.hasBorder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F2 RID: 147698 RVA: 0x00CA895C File Offset: 0x00CA6B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.pixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F3 RID: 147699 RVA: 0x00CA89B0 File Offset: 0x00CA6BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F4 RID: 147700 RVA: 0x00CA8A04 File Offset: 0x00CA6C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			image.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F5 RID: 147701 RVA: 0x00CA8A5C File Offset: 0x00CA6C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F6 RID: 147702 RVA: 0x00CA8AB0 File Offset: 0x00CA6CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F7 RID: 147703 RVA: 0x00CA8B04 File Offset: 0x00CA6D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F8 RID: 147704 RVA: 0x00CA8B58 File Offset: 0x00CA6D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240F9 RID: 147705 RVA: 0x00CA8BAC File Offset: 0x00CA6DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240FA RID: 147706 RVA: 0x00CA8C00 File Offset: 0x00CA6E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240FB RID: 147707 RVA: 0x00CA8C54 File Offset: 0x00CA6E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			Image image = (Image)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, image.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240FC RID: 147708 RVA: 0x00CA8CA8 File Offset: 0x00CA6EA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Image");
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Image.OnBeforeSerialize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Image.OnAfterDeserialize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Image.SetNativeSize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Image.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Image.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Image.IsRaycastLocationValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Image.<>f__mg$cache5);
		string name = "sprite";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_sprite);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Image.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_sprite);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Image.<>f__mg$cache7, true);
		string name2 = "overrideSprite";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_overrideSprite);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Image.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_overrideSprite);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Image.<>f__mg$cache9, true);
		string name3 = "type";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_type);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Image.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_type);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Image.<>f__mg$cacheB, true);
		string name4 = "preserveAspect";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_preserveAspect);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Image.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_preserveAspect);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Image.<>f__mg$cacheD, true);
		string name5 = "fillCenter";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_fillCenter);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Image.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_fillCenter);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Image.<>f__mg$cacheF, true);
		string name6 = "fillMethod";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_fillMethod);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_Image.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_fillMethod);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_Image.<>f__mg$cache11, true);
		string name7 = "fillAmount";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_fillAmount);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_Image.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_fillAmount);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_Image.<>f__mg$cache13, true);
		string name8 = "fillClockwise";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_fillClockwise);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_Image.<>f__mg$cache14;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_fillClockwise);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_Image.<>f__mg$cache15, true);
		string name9 = "fillOrigin";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_fillOrigin);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_Image.<>f__mg$cache16;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_fillOrigin);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_UI_Image.<>f__mg$cache17, true);
		string name10 = "alphaHitTestMinimumThreshold";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_alphaHitTestMinimumThreshold);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_Image.<>f__mg$cache18;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_alphaHitTestMinimumThreshold);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_UI_Image.<>f__mg$cache19, true);
		string name11 = "defaultETC1GraphicMaterial";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_defaultETC1GraphicMaterial);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_UI_Image.<>f__mg$cache1A, null, false);
		string name12 = "mainTexture";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_mainTexture);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_UI_Image.<>f__mg$cache1B, null, true);
		string name13 = "hasBorder";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_hasBorder);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_UI_Image.<>f__mg$cache1C, null, true);
		string name14 = "pixelsPerUnit";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_pixelsPerUnit);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_UI_Image.<>f__mg$cache1D, null, true);
		string name15 = "material";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_material);
		}
		LuaCSFunction get11 = Lua_UnityEngine_UI_Image.<>f__mg$cache1E;
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_UI_Image.set_material);
		}
		LuaObject.addMember(l, name15, get11, Lua_UnityEngine_UI_Image.<>f__mg$cache1F, true);
		string name16 = "minWidth";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_minWidth);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_UI_Image.<>f__mg$cache20, null, true);
		string name17 = "preferredWidth";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_preferredWidth);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_UI_Image.<>f__mg$cache21, null, true);
		string name18 = "flexibleWidth";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_flexibleWidth);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_UI_Image.<>f__mg$cache22, null, true);
		string name19 = "minHeight";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_minHeight);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_UI_Image.<>f__mg$cache23, null, true);
		string name20 = "preferredHeight";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_preferredHeight);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_UI_Image.<>f__mg$cache24, null, true);
		string name21 = "flexibleHeight";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_flexibleHeight);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_UI_Image.<>f__mg$cache25, null, true);
		string name22 = "layoutPriority";
		if (Lua_UnityEngine_UI_Image.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_UI_Image.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_UI_Image.get_layoutPriority);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_UI_Image.<>f__mg$cache26, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Image), typeof(MaskableGraphic));
	}

	// Token: 0x04019CCB RID: 105675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CCC RID: 105676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CCD RID: 105677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CCE RID: 105678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CCF RID: 105679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019CD0 RID: 105680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019CD1 RID: 105681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019CD2 RID: 105682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019CD3 RID: 105683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019CD4 RID: 105684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019CD5 RID: 105685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019CD6 RID: 105686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019CD7 RID: 105687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019CD8 RID: 105688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019CD9 RID: 105689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019CDA RID: 105690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019CDB RID: 105691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019CDC RID: 105692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019CDD RID: 105693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019CDE RID: 105694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019CDF RID: 105695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019CE0 RID: 105696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019CE1 RID: 105697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019CE2 RID: 105698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019CE3 RID: 105699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019CE4 RID: 105700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019CE5 RID: 105701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019CE6 RID: 105702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019CE7 RID: 105703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019CE8 RID: 105704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019CE9 RID: 105705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019CEA RID: 105706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019CEB RID: 105707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019CEC RID: 105708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019CED RID: 105709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019CEE RID: 105710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019CEF RID: 105711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019CF0 RID: 105712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019CF1 RID: 105713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
