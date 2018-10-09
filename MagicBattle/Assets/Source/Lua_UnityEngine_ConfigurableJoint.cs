using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001673 RID: 5747
[Preserve]
public class Lua_UnityEngine_ConfigurableJoint : LuaObject
{
	// Token: 0x06022F3A RID: 143162 RVA: 0x00C181F0 File Offset: 0x00C163F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_secondaryAxis(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.secondaryAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F3B RID: 143163 RVA: 0x00C18244 File Offset: 0x00C16444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_secondaryAxis(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			Vector3 secondaryAxis;
			LuaObject.checkType(l, 2, out secondaryAxis);
			configurableJoint.secondaryAxis = secondaryAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F3C RID: 143164 RVA: 0x00C1829C File Offset: 0x00C1649C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.xMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F3D RID: 143165 RVA: 0x00C182F0 File Offset: 0x00C164F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion xMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out xMotion);
			configurableJoint.xMotion = xMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F3E RID: 143166 RVA: 0x00C18348 File Offset: 0x00C16548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.yMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F3F RID: 143167 RVA: 0x00C1839C File Offset: 0x00C1659C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion yMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out yMotion);
			configurableJoint.yMotion = yMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F40 RID: 143168 RVA: 0x00C183F4 File Offset: 0x00C165F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.zMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F41 RID: 143169 RVA: 0x00C18448 File Offset: 0x00C16648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion zMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out zMotion);
			configurableJoint.zMotion = zMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F42 RID: 143170 RVA: 0x00C184A0 File Offset: 0x00C166A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularXMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.angularXMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F43 RID: 143171 RVA: 0x00C184F4 File Offset: 0x00C166F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularXMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion angularXMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out angularXMotion);
			configurableJoint.angularXMotion = angularXMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F44 RID: 143172 RVA: 0x00C1854C File Offset: 0x00C1674C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularYMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.angularYMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F45 RID: 143173 RVA: 0x00C185A0 File Offset: 0x00C167A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularYMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion angularYMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out angularYMotion);
			configurableJoint.angularYMotion = angularYMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F46 RID: 143174 RVA: 0x00C185F8 File Offset: 0x00C167F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularZMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.angularZMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F47 RID: 143175 RVA: 0x00C1864C File Offset: 0x00C1684C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularZMotion(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			ConfigurableJointMotion angularZMotion;
			LuaObject.checkEnum<ConfigurableJointMotion>(l, 2, out angularZMotion);
			configurableJoint.angularZMotion = angularZMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F48 RID: 143176 RVA: 0x00C186A4 File Offset: 0x00C168A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.linearLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F49 RID: 143177 RVA: 0x00C186FC File Offset: 0x00C168FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_linearLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimitSpring linearLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 2, out linearLimitSpring);
			configurableJoint.linearLimitSpring = linearLimitSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4A RID: 143178 RVA: 0x00C18754 File Offset: 0x00C16954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularXLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularXLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4B RID: 143179 RVA: 0x00C187AC File Offset: 0x00C169AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularXLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimitSpring angularXLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 2, out angularXLimitSpring);
			configurableJoint.angularXLimitSpring = angularXLimitSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4C RID: 143180 RVA: 0x00C18804 File Offset: 0x00C16A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularYZLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularYZLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4D RID: 143181 RVA: 0x00C1885C File Offset: 0x00C16A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularYZLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimitSpring angularYZLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 2, out angularYZLimitSpring);
			configurableJoint.angularYZLimitSpring = angularYZLimitSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4E RID: 143182 RVA: 0x00C188B4 File Offset: 0x00C16AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.linearLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F4F RID: 143183 RVA: 0x00C1890C File Offset: 0x00C16B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_linearLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimit linearLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out linearLimit);
			configurableJoint.linearLimit = linearLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F50 RID: 143184 RVA: 0x00C18964 File Offset: 0x00C16B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lowAngularXLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.lowAngularXLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F51 RID: 143185 RVA: 0x00C189BC File Offset: 0x00C16BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lowAngularXLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimit lowAngularXLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out lowAngularXLimit);
			configurableJoint.lowAngularXLimit = lowAngularXLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F52 RID: 143186 RVA: 0x00C18A14 File Offset: 0x00C16C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_highAngularXLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.highAngularXLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F53 RID: 143187 RVA: 0x00C18A6C File Offset: 0x00C16C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_highAngularXLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimit highAngularXLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out highAngularXLimit);
			configurableJoint.highAngularXLimit = highAngularXLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F54 RID: 143188 RVA: 0x00C18AC4 File Offset: 0x00C16CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularYLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularYLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F55 RID: 143189 RVA: 0x00C18B1C File Offset: 0x00C16D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularYLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimit angularYLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out angularYLimit);
			configurableJoint.angularYLimit = angularYLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F56 RID: 143190 RVA: 0x00C18B74 File Offset: 0x00C16D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularZLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularZLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F57 RID: 143191 RVA: 0x00C18BCC File Offset: 0x00C16DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularZLimit(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			SoftJointLimit angularZLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out angularZLimit);
			configurableJoint.angularZLimit = angularZLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F58 RID: 143192 RVA: 0x00C18C24 File Offset: 0x00C16E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F59 RID: 143193 RVA: 0x00C18C78 File Offset: 0x00C16E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			Vector3 targetPosition;
			LuaObject.checkType(l, 2, out targetPosition);
			configurableJoint.targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5A RID: 143194 RVA: 0x00C18CD0 File Offset: 0x00C16ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetVelocity(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.targetVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5B RID: 143195 RVA: 0x00C18D24 File Offset: 0x00C16F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetVelocity(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			Vector3 targetVelocity;
			LuaObject.checkType(l, 2, out targetVelocity);
			configurableJoint.targetVelocity = targetVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5C RID: 143196 RVA: 0x00C18D7C File Offset: 0x00C16F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_xDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.xDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5D RID: 143197 RVA: 0x00C18DD4 File Offset: 0x00C16FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_xDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive xDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out xDrive);
			configurableJoint.xDrive = xDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5E RID: 143198 RVA: 0x00C18E2C File Offset: 0x00C1702C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.yDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F5F RID: 143199 RVA: 0x00C18E84 File Offset: 0x00C17084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_yDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive yDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out yDrive);
			configurableJoint.yDrive = yDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F60 RID: 143200 RVA: 0x00C18EDC File Offset: 0x00C170DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.zDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F61 RID: 143201 RVA: 0x00C18F34 File Offset: 0x00C17134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive zDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out zDrive);
			configurableJoint.zDrive = zDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F62 RID: 143202 RVA: 0x00C18F8C File Offset: 0x00C1718C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetRotation(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.targetRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F63 RID: 143203 RVA: 0x00C18FE0 File Offset: 0x00C171E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetRotation(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			Quaternion targetRotation;
			LuaObject.checkType(l, 2, out targetRotation);
			configurableJoint.targetRotation = targetRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F64 RID: 143204 RVA: 0x00C19038 File Offset: 0x00C17238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetAngularVelocity(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.targetAngularVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F65 RID: 143205 RVA: 0x00C1908C File Offset: 0x00C1728C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetAngularVelocity(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			Vector3 targetAngularVelocity;
			LuaObject.checkType(l, 2, out targetAngularVelocity);
			configurableJoint.targetAngularVelocity = targetAngularVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F66 RID: 143206 RVA: 0x00C190E4 File Offset: 0x00C172E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotationDriveMode(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.rotationDriveMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F67 RID: 143207 RVA: 0x00C19138 File Offset: 0x00C17338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotationDriveMode(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			RotationDriveMode rotationDriveMode;
			LuaObject.checkEnum<RotationDriveMode>(l, 2, out rotationDriveMode);
			configurableJoint.rotationDriveMode = rotationDriveMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F68 RID: 143208 RVA: 0x00C19190 File Offset: 0x00C17390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularXDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularXDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F69 RID: 143209 RVA: 0x00C191E8 File Offset: 0x00C173E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularXDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive angularXDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out angularXDrive);
			configurableJoint.angularXDrive = angularXDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6A RID: 143210 RVA: 0x00C19240 File Offset: 0x00C17440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularYZDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.angularYZDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6B RID: 143211 RVA: 0x00C19298 File Offset: 0x00C17498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularYZDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive angularYZDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out angularYZDrive);
			configurableJoint.angularYZDrive = angularYZDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6C RID: 143212 RVA: 0x00C192F0 File Offset: 0x00C174F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_slerpDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.slerpDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6D RID: 143213 RVA: 0x00C19348 File Offset: 0x00C17548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_slerpDrive(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointDrive slerpDrive;
			LuaObject.checkValueType<JointDrive>(l, 2, out slerpDrive);
			configurableJoint.slerpDrive = slerpDrive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6E RID: 143214 RVA: 0x00C193A0 File Offset: 0x00C175A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionMode(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configurableJoint.projectionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F6F RID: 143215 RVA: 0x00C193F4 File Offset: 0x00C175F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionMode(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			JointProjectionMode projectionMode;
			LuaObject.checkEnum<JointProjectionMode>(l, 2, out projectionMode);
			configurableJoint.projectionMode = projectionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F70 RID: 143216 RVA: 0x00C1944C File Offset: 0x00C1764C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.projectionDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F71 RID: 143217 RVA: 0x00C194A0 File Offset: 0x00C176A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			float projectionDistance;
			LuaObject.checkType(l, 2, out projectionDistance);
			configurableJoint.projectionDistance = projectionDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F72 RID: 143218 RVA: 0x00C194F8 File Offset: 0x00C176F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionAngle(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.projectionAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F73 RID: 143219 RVA: 0x00C1954C File Offset: 0x00C1774C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionAngle(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			float projectionAngle;
			LuaObject.checkType(l, 2, out projectionAngle);
			configurableJoint.projectionAngle = projectionAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F74 RID: 143220 RVA: 0x00C195A4 File Offset: 0x00C177A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_configuredInWorldSpace(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.configuredInWorldSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F75 RID: 143221 RVA: 0x00C195F8 File Offset: 0x00C177F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_configuredInWorldSpace(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			bool configuredInWorldSpace;
			LuaObject.checkType(l, 2, out configuredInWorldSpace);
			configurableJoint.configuredInWorldSpace = configuredInWorldSpace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F76 RID: 143222 RVA: 0x00C19650 File Offset: 0x00C17850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_swapBodies(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configurableJoint.swapBodies);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F77 RID: 143223 RVA: 0x00C196A4 File Offset: 0x00C178A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_swapBodies(IntPtr l)
	{
		int result;
		try
		{
			ConfigurableJoint configurableJoint = (ConfigurableJoint)LuaObject.checkSelf(l);
			bool swapBodies;
			LuaObject.checkType(l, 2, out swapBodies);
			configurableJoint.swapBodies = swapBodies;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F78 RID: 143224 RVA: 0x00C196FC File Offset: 0x00C178FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ConfigurableJoint");
		string name = "secondaryAxis";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_secondaryAxis);
		}
		LuaCSFunction get = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache0;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_secondaryAxis);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1, true);
		string name2 = "xMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_xMotion);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_xMotion);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3, true);
		string name3 = "yMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_yMotion);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache4;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_yMotion);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache5, true);
		string name4 = "zMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_zMotion);
		}
		LuaCSFunction get4 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache6;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_zMotion);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache7, true);
		string name5 = "angularXMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularXMotion);
		}
		LuaCSFunction get5 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache8;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularXMotion);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache9, true);
		string name6 = "angularYMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularYMotion);
		}
		LuaCSFunction get6 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheA;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularYMotion);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheB, true);
		string name7 = "angularZMotion";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularZMotion);
		}
		LuaCSFunction get7 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheC;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularZMotion);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheD, true);
		string name8 = "linearLimitSpring";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_linearLimitSpring);
		}
		LuaCSFunction get8 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheE;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_linearLimitSpring);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cacheF, true);
		string name9 = "angularXLimitSpring";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularXLimitSpring);
		}
		LuaCSFunction get9 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache10;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularXLimitSpring);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache11, true);
		string name10 = "angularYZLimitSpring";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularYZLimitSpring);
		}
		LuaCSFunction get10 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache12;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularYZLimitSpring);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache13, true);
		string name11 = "linearLimit";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_linearLimit);
		}
		LuaCSFunction get11 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache14;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_linearLimit);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache15, true);
		string name12 = "lowAngularXLimit";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_lowAngularXLimit);
		}
		LuaCSFunction get12 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache16;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_lowAngularXLimit);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache17, true);
		string name13 = "highAngularXLimit";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_highAngularXLimit);
		}
		LuaCSFunction get13 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache18;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_highAngularXLimit);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache19, true);
		string name14 = "angularYLimit";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularYLimit);
		}
		LuaCSFunction get14 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1A;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularYLimit);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1B, true);
		string name15 = "angularZLimit";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularZLimit);
		}
		LuaCSFunction get15 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1C;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularZLimit);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1D, true);
		string name16 = "targetPosition";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_targetPosition);
		}
		LuaCSFunction get16 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1E;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_targetPosition);
		}
		LuaObject.addMember(l, name16, get16, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache1F, true);
		string name17 = "targetVelocity";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_targetVelocity);
		}
		LuaCSFunction get17 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache20;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_targetVelocity);
		}
		LuaObject.addMember(l, name17, get17, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache21, true);
		string name18 = "xDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_xDrive);
		}
		LuaCSFunction get18 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache22;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_xDrive);
		}
		LuaObject.addMember(l, name18, get18, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache23, true);
		string name19 = "yDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_yDrive);
		}
		LuaCSFunction get19 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache24;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_yDrive);
		}
		LuaObject.addMember(l, name19, get19, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache25, true);
		string name20 = "zDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_zDrive);
		}
		LuaCSFunction get20 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache26;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_zDrive);
		}
		LuaObject.addMember(l, name20, get20, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache27, true);
		string name21 = "targetRotation";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_targetRotation);
		}
		LuaCSFunction get21 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache28;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_targetRotation);
		}
		LuaObject.addMember(l, name21, get21, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache29, true);
		string name22 = "targetAngularVelocity";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_targetAngularVelocity);
		}
		LuaCSFunction get22 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2A;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_targetAngularVelocity);
		}
		LuaObject.addMember(l, name22, get22, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2B, true);
		string name23 = "rotationDriveMode";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_rotationDriveMode);
		}
		LuaCSFunction get23 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2C;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_rotationDriveMode);
		}
		LuaObject.addMember(l, name23, get23, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2D, true);
		string name24 = "angularXDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularXDrive);
		}
		LuaCSFunction get24 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2E;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularXDrive);
		}
		LuaObject.addMember(l, name24, get24, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache2F, true);
		string name25 = "angularYZDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_angularYZDrive);
		}
		LuaCSFunction get25 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache30;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_angularYZDrive);
		}
		LuaObject.addMember(l, name25, get25, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache31, true);
		string name26 = "slerpDrive";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_slerpDrive);
		}
		LuaCSFunction get26 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache32;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_slerpDrive);
		}
		LuaObject.addMember(l, name26, get26, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache33, true);
		string name27 = "projectionMode";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_projectionMode);
		}
		LuaCSFunction get27 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache34;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_projectionMode);
		}
		LuaObject.addMember(l, name27, get27, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache35, true);
		string name28 = "projectionDistance";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_projectionDistance);
		}
		LuaCSFunction get28 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache36;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_projectionDistance);
		}
		LuaObject.addMember(l, name28, get28, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache37, true);
		string name29 = "projectionAngle";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_projectionAngle);
		}
		LuaCSFunction get29 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache38;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_projectionAngle);
		}
		LuaObject.addMember(l, name29, get29, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache39, true);
		string name30 = "configuredInWorldSpace";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_configuredInWorldSpace);
		}
		LuaCSFunction get30 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3A;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_configuredInWorldSpace);
		}
		LuaObject.addMember(l, name30, get30, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3B, true);
		string name31 = "swapBodies";
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.get_swapBodies);
		}
		LuaCSFunction get31 = Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3C;
		if (Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_ConfigurableJoint.set_swapBodies);
		}
		LuaObject.addMember(l, name31, get31, Lua_UnityEngine_ConfigurableJoint.<>f__mg$cache3D, true);
		LuaObject.createTypeMetatable(l, null, typeof(ConfigurableJoint), typeof(Joint));
	}

	// Token: 0x04018EB2 RID: 102066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018EB3 RID: 102067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018EB4 RID: 102068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018EB5 RID: 102069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018EB6 RID: 102070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018EB7 RID: 102071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018EB8 RID: 102072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018EB9 RID: 102073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018EBA RID: 102074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018EBB RID: 102075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018EBC RID: 102076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018EBD RID: 102077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018EBE RID: 102078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018EBF RID: 102079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018EC0 RID: 102080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018EC1 RID: 102081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018EC2 RID: 102082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018EC3 RID: 102083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018EC4 RID: 102084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018EC5 RID: 102085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018EC6 RID: 102086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018EC7 RID: 102087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018EC8 RID: 102088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018EC9 RID: 102089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018ECA RID: 102090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018ECB RID: 102091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018ECC RID: 102092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018ECD RID: 102093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018ECE RID: 102094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018ECF RID: 102095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018ED0 RID: 102096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018ED1 RID: 102097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018ED2 RID: 102098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018ED3 RID: 102099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018ED4 RID: 102100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018ED5 RID: 102101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018ED6 RID: 102102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018ED7 RID: 102103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018ED8 RID: 102104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018ED9 RID: 102105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018EDA RID: 102106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018EDB RID: 102107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018EDC RID: 102108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018EDD RID: 102109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018EDE RID: 102110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018EDF RID: 102111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018EE0 RID: 102112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018EE1 RID: 102113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018EE2 RID: 102114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018EE3 RID: 102115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018EE4 RID: 102116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018EE5 RID: 102117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018EE6 RID: 102118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018EE7 RID: 102119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018EE8 RID: 102120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018EE9 RID: 102121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018EEA RID: 102122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018EEB RID: 102123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04018EEC RID: 102124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04018EED RID: 102125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04018EEE RID: 102126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018EEF RID: 102127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;
}
