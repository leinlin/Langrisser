using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.CommonDefine;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001297 RID: 4759
[Preserve]
public class Lua_BlackJack_ProjectL_CommonDefine_ErrorCode : LuaObject
{
	// Token: 0x06018CB5 RID: 101557 RVA: 0x007055B4 File Offset: 0x007037B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ErrorCode o = new ErrorCode();
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

	// Token: 0x06018CB6 RID: 101558 RVA: 0x007055FC File Offset: 0x007037FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeOk(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB7 RID: 101559 RVA: 0x00705640 File Offset: 0x00703840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnknow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, int.MinValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB8 RID: 101560 RVA: 0x00705688 File Offset: 0x00703888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeNeedCreateCharacter(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB9 RID: 101561 RVA: 0x007056CC File Offset: 0x007038CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerNameInvalid(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBA RID: 101562 RVA: 0x00705710 File Offset: 0x00703910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerNameRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBB RID: 101563 RVA: 0x00705754 File Offset: 0x00703954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerNameLengthAboveMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBC RID: 101564 RVA: 0x00705798 File Offset: 0x00703998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerNameIsIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBD RID: 101565 RVA: 0x007057DC File Offset: 0x007039DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerSave2DBOperationFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBE RID: 101566 RVA: 0x00705820 File Offset: 0x00703A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNameIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -7);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CBF RID: 101567 RVA: 0x00705864 File Offset: 0x00703A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -8);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC0 RID: 101568 RVA: 0x007058A8 File Offset: 0x00703AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNameEmptyNotAllowed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -9);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC1 RID: 101569 RVA: 0x007058EC File Offset: 0x00703AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOrderHasDelivered(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC2 RID: 101570 RVA: 0x00705930 File Offset: 0x00703B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeWrite2DBFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -11);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC3 RID: 101571 RVA: 0x00705974 File Offset: 0x00703B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRMBStoreTypeNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -12);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC4 RID: 101572 RVA: 0x007059B8 File Offset: 0x00703BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotHasThisHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -13);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC5 RID: 101573 RVA: 0x007059FC File Offset: 0x00703BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeIsSameHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -14);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC6 RID: 101574 RVA: 0x00705A40 File Offset: 0x00703C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeWritePlayerData2DBFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -15);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC7 RID: 101575 RVA: 0x00705A84 File Offset: 0x00703C84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeErrorOrder(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -16);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC8 RID: 101576 RVA: 0x00705AC8 File Offset: 0x00703CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOrderduplicate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -17);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CC9 RID: 101577 RVA: 0x00705B0C File Offset: 0x00703D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNetworkError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -99);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCA RID: 101578 RVA: 0x00705B50 File Offset: 0x00703D50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGMMessageError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCB RID: 101579 RVA: 0x00705B98 File Offset: 0x00703D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGMOptionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -301);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCC RID: 101580 RVA: 0x00705BE0 File Offset: 0x00703DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGMOptionDataError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -302);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCD RID: 101581 RVA: 0x00705C28 File Offset: 0x00703E28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGMOptionDataNotDigit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -303);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCE RID: 101582 RVA: 0x00705C70 File Offset: 0x00703E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroIdNotExistOrHeroExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -304);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CCF RID: 101583 RVA: 0x00705CB8 File Offset: 0x00703EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroIdNotExistOrHeroNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -305);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD0 RID: 101584 RVA: 0x00705D00 File Offset: 0x00703F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFlushConfigFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -306);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD1 RID: 101585 RVA: 0x00705D48 File Offset: 0x00703F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerIsOffLine(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -307);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD2 RID: 101586 RVA: 0x00705D90 File Offset: 0x00703F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGMOperationDataNotDateTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -308);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD3 RID: 101587 RVA: 0x00705DD8 File Offset: 0x00703FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAdvertisementFlowLayoutIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -309);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD4 RID: 101588 RVA: 0x00705E20 File Offset: 0x00704020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAdvertisementFlowLayoutActivityNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -310);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD5 RID: 101589 RVA: 0x00705E68 File Offset: 0x00704068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeInstanceItemNumsAboveBagCapacity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -311);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD6 RID: 101590 RVA: 0x00705EB0 File Offset: 0x007040B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerListIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -312);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD7 RID: 101591 RVA: 0x00705EF8 File Offset: 0x007040F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUserGuideListIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -313);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD8 RID: 101592 RVA: 0x00705F40 File Offset: 0x00704140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGoldNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CD9 RID: 101593 RVA: 0x00705F88 File Offset: 0x00704188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -401);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDA RID: 101594 RVA: 0x00705FD0 File Offset: 0x007041D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeEnergyNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -402);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDB RID: 101595 RVA: 0x00706018 File Offset: 0x00704218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGoodsTypeIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -403);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDC RID: 101596 RVA: 0x00706060 File Offset: 0x00704260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCurrencyNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -404);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDD RID: 101597 RVA: 0x007060A8 File Offset: 0x007042A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerLevelExpIsMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -405);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDE RID: 101598 RVA: 0x007060F0 File Offset: 0x007042F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerRepeatSign(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -406);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CDF RID: 101599 RVA: 0x00706138 File Offset: 0x00704338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSignRewardConfigNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -407);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE0 RID: 101600 RVA: 0x00706180 File Offset: 0x00704380
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBuyEngryConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -408);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE1 RID: 101601 RVA: 0x007061C8 File Offset: 0x007043C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaHonourNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -409);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE2 RID: 101602 RVA: 0x00706210 File Offset: 0x00704410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBuyArenaTickrtConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -410);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE3 RID: 101603 RVA: 0x00706258 File Offset: 0x00704458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuideStepIdOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -411);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE4 RID: 101604 RVA: 0x007062A0 File Offset: 0x007044A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChangedNameEqualToCurrentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -412);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE5 RID: 101605 RVA: 0x007062E8 File Offset: 0x007044E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -413);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE6 RID: 101606 RVA: 0x00706330 File Offset: 0x00704530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBuyEnergyNumsUsedOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -414);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE7 RID: 101607 RVA: 0x00706378 File Offset: 0x00704578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRealTimePVPHonorNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -415);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE8 RID: 101608 RVA: 0x007063C0 File Offset: 0x007045C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSkinTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -416);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CE9 RID: 101609 RVA: 0x00706408 File Offset: 0x00704608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendShipPointsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -417);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CEA RID: 101610 RVA: 0x00706450 File Offset: 0x00704650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUserGuideNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -418);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CEB RID: 101611 RVA: 0x00706498 File Offset: 0x00704698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMemoryEssenceNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -419);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CEC RID: 101612 RVA: 0x007064E0 File Offset: 0x007046E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBrillianceMithralStoneNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -420);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CED RID: 101613 RVA: 0x00706528 File Offset: 0x00704728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMithralStoneNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -421);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CEE RID: 101614 RVA: 0x00706570 File Offset: 0x00704770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGoldOverFlow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -422);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CEF RID: 101615 RVA: 0x007065B8 File Offset: 0x007047B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeExchangeGiftCDKeyGoodsNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -423);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF0 RID: 101616 RVA: 0x00706600 File Offset: 0x00704800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeExchangeGiftCDKeyGoodsParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -424);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF1 RID: 101617 RVA: 0x00706648 File Offset: 0x00704848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagCapcityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF2 RID: 101618 RVA: 0x00706690 File Offset: 0x00704890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -501);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF3 RID: 101619 RVA: 0x007066D8 File Offset: 0x007048D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -502);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF4 RID: 101620 RVA: 0x00706720 File Offset: 0x00704920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -503);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF5 RID: 101621 RVA: 0x00706768 File Offset: 0x00704968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemJobMaterialIdNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -504);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF6 RID: 101622 RVA: 0x007067B0 File Offset: 0x007049B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemItemIdNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -505);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF7 RID: 101623 RVA: 0x007067F8 File Offset: 0x007049F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemItemCanNotUse(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -506);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF8 RID: 101624 RVA: 0x00706840 File Offset: 0x00704A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemTypeCanNotSell(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -507);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CF9 RID: 101625 RVA: 0x00706888 File Offset: 0x00704A88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemCreateError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -508);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFA RID: 101626 RVA: 0x007068D0 File Offset: 0x00704AD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemNotMatchGoodsType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -509);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFB RID: 101627 RVA: 0x00706918 File Offset: 0x00704B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEnhanceEquipmentMaterialOutofRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -510);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFC RID: 101628 RVA: 0x00706960 File Offset: 0x00704B60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemEquipmentLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -511);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFD RID: 101629 RVA: 0x007069A8 File Offset: 0x00704BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEnhanceEquipmentMaterialEnhanced(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -512);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFE RID: 101630 RVA: 0x007069F0 File Offset: 0x00704BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEnhanceEquipmentMaterialLevelUpStar(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -513);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CFF RID: 101631 RVA: 0x00706A38 File Offset: 0x00704C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEnhanceEquipmentLevelExpMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -514);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D00 RID: 101632 RVA: 0x00706A80 File Offset: 0x00704C80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemEnhanceEquipmentTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -515);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D01 RID: 101633 RVA: 0x00706AC8 File Offset: 0x00704CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemLevelUpStarEquipmentMatrialTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -516);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D02 RID: 101634 RVA: 0x00706B10 File Offset: 0x00704D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemEquipmentLevelUpStarRankDifferent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -517);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D03 RID: 101635 RVA: 0x00706B58 File Offset: 0x00704D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEquipmentLevelUpStarMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -518);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D04 RID: 101636 RVA: 0x00706BA0 File Offset: 0x00704DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEquipmentLevelUpLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -519);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D05 RID: 101637 RVA: 0x00706BE8 File Offset: 0x00704DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEquipmentAndMaterialIsSame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -520);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D06 RID: 101638 RVA: 0x00706C30 File Offset: 0x00704E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeIllegalUseBagItemNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -521);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D07 RID: 101639 RVA: 0x00706C78 File Offset: 0x00704E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemEquipmentIdNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -522);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D08 RID: 101640 RVA: 0x00706CC0 File Offset: 0x00704EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeConsumeItemNumsError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -523);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D09 RID: 101641 RVA: 0x00706D08 File Offset: 0x00704F08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeStarLeveUpEquipmentCannotEnhanceEquipment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -524);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0A RID: 101642 RVA: 0x00706D50 File Offset: 0x00704F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemStarLevelUpEquipmentTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -525);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0B RID: 101643 RVA: 0x00706D98 File Offset: 0x00704F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCannotEquipmentThisEquipment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -526);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0C RID: 101644 RVA: 0x00706DE0 File Offset: 0x00704FE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemCannotDecompose(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -527);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0D RID: 101645 RVA: 0x00706E28 File Offset: 0x00705028
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagItemNotStacking(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -528);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0E RID: 101646 RVA: 0x00706E70 File Offset: 0x00705070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotItemTypeCannotUse(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -529);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D0F RID: 101647 RVA: 0x00706EB8 File Offset: 0x007050B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFavorabilityExpItemNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -530);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D10 RID: 101648 RVA: 0x00706F00 File Offset: 0x00705100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeItemUseNumsError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -531);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D11 RID: 101649 RVA: 0x00706F48 File Offset: 0x00705148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBagItemSaveEnchantingEquipmentNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -532);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D12 RID: 101650 RVA: 0x00706F90 File Offset: 0x00705190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOpenBoxNumReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -533);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D13 RID: 101651 RVA: 0x00706FD8 File Offset: 0x007051D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeEnergyMedicineNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -534);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D14 RID: 101652 RVA: 0x00707020 File Offset: 0x00705220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAlchemyOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -535);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D15 RID: 101653 RVA: 0x00707068 File Offset: 0x00705268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeStaticBoxNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -536);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D16 RID: 101654 RVA: 0x007070B0 File Offset: 0x007052B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomBoxNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -537);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D17 RID: 101655 RVA: 0x007070F8 File Offset: 0x007052F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSelfSelectedBoxNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -538);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D18 RID: 101656 RVA: 0x00707140 File Offset: 0x00705340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSelfSelectedBoxItemIndexNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -539);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D19 RID: 101657 RVA: 0x00707188 File Offset: 0x00705388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotSelfSelectedBoxCanHaveIndexParm(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -540);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1A RID: 101658 RVA: 0x007071D0 File Offset: 0x007053D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobIsExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -600);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1B RID: 101659 RVA: 0x00707218 File Offset: 0x00705418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -601);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1C RID: 101660 RVA: 0x00707260 File Offset: 0x00705460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -602);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1D RID: 101661 RVA: 0x007072A8 File Offset: 0x007054A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -603);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1E RID: 101662 RVA: 0x007072F0 File Offset: 0x007054F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobMaterialRemoveError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -604);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D1F RID: 101663 RVA: 0x00707338 File Offset: 0x00705538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobMaterialSlotNotMatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -605);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D20 RID: 101664 RVA: 0x00707380 File Offset: 0x00705580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobMaterialHadEquiped(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -606);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D21 RID: 101665 RVA: 0x007073C8 File Offset: 0x007055C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobMaterialNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -607);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D22 RID: 101666 RVA: 0x00707410 File Offset: 0x00705610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBagNotHaveJobMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -608);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D23 RID: 101667 RVA: 0x00707458 File Offset: 0x00705658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSlotIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -609);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D24 RID: 101668 RVA: 0x007074A0 File Offset: 0x007056A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeLevelUpStarLevelConfigNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -610);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D25 RID: 101669 RVA: 0x007074E8 File Offset: 0x007056E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -611);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D26 RID: 101670 RVA: 0x00707530 File Offset: 0x00705730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJobLevelOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -612);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D27 RID: 101671 RVA: 0x00707578 File Offset: 0x00705778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJobIdNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -613);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D28 RID: 101672 RVA: 0x007075C0 File Offset: 0x007057C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJobRankError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -614);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D29 RID: 101673 RVA: 0x00707608 File Offset: 0x00705808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeJobRelatedIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -615);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2A RID: 101674 RVA: 0x00707650 File Offset: 0x00705850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJobLevelIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -616);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2B RID: 101675 RVA: 0x00707698 File Offset: 0x00705898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTransferJobRankOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -617);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2C RID: 101676 RVA: 0x007076E0 File Offset: 0x007058E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -618);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2D RID: 101677 RVA: 0x00707728 File Offset: 0x00705928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroNotHaveThisSoldier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -619);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2E RID: 101678 RVA: 0x00707770 File Offset: 0x00705970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroNotHaveThisSkill(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -620);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D2F RID: 101679 RVA: 0x007077B8 File Offset: 0x007059B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSkillIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -621);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D30 RID: 101680 RVA: 0x00707800 File Offset: 0x00705A00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMaterialNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -622);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D31 RID: 101681 RVA: 0x00707848 File Offset: 0x00705A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -623);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D32 RID: 101682 RVA: 0x00707890 File Offset: 0x00705A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroGetSkillEneryError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -624);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D33 RID: 101683 RVA: 0x007078D8 File Offset: 0x00705AD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroSkillEneryNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -625);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D34 RID: 101684 RVA: 0x00707920 File Offset: 0x00705B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroSlectedSkillCountOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -626);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D35 RID: 101685 RVA: 0x00707968 File Offset: 0x00705B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeComposeMaterialNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -627);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D36 RID: 101686 RVA: 0x007079B0 File Offset: 0x00705BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNoJobMaterialCanEquiped(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -628);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D37 RID: 101687 RVA: 0x007079F8 File Offset: 0x00705BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFragmentItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -629);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D38 RID: 101688 RVA: 0x00707A40 File Offset: 0x00705C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroStarLevelAboveHeroStarLevelMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -630);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D39 RID: 101689 RVA: 0x00707A88 File Offset: 0x00705C88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroExpIsFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -631);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3A RID: 101690 RVA: 0x00707AD0 File Offset: 0x00705CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSkillIdRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -632);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3B RID: 101691 RVA: 0x00707B18 File Offset: 0x00705D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobCannotTransferSelfJob(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -633);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3C RID: 101692 RVA: 0x00707B60 File Offset: 0x00705D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroTransferJobsNotContainThisJob(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -634);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3D RID: 101693 RVA: 0x00707BA8 File Offset: 0x00705DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroStarIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -635);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3E RID: 101694 RVA: 0x00707BF0 File Offset: 0x00705DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePreJobNotOPen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -636);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D3F RID: 101695 RVA: 0x00707C38 File Offset: 0x00705E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -637);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D40 RID: 101696 RVA: 0x00707C80 File Offset: 0x00705E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobRepeateUnlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -638);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D41 RID: 101697 RVA: 0x00707CC8 File Offset: 0x00705EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroJobUnlockItemCostNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -639);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D42 RID: 101698 RVA: 0x00707D10 File Offset: 0x00705F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobUnlockAcgievementsNotReach(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -640);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D43 RID: 101699 RVA: 0x00707D58 File Offset: 0x00705F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroJobNotNeedUnlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -641);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D44 RID: 101700 RVA: 0x00707DA0 File Offset: 0x00705FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePreHeroJobNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -642);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D45 RID: 101701 RVA: 0x00707DE8 File Offset: 0x00705FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCurrentJobCannotEquipThisSkill(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -643);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D46 RID: 101702 RVA: 0x00707E30 File Offset: 0x00706030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeProtagonistIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -644);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D47 RID: 101703 RVA: 0x00707E78 File Offset: 0x00706078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeProtagonistHasSetDown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -645);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D48 RID: 101704 RVA: 0x00707EC0 File Offset: 0x007060C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroEquipmentHasWeared(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -646);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D49 RID: 101705 RVA: 0x00707F08 File Offset: 0x00706108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroEquipmentSoldierNotmatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -647);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4A RID: 101706 RVA: 0x00707F50 File Offset: 0x00706150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroEquipmentJobNotmatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -648);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4B RID: 101707 RVA: 0x00707F98 File Offset: 0x00706198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroEquipmentHasNotWeared(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -649);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4C RID: 101708 RVA: 0x00707FE0 File Offset: 0x007061E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePreHeroJobNotMaster(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -650);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4D RID: 101709 RVA: 0x00708028 File Offset: 0x00706228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCannotWearThisTypeEquipment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -651);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4E RID: 101710 RVA: 0x00708070 File Offset: 0x00706270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFragmentNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -652);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D4F RID: 101711 RVA: 0x007080B8 File Offset: 0x007062B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAutoEquipmentTimeTooClose(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -653);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D50 RID: 101712 RVA: 0x00708100 File Offset: 0x00706300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAutoEquipmentDontUpdate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -654);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D51 RID: 101713 RVA: 0x00708148 File Offset: 0x00706348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeProtagonistHeroCannotAddFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -655);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D52 RID: 101714 RVA: 0x00708190 File Offset: 0x00706390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFavorabilityExpIsFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -656);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D53 RID: 101715 RVA: 0x007081D8 File Offset: 0x007063D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroInformationNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -657);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D54 RID: 101716 RVA: 0x00708220 File Offset: 0x00706420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockHeroFetterFavorabilityLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -658);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D55 RID: 101717 RVA: 0x00708268 File Offset: 0x00706468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockMissionNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -659);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D56 RID: 101718 RVA: 0x007082B0 File Offset: 0x007064B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockFetterConditionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -660);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D57 RID: 101719 RVA: 0x007082F8 File Offset: 0x007064F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroFetterLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -661);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D58 RID: 101720 RVA: 0x00708340 File Offset: 0x00706540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroNotHaveThisFetter(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -662);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D59 RID: 101721 RVA: 0x00708388 File Offset: 0x00706588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroRepeatedlyUnlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -663);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5A RID: 101722 RVA: 0x007083D0 File Offset: 0x007065D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFetterLevelReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -664);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5B RID: 101723 RVA: 0x00708418 File Offset: 0x00706618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroPerformanceIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -665);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5C RID: 101724 RVA: 0x00708460 File Offset: 0x00706660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockHeroPerformanceFavorabilityLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -666);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5D RID: 101725 RVA: 0x007084A8 File Offset: 0x007066A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockHeroPerformanceConditionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -667);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5E RID: 101726 RVA: 0x007084F0 File Offset: 0x007066F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroBiographyIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -668);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D5F RID: 101727 RVA: 0x00708538 File Offset: 0x00706738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockHeroBiographyFavorabilityLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -669);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D60 RID: 101728 RVA: 0x00708580 File Offset: 0x00706780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockHeroBiographyConditionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -670);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D61 RID: 101729 RVA: 0x007085C8 File Offset: 0x007067C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroConfessRepeatedly(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -671);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D62 RID: 101730 RVA: 0x00708610 File Offset: 0x00706810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFetterLevelNotReachConfessLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -672);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D63 RID: 101731 RVA: 0x00708658 File Offset: 0x00706858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroConfessionIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -673);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D64 RID: 101732 RVA: 0x007086A0 File Offset: 0x007068A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeProtagonistHeroCannotBeConfessed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -674);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D65 RID: 101733 RVA: 0x007086E8 File Offset: 0x007068E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroInteractNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -675);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D66 RID: 101734 RVA: 0x00708730 File Offset: 0x00706930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroInteractIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -676);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D67 RID: 101735 RVA: 0x00708778 File Offset: 0x00706978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroInteractBigUpResultNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -677);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D68 RID: 101736 RVA: 0x007087C0 File Offset: 0x007069C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroInteractResultConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -678);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D69 RID: 101737 RVA: 0x00708808 File Offset: 0x00706A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroJobNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -679);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6A RID: 101738 RVA: 0x00708850 File Offset: 0x00706A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotExistExtralHeroFragement(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -680);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6B RID: 101739 RVA: 0x00708898 File Offset: 0x00706A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeScenarioIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -700);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6C RID: 101740 RVA: 0x007088E0 File Offset: 0x00706AE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockScenarioPlayerLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -701);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6D RID: 101741 RVA: 0x00708928 File Offset: 0x00706B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockScenarioRiftProgressNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -702);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6E RID: 101742 RVA: 0x00708970 File Offset: 0x00706B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeScenarioStageIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -703);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D6F RID: 101743 RVA: 0x007089B8 File Offset: 0x00706BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNextScenarioIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -704);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D70 RID: 101744 RVA: 0x00708A00 File Offset: 0x00706C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeWayPointIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -705);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D71 RID: 101745 RVA: 0x00708A48 File Offset: 0x00706C48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeWayPointHaveScenario(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -706);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D72 RID: 101746 RVA: 0x00708A90 File Offset: 0x00706C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCanNotMoveToThisWayPoint(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -707);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D73 RID: 101747 RVA: 0x00708AD8 File Offset: 0x00706CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeWayPointHaveEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -708);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D74 RID: 101748 RVA: 0x00708B20 File Offset: 0x00706D20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTreasureIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -709);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D75 RID: 101749 RVA: 0x00708B68 File Offset: 0x00706D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeWayPointEventIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -710);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D76 RID: 101750 RVA: 0x00708BB0 File Offset: 0x00706DB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotHaveFight(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -711);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D77 RID: 101751 RVA: 0x00708BF8 File Offset: 0x00706DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeEventFunctionTypeNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -712);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D78 RID: 101752 RVA: 0x00708C40 File Offset: 0x00706E40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnlockScenarioNotCompleteRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -713);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D79 RID: 101753 RVA: 0x00708C88 File Offset: 0x00706E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomEventOperationNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -714);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7A RID: 101754 RVA: 0x00708CD0 File Offset: 0x00706ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAboveMapRandomEventMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -715);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7B RID: 101755 RVA: 0x00708D18 File Offset: 0x00706F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActionRandomEventComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -716);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7C RID: 101756 RVA: 0x00708D60 File Offset: 0x00706F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomEventIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -717);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7D RID: 101757 RVA: 0x00708DA8 File Offset: 0x00706FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotHaveWayPointPlaceRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -718);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7E RID: 101758 RVA: 0x00708DF0 File Offset: 0x00706FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeScenarioChapterNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -719);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D7F RID: 101759 RVA: 0x00708E38 File Offset: 0x00707038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftLevelUnlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -800);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D80 RID: 101760 RVA: 0x00708E80 File Offset: 0x00707080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftLevelAttackNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -801);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D81 RID: 101761 RVA: 0x00708EC8 File Offset: 0x007070C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelRaidStarNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -802);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D82 RID: 101762 RVA: 0x00708F10 File Offset: 0x00707110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelRaidParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -803);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D83 RID: 101763 RVA: 0x00708F58 File Offset: 0x00707158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelHasGainChapterReward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -804);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D84 RID: 101764 RVA: 0x00708FA0 File Offset: 0x007071A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftChapterIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -805);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D85 RID: 101765 RVA: 0x00708FE8 File Offset: 0x007071E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftChapterPlayerLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -806);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D86 RID: 101766 RVA: 0x00709030 File Offset: 0x00707230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftChapterScenarioProcessNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -807);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D87 RID: 101767 RVA: 0x00709078 File Offset: 0x00707278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -808);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D88 RID: 101768 RVA: 0x007090C0 File Offset: 0x007072C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePreRiftLevelNotCompleted(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -809);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D89 RID: 101769 RVA: 0x00709108 File Offset: 0x00707308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotHaveThisAchievement(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -810);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8A RID: 101770 RVA: 0x00709150 File Offset: 0x00707350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotHaveThisHero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 811);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8B RID: 101771 RVA: 0x00709198 File Offset: 0x00707398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockChapterParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -812);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8C RID: 101772 RVA: 0x007091E0 File Offset: 0x007073E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockRiftLevelParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -813);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8D RID: 101773 RVA: 0x00709228 File Offset: 0x00707428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftGainChapterRewardStarNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -814);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8E RID: 101774 RVA: 0x00709270 File Offset: 0x00707470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftGainChapterRewardIndexError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -815);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D8F RID: 101775 RVA: 0x007092B8 File Offset: 0x007074B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -816);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D90 RID: 101776 RVA: 0x00709300 File Offset: 0x00707500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotHaveUnlockedChapter(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -817);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D91 RID: 101777 RVA: 0x00709348 File Offset: 0x00707548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftLevelNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -818);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D92 RID: 101778 RVA: 0x00709390 File Offset: 0x00707590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftLevelPlayerLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -819);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D93 RID: 101779 RVA: 0x007093D8 File Offset: 0x007075D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftLevelRelatedAchievementIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -820);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D94 RID: 101780 RVA: 0x00709420 File Offset: 0x00707620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeLevelRaidTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -821);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D95 RID: 101781 RVA: 0x00709468 File Offset: 0x00707668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChapterStarNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -822);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D96 RID: 101782 RVA: 0x007094B0 File Offset: 0x007076B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftAchievementRepeatelyComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -823);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D97 RID: 101783 RVA: 0x007094F8 File Offset: 0x007076F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -824);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D98 RID: 101784 RVA: 0x00709540 File Offset: 0x00707740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftGainChapterIndexParmOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -825);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D99 RID: 101785 RVA: 0x00709588 File Offset: 0x00707788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftChapterNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -826);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9A RID: 101786 RVA: 0x007095D0 File Offset: 0x007077D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleAttackIsFighting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -900);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9B RID: 101787 RVA: 0x00709618 File Offset: 0x00707818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleFinishedIsNotFighting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -901);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9C RID: 101788 RVA: 0x00709660 File Offset: 0x00707860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleAttacklWayPointNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -902);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9D RID: 101789 RVA: 0x007096A8 File Offset: 0x007078A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleAttackRiftLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -903);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9E RID: 101790 RVA: 0x007096F0 File Offset: 0x007078F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleCancelIsNotFighting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -904);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018D9F RID: 101791 RVA: 0x00709738 File Offset: 0x00707938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -905);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA0 RID: 101792 RVA: 0x00709780 File Offset: 0x00707980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrorCodeBattleReportError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -906);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA1 RID: 101793 RVA: 0x007097C8 File Offset: 0x007079C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeBattleHeroesNumsOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -907);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA2 RID: 101794 RVA: 0x00709810 File Offset: 0x00707A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeBattleHeroPositionError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -908);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA3 RID: 101795 RVA: 0x00709858 File Offset: 0x00707A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeBattleCreatMapError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -909);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA4 RID: 101796 RVA: 0x007098A0 File Offset: 0x00707AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeBattleBattleReportError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -910);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA5 RID: 101797 RVA: 0x007098E8 File Offset: 0x00707AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeBattleInitError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -911);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA6 RID: 101798 RVA: 0x00709930 File Offset: 0x00707B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnknownBattle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -912);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA7 RID: 101799 RVA: 0x00709978 File Offset: 0x00707B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnknownBattleMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -913);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA8 RID: 101800 RVA: 0x007099C0 File Offset: 0x00707BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaBattleIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -914);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DA9 RID: 101801 RVA: 0x00709A08 File Offset: 0x00707C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -915);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAA RID: 101802 RVA: 0x00709A50 File Offset: 0x00707C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleAttackHeroDungeonLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -916);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAB RID: 101803 RVA: 0x00709A98 File Offset: 0x00707C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleActionPositionIndexOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -917);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAC RID: 101804 RVA: 0x00709AE0 File Offset: 0x00707CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleActionValueOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -918);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAD RID: 101805 RVA: 0x00709B28 File Offset: 0x00707D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomBattleArmyNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -919);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAE RID: 101806 RVA: 0x00709B70 File Offset: 0x00707D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomBattleArmyRoleWeightError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -920);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DAF RID: 101807 RVA: 0x00709BB8 File Offset: 0x00707DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeEventRiftLevelCannotBeRepeatedlyAttacked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -921);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB0 RID: 101808 RVA: 0x00709C00 File Offset: 0x00707E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNecessaryHeroNotInBattle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -922);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB1 RID: 101809 RVA: 0x00709C48 File Offset: 0x00707E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleAlreadyInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -923);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB2 RID: 101810 RVA: 0x00709C90 File Offset: 0x00707E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleRoomCreateBattleTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -924);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB3 RID: 101811 RVA: 0x00709CD8 File Offset: 0x00707ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleServerNetError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -925);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB4 RID: 101812 RVA: 0x00709D20 File Offset: 0x00707F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleNotFightingInBattleServer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -926);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB5 RID: 101813 RVA: 0x00709D68 File Offset: 0x00707F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleChangePlayerBattleStatusOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -927);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB6 RID: 101814 RVA: 0x00709DB0 File Offset: 0x00707FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleSetupHeroError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -928);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB7 RID: 101815 RVA: 0x00709DF8 File Offset: 0x00707FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleRoomNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -929);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB8 RID: 101816 RVA: 0x00709E40 File Offset: 0x00708040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleCommandError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -930);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DB9 RID: 101817 RVA: 0x00709E88 File Offset: 0x00708088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleRoomPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -931);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBA RID: 101818 RVA: 0x00709ED0 File Offset: 0x007080D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleRoomIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -932);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBB RID: 101819 RVA: 0x00709F18 File Offset: 0x00708118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleRoomHasSendActionBegin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -933);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBC RID: 101820 RVA: 0x00709F60 File Offset: 0x00708160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePVPBattleIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -934);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBD RID: 101821 RVA: 0x00709FA8 File Offset: 0x007081A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRealTimePVPBattleIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -935);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBE RID: 101822 RVA: 0x00709FF0 File Offset: 0x007081F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleRoomPutdownHeroError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -936);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DBF RID: 101823 RVA: 0x0070A038 File Offset: 0x00708238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBattleGuildMassiveCombatSetupHeroNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -937);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC0 RID: 101824 RVA: 0x0070A080 File Offset: 0x00708280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailIdRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC1 RID: 101825 RVA: 0x0070A0C8 File Offset: 0x007082C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC2 RID: 101826 RVA: 0x0070A110 File Offset: 0x00708310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMailHadRead(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC3 RID: 101827 RVA: 0x0070A158 File Offset: 0x00708358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailAttachmentHadGot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC4 RID: 101828 RVA: 0x0070A1A0 File Offset: 0x007083A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailIsExpired(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC5 RID: 101829 RVA: 0x0070A1E8 File Offset: 0x007083E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailTemplateIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1005);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC6 RID: 101830 RVA: 0x0070A230 File Offset: 0x00708430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotHaveMailExistAttachment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1006);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC7 RID: 101831 RVA: 0x0070A278 File Offset: 0x00708478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMailNotHaveAttachment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC8 RID: 101832 RVA: 0x0070A2C0 File Offset: 0x007084C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomStoreNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DC9 RID: 101833 RVA: 0x0070A308 File Offset: 0x00708508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomStoreBuyItemIndexOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1101);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCA RID: 101834 RVA: 0x0070A350 File Offset: 0x00708550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomStoreItemIsBought(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1102);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCB RID: 101835 RVA: 0x0070A398 File Offset: 0x00708598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomStoreIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1103);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCC RID: 101836 RVA: 0x0070A3E0 File Offset: 0x007085E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomStoreBuyItemStoreHasFlushed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCD RID: 101837 RVA: 0x0070A428 File Offset: 0x00708628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeManualFlushNumsUsedOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1105);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCE RID: 101838 RVA: 0x0070A470 File Offset: 0x00708670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomEventLevelConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DCF RID: 101839 RVA: 0x0070A4B8 File Offset: 0x007086B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDefiniteGroupRandomEventGroupNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1201);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD0 RID: 101840 RVA: 0x0070A500 File Offset: 0x00708700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeEventIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1202);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD1 RID: 101841 RVA: 0x0070A548 File Offset: 0x00708748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCurrentWayPointHaveUnfinishedRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1203);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD2 RID: 101842 RVA: 0x0070A590 File Offset: 0x00708790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomEventTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1204);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD3 RID: 101843 RVA: 0x0070A5D8 File Offset: 0x007087D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomEventGroupIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1205);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD4 RID: 101844 RVA: 0x0070A620 File Offset: 0x00708820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFixedStoreNotExistThisStore(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD5 RID: 101845 RVA: 0x0070A668 File Offset: 0x00708868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFixedStoreNotExistThisGoods(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1301);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD6 RID: 101846 RVA: 0x0070A6B0 File Offset: 0x007088B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFixedStoreThisGoodsHasSoldOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1302);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD7 RID: 101847 RVA: 0x0070A6F8 File Offset: 0x007088F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFixedStoreGoodsNotInSellTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1303);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD8 RID: 101848 RVA: 0x0070A740 File Offset: 0x00708940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatPlayerNotEnoughLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DD9 RID: 101849 RVA: 0x0070A788 File Offset: 0x00708988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatSendTooOften(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1401);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDA RID: 101850 RVA: 0x0070A7D0 File Offset: 0x007089D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatBanned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1402);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDB RID: 101851 RVA: 0x0070A818 File Offset: 0x00708A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatChannelNotPermission(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1403);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDC RID: 101852 RVA: 0x0070A860 File Offset: 0x00708A60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatPlayerOffline(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1404);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDD RID: 101853 RVA: 0x0070A8A8 File Offset: 0x00708AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatWorldChannelAllocRoomPlayerAlreadyInsideRoom(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1405);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDE RID: 101854 RVA: 0x0070A8F0 File Offset: 0x00708AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatWorldChannelAllocRoomAllRoomsFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1406);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DDF RID: 101855 RVA: 0x0070A938 File Offset: 0x00708B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatWorldChannelRemovePlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1407);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE0 RID: 101856 RVA: 0x0070A980 File Offset: 0x00708B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatWorldChannelEnterRoomSameTwice(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1408);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE1 RID: 101857 RVA: 0x0070A9C8 File Offset: 0x00708BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatWorldChannelEnterRoomFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1409);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE2 RID: 101858 RVA: 0x0070AA10 File Offset: 0x00708C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatWorldChannelEnterRoomIllegalRoomId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1410);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE3 RID: 101859 RVA: 0x0070AA58 File Offset: 0x00708C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatTeamChannelTeamRoomNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1411);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE4 RID: 101860 RVA: 0x0070AAA0 File Offset: 0x00708CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGroupChannelGroupNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1412);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE5 RID: 101861 RVA: 0x0070AAE8 File Offset: 0x00708CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGroupChannelPlayerNotBelongToGroup(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1413);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE6 RID: 101862 RVA: 0x0070AB30 File Offset: 0x00708D30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatVoiceContentTimeout(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1414);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE7 RID: 101863 RVA: 0x0070AB78 File Offset: 0x00708D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatPrivateChannelNotSelectTargetPlayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1415);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE8 RID: 101864 RVA: 0x0070ABC0 File Offset: 0x00708DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupChannelNotSelectTargetGroup(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1416);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DE9 RID: 101865 RVA: 0x0070AC08 File Offset: 0x00708E08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatPrivateChannelSrcPlayerBlockDestPlayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1417);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DEA RID: 101866 RVA: 0x0070AC50 File Offset: 0x00708E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatPrivateChannelDestPlayerBlockSrcPlayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1418);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DEB RID: 101867 RVA: 0x0070AC98 File Offset: 0x00708E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatWorldChannelServerBusy(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1419);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DEC RID: 101868 RVA: 0x0070ACE0 File Offset: 0x00708EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGuildChannelHaveNoGuild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1420);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DED RID: 101869 RVA: 0x0070AD28 File Offset: 0x00708F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActivityCardPoolNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DEE RID: 101870 RVA: 0x0070AD70 File Offset: 0x00708F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActivityCardPoolSelectCountUsedOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1501);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DEF RID: 101871 RVA: 0x0070ADB8 File Offset: 0x00708FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSelectCardTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1502);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF0 RID: 101872 RVA: 0x0070AE00 File Offset: 0x00709000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSelectCardPoolNotExistById(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1503);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF1 RID: 101873 RVA: 0x0070AE48 File Offset: 0x00709048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolCannotUseTenSelect(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1504);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF2 RID: 101874 RVA: 0x0070AE90 File Offset: 0x00709090
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSelectCardPoolCannotUseCrystal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1505);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF3 RID: 101875 RVA: 0x0070AED8 File Offset: 0x007090D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFreeCardPoolJustUseTicket(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1506);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF4 RID: 101876 RVA: 0x0070AF20 File Offset: 0x00709120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFreeCardJustCanUseTicketsTenSelect(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1507);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF5 RID: 101877 RVA: 0x0070AF68 File Offset: 0x00709168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUserGuidSelectCardStepHasCompleted(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1508);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF6 RID: 101878 RVA: 0x0070AFB0 File Offset: 0x007091B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSameGroupIdExistBetweenCrystalCardPoolGroupTableAndFreeCardPooGroupTable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1509);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF7 RID: 101879 RVA: 0x0070AFF8 File Offset: 0x007091F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndFreeCardPooGroupTable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1510);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF8 RID: 101880 RVA: 0x0070B040 File Offset: 0x00709240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndCrystalCardPooGroupTable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1511);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DF9 RID: 101881 RVA: 0x0070B088 File Offset: 0x00709288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUserGuideRepeatedCompleted(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1512);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFA RID: 101882 RVA: 0x0070B0D0 File Offset: 0x007092D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCrystalCardPoolJustCanUseTicket(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1513);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFB RID: 101883 RVA: 0x0070B118 File Offset: 0x00709318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCrstalCardPoolSelectConsumeMaterialNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1514);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFC RID: 101884 RVA: 0x0070B160 File Offset: 0x00709360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCrystalCardPoolUseTicketNotEnoughButCrystalEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1515);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFD RID: 101885 RVA: 0x0070B1A8 File Offset: 0x007093A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActivityCardPoolJustCanUseTicket(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1516);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFE RID: 101886 RVA: 0x0070B1F0 File Offset: 0x007093F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMissionIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1600);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018DFF RID: 101887 RVA: 0x0070B238 File Offset: 0x00709438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMissionNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1601);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E00 RID: 101888 RVA: 0x0070B280 File Offset: 0x00709480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMissionLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1602);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E01 RID: 101889 RVA: 0x0070B2C8 File Offset: 0x007094C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMissionNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1603);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E02 RID: 101890 RVA: 0x0070B310 File Offset: 0x00709510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMissionServerDataHasSync2Client(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1604);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E03 RID: 101891 RVA: 0x0070B358 File Offset: 0x00709558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMissionRewardHasGot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1605);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E04 RID: 101892 RVA: 0x0070B3A0 File Offset: 0x007095A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCommentHeroNumsIsMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1700);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E05 RID: 101893 RVA: 0x0070B3E8 File Offset: 0x007095E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCommentHeroNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1701);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E06 RID: 101894 RVA: 0x0070B430 File Offset: 0x00709630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCommentEntryHasPraised(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1702);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E07 RID: 101895 RVA: 0x0070B478 File Offset: 0x00709678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCommentPraiseEntryNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1703);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E08 RID: 101896 RVA: 0x0070B4C0 File Offset: 0x007096C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCommentViewCommenterHeroNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1704);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E09 RID: 101897 RVA: 0x0070B508 File Offset: 0x00709708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCommentBanned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1705);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0A RID: 101898 RVA: 0x0070B550 File Offset: 0x00709750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThearchyTrialNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1800);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0B RID: 101899 RVA: 0x0070B598 File Offset: 0x00709798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThearchyTrialLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1801);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0C RID: 101900 RVA: 0x0070B5E0 File Offset: 0x007097E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialLevelNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1802);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0D RID: 101901 RVA: 0x0070B628 File Offset: 0x00709828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialLevelPreLevelUnfinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1803);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0E RID: 101902 RVA: 0x0070B670 File Offset: 0x00709870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThearchyTrialChallengeNumsReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1804);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E0F RID: 101903 RVA: 0x0070B6B8 File Offset: 0x007098B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialLevelIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1805);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E10 RID: 101904 RVA: 0x0070B700 File Offset: 0x00709900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialChallengeCountUseOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1806);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E11 RID: 101905 RVA: 0x0070B748 File Offset: 0x00709948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1807);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E12 RID: 101906 RVA: 0x0070B790 File Offset: 0x00709990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThearchyTrialTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1808);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E13 RID: 101907 RVA: 0x0070B7D8 File Offset: 0x007099D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThearchyTrialFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1809);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E14 RID: 101908 RVA: 0x0070B820 File Offset: 0x00709A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1900);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E15 RID: 101909 RVA: 0x0070B868 File Offset: 0x00709A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAnikiGymLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1901);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E16 RID: 101910 RVA: 0x0070B8B0 File Offset: 0x00709AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAnikiGymLevelNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1902);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E17 RID: 101911 RVA: 0x0070B8F8 File Offset: 0x00709AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymlLevelPreLevelUnfinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1903);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E18 RID: 101912 RVA: 0x0070B940 File Offset: 0x00709B40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymChallengeNumsReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1904);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E19 RID: 101913 RVA: 0x0070B988 File Offset: 0x00709B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymLevelIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1905);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1A RID: 101914 RVA: 0x0070B9D0 File Offset: 0x00709BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAnikiGymChallengeCountUseOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1906);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1B RID: 101915 RVA: 0x0070BA18 File Offset: 0x00709C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAnikiGymLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1907);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1C RID: 101916 RVA: 0x0070BA60 File Offset: 0x00709C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1908);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1D RID: 101917 RVA: 0x0070BAA8 File Offset: 0x00709CA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1909);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1E RID: 101918 RVA: 0x0070BAF0 File Offset: 0x00709CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaNotEnoughTicket(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E1F RID: 101919 RVA: 0x0070BB38 File Offset: 0x00709D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaPlayerNotEnoughLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E20 RID: 101920 RVA: 0x0070BB80 File Offset: 0x00709D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaOpponentIndexOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E21 RID: 101921 RVA: 0x0070BBC8 File Offset: 0x00709DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaOpponentHasAttacked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E22 RID: 101922 RVA: 0x0070BC10 File Offset: 0x00709E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E23 RID: 101923 RVA: 0x0070BC58 File Offset: 0x00709E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaManualFlushTimeNotReached(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2005);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E24 RID: 101924 RVA: 0x0070BCA0 File Offset: 0x00709EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaAttackOpponentGetDefensiveTeamInfoFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2006);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E25 RID: 101925 RVA: 0x0070BCE8 File Offset: 0x00709EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaBattleReportNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E26 RID: 101926 RVA: 0x0070BD30 File Offset: 0x00709F30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaBattleTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2008);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E27 RID: 101927 RVA: 0x0070BD78 File Offset: 0x00709F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaNotExistHostility(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2009);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E28 RID: 101928 RVA: 0x0070BDC0 File Offset: 0x00709FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaRevengedOpponent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2010);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E29 RID: 101929 RVA: 0x0070BE08 File Offset: 0x0070A008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaReportBattleReportFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2011);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2A RID: 101930 RVA: 0x0070BE50 File Offset: 0x0070A050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaVictoryPointsRewardRepeatedlyGot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2012);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2B RID: 101931 RVA: 0x0070BE98 File Offset: 0x0070A098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaVictoryRewardIndexError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2013);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2C RID: 101932 RVA: 0x0070BEE0 File Offset: 0x0070A0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaVictoryPointsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2014);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2D RID: 101933 RVA: 0x0070BF28 File Offset: 0x0070A128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaIsNotFighting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2015);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2E RID: 101934 RVA: 0x0070BF70 File Offset: 0x0070A170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaOpponentHasNotAttacked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2016);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E2F RID: 101935 RVA: 0x0070BFB8 File Offset: 0x0070A1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaInSettleTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2017);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E30 RID: 101936 RVA: 0x0070C000 File Offset: 0x0070A200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaNotInReady(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2018);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E31 RID: 101937 RVA: 0x0070C048 File Offset: 0x0070A248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeArenaRevengeCheat(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2019);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E32 RID: 101938 RVA: 0x0070C090 File Offset: 0x0070A290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeArenaException(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2020);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E33 RID: 101939 RVA: 0x0070C0D8 File Offset: 0x0070A2D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAssistantTaskLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2101);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E34 RID: 101940 RVA: 0x0070C120 File Offset: 0x0070A320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantTaskNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2102);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E35 RID: 101941 RVA: 0x0070C168 File Offset: 0x0070A368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantHeroNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2103);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E36 RID: 101942 RVA: 0x0070C1B0 File Offset: 0x0070A3B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAssistantHeroAssigned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E37 RID: 101943 RVA: 0x0070C1F8 File Offset: 0x0070A3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantTaskInProcess(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2105);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E38 RID: 101944 RVA: 0x0070C240 File Offset: 0x0070A440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantHeroUnAssigned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2106);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E39 RID: 101945 RVA: 0x0070C288 File Offset: 0x0070A488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAssistantHeroTaskUnfinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2107);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3A RID: 101946 RVA: 0x0070C2D0 File Offset: 0x0070A4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantHeroTaskRewardsClaimed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2108);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3B RID: 101947 RVA: 0x0070C318 File Offset: 0x0070A518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAssistantHeroAssignCountMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2109);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3C RID: 101948 RVA: 0x0070C360 File Offset: 0x0070A560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantWorkHourTooShort(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2110);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3D RID: 101949 RVA: 0x0070C3A8 File Offset: 0x0070A5A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroAssistantNoHeroAssigned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2111);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3E RID: 101950 RVA: 0x0070C3F0 File Offset: 0x0070A5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroAssistantTaskAssignmentSlotFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2112);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E3F RID: 101951 RVA: 0x0070C438 File Offset: 0x0070A638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeLimitedTimeExchangeOperationalActivityNotExistThisItemExchanger(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E40 RID: 101952 RVA: 0x0070C480 File Offset: 0x0070A680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeLimitedTimeExchangeOperationalActivityThisItemExchangeTimesNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2201);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E41 RID: 101953 RVA: 0x0070C4C8 File Offset: 0x0070A6C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAwardOperationalActivityNotThisReward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2202);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E42 RID: 101954 RVA: 0x0070C510 File Offset: 0x0070A710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOperationalActivityRewardRepeatedlyGain(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2203);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E43 RID: 101955 RVA: 0x0070C558 File Offset: 0x0070A758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeThisOperationalActivityNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2204);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E44 RID: 101956 RVA: 0x0070C5A0 File Offset: 0x0070A7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotAwardOperationalActivityCannotGainReward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2205);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E45 RID: 101957 RVA: 0x0070C5E8 File Offset: 0x0070A7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOperationalActivityIsNotInOperationPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2206);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E46 RID: 101958 RVA: 0x0070C630 File Offset: 0x0070A830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAwardOperationalActivityCannotGainRewardInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2207);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E47 RID: 101959 RVA: 0x0070C678 File Offset: 0x0070A878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAwardOperationalActivityPlayerLevelIsTooLow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2208);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E48 RID: 101960 RVA: 0x0070C6C0 File Offset: 0x0070A8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAwardOperationalActivityNotLoginSpecificDays(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2209);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E49 RID: 101961 RVA: 0x0070C708 File Offset: 0x0070A908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAwardOperationalActivityNotReachAccumulateLoginDays(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2209);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4A RID: 101962 RVA: 0x0070C750 File Offset: 0x0070A950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAwardOperationalActivityRewardItemGroupIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2210);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4B RID: 101963 RVA: 0x0070C798 File Offset: 0x0070A998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAwardOperationalActivityGainRewardTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2211);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4C RID: 101964 RVA: 0x0070C7E0 File Offset: 0x0070A9E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotLimitedTimeExchangeOperationalActivityCanExchangeItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2212);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4D RID: 101965 RVA: 0x0070C828 File Offset: 0x0070AA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnknownOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2213);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4E RID: 101966 RVA: 0x0070C870 File Offset: 0x0070AA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErroCodeOperationalActivityTimeConflict(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2214);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E4F RID: 101967 RVA: 0x0070C8B8 File Offset: 0x0070AAB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnnouncementTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2215);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E50 RID: 101968 RVA: 0x0070C900 File Offset: 0x0070AB00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeOperactionalActivityTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2216);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E51 RID: 101969 RVA: 0x0070C948 File Offset: 0x0070AB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAnnouncementNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2217);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E52 RID: 101970 RVA: 0x0070C990 File Offset: 0x0070AB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRaffleItemsAllDrawd(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2218);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E53 RID: 101971 RVA: 0x0070C9D8 File Offset: 0x0070ABD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRaffleNotEnoughDrawItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2219);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E54 RID: 101972 RVA: 0x0070CA20 File Offset: 0x0070AC20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotRechargeEnoughRMB(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2220);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E55 RID: 101973 RVA: 0x0070CA68 File Offset: 0x0070AC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotConsumeEnoughCrystal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2221);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E56 RID: 101974 RVA: 0x0070CAB0 File Offset: 0x0070ACB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAddSameEffectOpaerationalActivity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2222);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E57 RID: 101975 RVA: 0x0070CAF8 File Offset: 0x0070ACF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOpeningServerActivityCannotUpdate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2223);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E58 RID: 101976 RVA: 0x0070CB40 File Offset: 0x0070AD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOperacitivityTimeParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2224);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E59 RID: 101977 RVA: 0x0070CB88 File Offset: 0x0070AD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGmPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5A RID: 101978 RVA: 0x0070CBD0 File Offset: 0x0070ADD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGmDecreaseMoneyNumsError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2401);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5B RID: 101979 RVA: 0x0070CC18 File Offset: 0x0070AE18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGmMoneyTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2402);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5C RID: 101980 RVA: 0x0070CC60 File Offset: 0x0070AE60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGmDecreaseGoodsTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2403);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5D RID: 101981 RVA: 0x0070CCA8 File Offset: 0x0070AEA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGmDecreaseGoodsNumsError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2404);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5E RID: 101982 RVA: 0x0070CCF0 File Offset: 0x0070AEF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGameFunctionIsLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2405);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E5F RID: 101983 RVA: 0x0070CD38 File Offset: 0x0070AF38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSurveyRewardRepeatedlyGain(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E60 RID: 101984 RVA: 0x0070CD80 File Offset: 0x0070AF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSurveyNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2501);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E61 RID: 101985 RVA: 0x0070CDC8 File Offset: 0x0070AFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSurveyNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2502);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E62 RID: 101986 RVA: 0x0070CE10 File Offset: 0x0070B010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRepeatedOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2503);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E63 RID: 101987 RVA: 0x0070CE58 File Offset: 0x0070B058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeWriteSurveyPlayerLevelNotEnought(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2504);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E64 RID: 101988 RVA: 0x0070CEA0 File Offset: 0x0070B0A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSurveyTimeConflict(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2505);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E65 RID: 101989 RVA: 0x0070CEE8 File Offset: 0x0070B0E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGlobalSurveyRepeatedlyAdd(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2506);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E66 RID: 101990 RVA: 0x0070CF30 File Offset: 0x0070B130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrorCodeTreasureMapNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2600);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E67 RID: 101991 RVA: 0x0070CF78 File Offset: 0x0070B178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTreasureLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2601);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E68 RID: 101992 RVA: 0x0070CFC0 File Offset: 0x0070B1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTreasureLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2602);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E69 RID: 101993 RVA: 0x0070D008 File Offset: 0x0070B208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeasureMapFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2603);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6A RID: 101994 RVA: 0x0070D050 File Offset: 0x0070B250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeDanmakuGameFunctionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2700);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6B RID: 101995 RVA: 0x0070D098 File Offset: 0x0070B298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDanmakuLocationIdNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2701);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6C RID: 101996 RVA: 0x0070D0E0 File Offset: 0x0070B2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDanmakuBattleTurnOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2702);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6D RID: 101997 RVA: 0x0070D128 File Offset: 0x0070B328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeDanmakuNotUniqueOrSorted(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2703);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6E RID: 101998 RVA: 0x0070D170 File Offset: 0x0070B370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrorCodeMemoryCorridorTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2800);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E6F RID: 101999 RVA: 0x0070D1B8 File Offset: 0x0070B3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMemoryCorridorLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2801);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E70 RID: 102000 RVA: 0x0070D200 File Offset: 0x0070B400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMemoryCorridorLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2802);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E71 RID: 102001 RVA: 0x0070D248 File Offset: 0x0070B448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMemoryCorridorLevelNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2803);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E72 RID: 102002 RVA: 0x0070D290 File Offset: 0x0070B490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMemoryCorridorNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2804);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E73 RID: 102003 RVA: 0x0070D2D8 File Offset: 0x0070B4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMemoryCorridorFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2805);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E74 RID: 102004 RVA: 0x0070D320 File Offset: 0x0070B520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDungeonLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2900);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E75 RID: 102005 RVA: 0x0070D368 File Offset: 0x0070B568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePreHeroDungeonLevelNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2901);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E76 RID: 102006 RVA: 0x0070D3B0 File Offset: 0x0070B5B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDungeonLevelUnlockConditionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2902);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E77 RID: 102007 RVA: 0x0070D3F8 File Offset: 0x0070B5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnlockHeroDungeonLevelHeroFavorabilityLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2903);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E78 RID: 102008 RVA: 0x0070D440 File Offset: 0x0070B640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDungeonLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2904);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E79 RID: 102009 RVA: 0x0070D488 File Offset: 0x0070B688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelAttackNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2905);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7A RID: 102010 RVA: 0x0070D4D0 File Offset: 0x0070B6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2906);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7B RID: 102011 RVA: 0x0070D518 File Offset: 0x0070B718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelStarNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2907);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7C RID: 102012 RVA: 0x0070D560 File Offset: 0x0070B760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonChapterNotAttack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2908);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7D RID: 102013 RVA: 0x0070D5A8 File Offset: 0x0070B7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelChapterIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2909);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7E RID: 102014 RVA: 0x0070D5F0 File Offset: 0x0070B7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGainHeroDungeonChapterStarRewardIndexError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2910);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E7F RID: 102015 RVA: 0x0070D638 File Offset: 0x0070B838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDungeonChapterStarsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2911);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E80 RID: 102016 RVA: 0x0070D680 File Offset: 0x0070B880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDungeonChapterStarRewardRepeatedlyGot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2912);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E81 RID: 102017 RVA: 0x0070D6C8 File Offset: 0x0070B8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelRaidParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2913);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E82 RID: 102018 RVA: 0x0070D710 File Offset: 0x0070B910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonFunctioinNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2914);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E83 RID: 102019 RVA: 0x0070D758 File Offset: 0x0070B958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonGainChapterIndexParmOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2915);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E84 RID: 102020 RVA: 0x0070D7A0 File Offset: 0x0070B9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroFetterFunctioinNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2916);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E85 RID: 102021 RVA: 0x0070D7E8 File Offset: 0x0070B9E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTodayChallengeNumsUsedOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2917);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E86 RID: 102022 RVA: 0x0070D830 File Offset: 0x0070BA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamGameFunctionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E87 RID: 102023 RVA: 0x0070D878 File Offset: 0x0070BA78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamLocationIdNotFinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E88 RID: 102024 RVA: 0x0070D8C0 File Offset: 0x0070BAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamLevelOutofRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E89 RID: 102025 RVA: 0x0070D908 File Offset: 0x0070BB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamMemberNumsIsFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8A RID: 102026 RVA: 0x0070D950 File Offset: 0x0070BB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamPlayerHasBeenJoined(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8B RID: 102027 RVA: 0x0070D998 File Offset: 0x0070BB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamTheyAreNotSocialRelation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3005);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8C RID: 102028 RVA: 0x0070D9E0 File Offset: 0x0070BBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamRoomNotPublic(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3006);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8D RID: 102029 RVA: 0x0070DA28 File Offset: 0x0070BC28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamLevelNotFinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8E RID: 102030 RVA: 0x0070DA70 File Offset: 0x0070BC70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamAlreadyInTeam(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3008);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E8F RID: 102031 RVA: 0x0070DAB8 File Offset: 0x0070BCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamServerNetError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3009);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E90 RID: 102032 RVA: 0x0070DB00 File Offset: 0x0070BD00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamRoomSettingAuthorityOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3010);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E91 RID: 102033 RVA: 0x0070DB48 File Offset: 0x0070BD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamRoomSettingLevelOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3011);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E92 RID: 102034 RVA: 0x0070DB90 File Offset: 0x0070BD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamViewTeamRoomGameFunctionTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3012);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E93 RID: 102035 RVA: 0x0070DBD8 File Offset: 0x0070BDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamCancelAutoMatchNotInWaiting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3013);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E94 RID: 102036 RVA: 0x0070DC20 File Offset: 0x0070BE20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamNotInRoom(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3014);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E95 RID: 102037 RVA: 0x0070DC68 File Offset: 0x0070BE68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamChangeAuthorityNotLeader(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3015);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E96 RID: 102038 RVA: 0x0070DCB0 File Offset: 0x0070BEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamRoomIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3016);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E97 RID: 102039 RVA: 0x0070DCF8 File Offset: 0x0070BEF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamJoinRoomSettingNotMatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3017);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E98 RID: 102040 RVA: 0x0070DD40 File Offset: 0x0070BF40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamJoinRoomAuthorityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3018);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E99 RID: 102041 RVA: 0x0070DD88 File Offset: 0x0070BF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamNotInTeam(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3019);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9A RID: 102042 RVA: 0x0070DDD0 File Offset: 0x0070BFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamChannelIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3020);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9B RID: 102043 RVA: 0x0070DE18 File Offset: 0x0070C018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamInvitationNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3021);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9C RID: 102044 RVA: 0x0070DE60 File Offset: 0x0070C060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamInviteFriendNotOnline(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3022);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9D RID: 102045 RVA: 0x0070DEA8 File Offset: 0x0070C0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamInviteTooBusy(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3023);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9E RID: 102046 RVA: 0x0070DEF0 File Offset: 0x0070C0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamCreateBattleRoomPermissionDenied(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3024);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018E9F RID: 102047 RVA: 0x0070DF38 File Offset: 0x0070C138
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamCannotFindSuitableBattleServer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3025);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA0 RID: 102048 RVA: 0x0070DF80 File Offset: 0x0070C180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamCreateBattleRoomPlayerNumsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3026);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA1 RID: 102049 RVA: 0x0070DFC8 File Offset: 0x0070C1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamViewTeamRoomChapterIdNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3027);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA2 RID: 102050 RVA: 0x0070E010 File Offset: 0x0070C210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamGetInviteeLevelInfoNumsOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3028);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA3 RID: 102051 RVA: 0x0070E058 File Offset: 0x0070C258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTeamChangePositionNotLeader(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3029);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA4 RID: 102052 RVA: 0x0070E0A0 File Offset: 0x0070C2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTeamChangePositionParamError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -3030);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA5 RID: 102053 RVA: 0x0070E0E8 File Offset: 0x0070C2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendFriendsFullError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA6 RID: 102054 RVA: 0x0070E130 File Offset: 0x0070C330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendTargetFriendsFullError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA7 RID: 102055 RVA: 0x0070E178 File Offset: 0x0070C378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendInvitationFullError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA8 RID: 102056 RVA: 0x0070E1C0 File Offset: 0x0070C3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendAlreadyFriendError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EA9 RID: 102057 RVA: 0x0070E208 File Offset: 0x0070C408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendCannotBecomeFriendsWhenBlocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAA RID: 102058 RVA: 0x0070E250 File Offset: 0x0070C450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendCannotInviteBlockedPlayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4005);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAB RID: 102059 RVA: 0x0070E298 File Offset: 0x0070C498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendCannotInviteWhenBlocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4006);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAC RID: 102060 RVA: 0x0070E2E0 File Offset: 0x0070C4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendCannotBlockFriend(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAD RID: 102061 RVA: 0x0070E328 File Offset: 0x0070C528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendServerNetError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4008);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAE RID: 102062 RVA: 0x0070E370 File Offset: 0x0070C570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCannotSendLikesToSelf(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4009);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EAF RID: 102063 RVA: 0x0070E3B8 File Offset: 0x0070C5B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHasSendLikesToday(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4010);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB0 RID: 102064 RVA: 0x0070E400 File Offset: 0x0070C600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSelectPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4011);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB1 RID: 102065 RVA: 0x0070E448 File Offset: 0x0070C648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBusinessCardDescIsNullOrIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4012);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB2 RID: 102066 RVA: 0x0070E490 File Offset: 0x0070C690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeBusineddCardDescTooLong(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4013);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB3 RID: 102067 RVA: 0x0070E4D8 File Offset: 0x0070C6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBusinessCardHeroSetIsNull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4014);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB4 RID: 102068 RVA: 0x0070E520 File Offset: 0x0070C720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendServerNotFound(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4015);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB5 RID: 102069 RVA: 0x0070E568 File Offset: 0x0070C768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTargetGameServerNotFound(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4016);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB6 RID: 102070 RVA: 0x0070E5B0 File Offset: 0x0070C7B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGSToFSRpcOperationFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4017);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB7 RID: 102071 RVA: 0x0070E5F8 File Offset: 0x0070C7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendCannotInviteYourself(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4018);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB8 RID: 102072 RVA: 0x0070E640 File Offset: 0x0070C840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendInviteSameUser(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4019);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EB9 RID: 102073 RVA: 0x0070E688 File Offset: 0x0070C888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendAlreadyInvited(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4020);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBA RID: 102074 RVA: 0x0070E6D0 File Offset: 0x0070C8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendPracticeTargetNotOnline(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4021);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBB RID: 102075 RVA: 0x0070E718 File Offset: 0x0070C918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendNotYourFriend(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4022);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBC RID: 102076 RVA: 0x0070E760 File Offset: 0x0070C960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendAlreadySentFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4023);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBD RID: 102077 RVA: 0x0070E7A8 File Offset: 0x0070C9A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendAlreadyReceivedFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4024);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBE RID: 102078 RVA: 0x0070E7F0 File Offset: 0x0070C9F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendSentFriendshipPointsTooManyTimes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4025);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EBF RID: 102079 RVA: 0x0070E838 File Offset: 0x0070CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendReceiveFriendshipPointsTooManyTimes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4026);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC0 RID: 102080 RVA: 0x0070E880 File Offset: 0x0070CA80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendReceiveFriendshipPointsSenderNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4027);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC1 RID: 102081 RVA: 0x0070E8C8 File Offset: 0x0070CAC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendBlackListFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4028);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC2 RID: 102082 RVA: 0x0070E910 File Offset: 0x0070CB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendTargetFriendsFullErrorBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4029);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC3 RID: 102083 RVA: 0x0070E958 File Offset: 0x0070CB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendInvitationFullErrorBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4030);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC4 RID: 102084 RVA: 0x0070E9A0 File Offset: 0x0070CBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendAlreadyFriendErrorBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4031);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC5 RID: 102085 RVA: 0x0070E9E8 File Offset: 0x0070CBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendCannotInviteBlockedPlayerBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4032);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC6 RID: 102086 RVA: 0x0070EA30 File Offset: 0x0070CC30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendCannotInviteWhenBlockedBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4033);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC7 RID: 102087 RVA: 0x0070EA78 File Offset: 0x0070CC78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendCannotInviteYourselfBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4034);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC8 RID: 102088 RVA: 0x0070EAC0 File Offset: 0x0070CCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendInviteSameUserBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4035);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EC9 RID: 102089 RVA: 0x0070EB08 File Offset: 0x0070CD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendAlreadyInvitedBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4036);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECA RID: 102090 RVA: 0x0070EB50 File Offset: 0x0070CD50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendFriendsFullErrorBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4037);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECB RID: 102091 RVA: 0x0070EB98 File Offset: 0x0070CD98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendCannotBecomeFriendsWhenBlockedBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4038);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECC RID: 102092 RVA: 0x0070EBE0 File Offset: 0x0070CDE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFriendCannotBlockMyself(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4039);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECD RID: 102093 RVA: 0x0070EC28 File Offset: 0x0070CE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendBusinessCardDescBanned(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4040);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECE RID: 102094 RVA: 0x0070EC70 File Offset: 0x0070CE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFriendUnknown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4099);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ECF RID: 102095 RVA: 0x0070ECB8 File Offset: 0x0070CEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRankingListQuerySingleHeroIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED0 RID: 102096 RVA: 0x0070ED00 File Offset: 0x0070CF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRankingListQueryLevelLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4101);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED1 RID: 102097 RVA: 0x0070ED48 File Offset: 0x0070CF48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRankingListQueryPeriodLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4102);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED2 RID: 102098 RVA: 0x0070ED90 File Offset: 0x0070CF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRankingListQueryUnknown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4103);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED3 RID: 102099 RVA: 0x0070EDD8 File Offset: 0x0070CFD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSearchRankingListTypeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED4 RID: 102100 RVA: 0x0070EE20 File Offset: 0x0070D020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroTrainningNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED5 RID: 102101 RVA: 0x0070EE68 File Offset: 0x0070D068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTrainningLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4201);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED6 RID: 102102 RVA: 0x0070EEB0 File Offset: 0x0070D0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroTrainningLevelNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4202);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED7 RID: 102103 RVA: 0x0070EEF8 File Offset: 0x0070D0F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTrainningChallengeNumsReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4203);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED8 RID: 102104 RVA: 0x0070EF40 File Offset: 0x0070D140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTrainningLevelIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4204);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ED9 RID: 102105 RVA: 0x0070EF88 File Offset: 0x0070D188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroTrainningChallengeCountUseOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4205);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDA RID: 102106 RVA: 0x0070EFD0 File Offset: 0x0070D1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroTrainningLevelBattleIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4206);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDB RID: 102107 RVA: 0x0070F018 File Offset: 0x0070D218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTrainningTicketNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4207);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDC RID: 102108 RVA: 0x0070F060 File Offset: 0x0070D260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroTrainningFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4208);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDD RID: 102109 RVA: 0x0070F0A8 File Offset: 0x0070D2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupCreateFailed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDE RID: 102110 RVA: 0x0070F0F0 File Offset: 0x0070D2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGroupFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4301);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EDF RID: 102111 RVA: 0x0070F138 File Offset: 0x0070D338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupMemberFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4302);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE0 RID: 102112 RVA: 0x0070F180 File Offset: 0x0070D380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupNotOwner(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4303);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE1 RID: 102113 RVA: 0x0070F1C8 File Offset: 0x0070D3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChangeGroupOwnerFailed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4304);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE2 RID: 102114 RVA: 0x0070F210 File Offset: 0x0070D410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGroupOwnerCannotLeave(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4305);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE3 RID: 102115 RVA: 0x0070F258 File Offset: 0x0070D458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChatGroupNameIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4306);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE4 RID: 102116 RVA: 0x0070F2A0 File Offset: 0x0070D4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupNameTooLong(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4307);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE5 RID: 102117 RVA: 0x0070F2E8 File Offset: 0x0070D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupTargetChatGroupFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4308);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE6 RID: 102118 RVA: 0x0070F330 File Offset: 0x0070D530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4309);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE7 RID: 102119 RVA: 0x0070F378 File Offset: 0x0070D578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupMemberFullBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4310);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE8 RID: 102120 RVA: 0x0070F3C0 File Offset: 0x0070D5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChatGroupTargetChatGroupFullBatch(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4311);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EE9 RID: 102121 RVA: 0x0070F408 File Offset: 0x0070D608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroPhantomNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EEA RID: 102122 RVA: 0x0070F450 File Offset: 0x0070D650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroPhantomLevelNotAvailable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4401);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EEB RID: 102123 RVA: 0x0070F498 File Offset: 0x0070D698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroPhantomLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4402);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EEC RID: 102124 RVA: 0x0070F4E0 File Offset: 0x0070D6E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCooperateBattleNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EED RID: 102125 RVA: 0x0070F528 File Offset: 0x0070D728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCooperateBattleLevelNotAvailable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4501);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EEE RID: 102126 RVA: 0x0070F570 File Offset: 0x0070D770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCooperateBattleLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4502);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EEF RID: 102127 RVA: 0x0070F5B8 File Offset: 0x0070D7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCooperateBattleFunctionNotOpen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4503);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF0 RID: 102128 RVA: 0x0070F600 File Offset: 0x0070D800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNoviceRewardNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4600);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF1 RID: 102129 RVA: 0x0070F648 File Offset: 0x0070D848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNoviceRewardAlreadyClaimed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4601);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF2 RID: 102130 RVA: 0x0070F690 File Offset: 0x0070D890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNoviceMissionPointsNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4602);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF3 RID: 102131 RVA: 0x0070F6D8 File Offset: 0x0070D8D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMatchmakingTimeout(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4700);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF4 RID: 102132 RVA: 0x0070F720 File Offset: 0x0070D920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMatchmakingCancelFailed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4701);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF5 RID: 102133 RVA: 0x0070F768 File Offset: 0x0070D968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRealTimePVPWinsBonusNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4702);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF6 RID: 102134 RVA: 0x0070F7B0 File Offset: 0x0070D9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRealTimePVPWinsBonusAlreadyAcquired(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4703);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF7 RID: 102135 RVA: 0x0070F7F8 File Offset: 0x0070D9F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRealTimePVPWinsBonusNotEnoughWins(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4704);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF8 RID: 102136 RVA: 0x0070F840 File Offset: 0x0070DA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRealTimePVPGameFunctionLocked(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4705);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EF9 RID: 102137 RVA: 0x0070F888 File Offset: 0x0070DA88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRealTimePVPArenaClosed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4706);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFA RID: 102138 RVA: 0x0070F8D0 File Offset: 0x0070DAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeMatchmakingAlreadyMatchmaking(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4707);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFB RID: 102139 RVA: 0x0070F918 File Offset: 0x0070DB18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRechargeStoreGoodsNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4800);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFC RID: 102140 RVA: 0x0070F960 File Offset: 0x0070DB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRechargeStoreGoodsIsOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4801);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFD RID: 102141 RVA: 0x0070F9A8 File Offset: 0x0070DBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRechargeStoreGoodsNotOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4802);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFE RID: 102142 RVA: 0x0070F9F0 File Offset: 0x0070DBF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRafflePoolNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4900);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018EFF RID: 102143 RVA: 0x0070FA38 File Offset: 0x0070DC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRafflePoolNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -4901);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F00 RID: 102144 RVA: 0x0070FA80 File Offset: 0x0070DC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeResourceSkinNotExsit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F01 RID: 102145 RVA: 0x0070FAC8 File Offset: 0x0070DCC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeResourceSkinNotMatchHero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F02 RID: 102146 RVA: 0x0070FB10 File Offset: 0x0070DD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeResourceSkinNotMatchJob(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F03 RID: 102147 RVA: 0x0070FB58 File Offset: 0x0070DD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeResourceSkinNotMatchSoldier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F04 RID: 102148 RVA: 0x0070FBA0 File Offset: 0x0070DDA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeResourceNoSkinWeared(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F05 RID: 102149 RVA: 0x0070FBE8 File Offset: 0x0070DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGiftStoreItemNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F06 RID: 102150 RVA: 0x0070FC30 File Offset: 0x0070DE30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGiftStoreItemNotOnSaleTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5101);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F07 RID: 102151 RVA: 0x0070FC78 File Offset: 0x0070DE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGiftStoreItemIsSellOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5102);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F08 RID: 102152 RVA: 0x0070FCC0 File Offset: 0x0070DEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotExistThisWaitPayingGoods(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5103);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F09 RID: 102153 RVA: 0x0070FD08 File Offset: 0x0070DF08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCheatBuyingFirstBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0A RID: 102154 RVA: 0x0070FD50 File Offset: 0x0070DF50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGiftStoreItemAppleSubscribeAttributeError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5105);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0B RID: 102155 RVA: 0x0070FD98 File Offset: 0x0070DF98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJustMonthCardCanBeAppleSubscribed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5106);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0C RID: 102156 RVA: 0x0070FDE0 File Offset: 0x0070DFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAppleSubscribeRepeatly(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5107);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0D RID: 102157 RVA: 0x0070FE28 File Offset: 0x0070E028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCheatBuyingGiftStoreItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5108);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0E RID: 102158 RVA: 0x0070FE70 File Offset: 0x0070E070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOperationalGoodsListIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5109);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F0F RID: 102159 RVA: 0x0070FEB8 File Offset: 0x0070E0B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeNotGiftStoreOperationalGoods(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5110);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F10 RID: 102160 RVA: 0x0070FF00 File Offset: 0x0070E100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAppleSubscribeGoodsNotEqualToOne(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5111);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F11 RID: 102161 RVA: 0x0070FF48 File Offset: 0x0070E148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeWaitZilongCheckGoodsSubscribing(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5112);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F12 RID: 102162 RVA: 0x0070FF90 File Offset: 0x0070E190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGiftStoreGoodsIsOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5113);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F13 RID: 102163 RVA: 0x0070FFD8 File Offset: 0x0070E1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGiftStoreGoodsNotOnBanBuyingPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5114);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F14 RID: 102164 RVA: 0x00710020 File Offset: 0x0070E220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeOrderNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5115);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F15 RID: 102165 RVA: 0x00710068 File Offset: 0x0070E268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildCreateLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F16 RID: 102166 RVA: 0x007100B0 File Offset: 0x0070E2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildHasOwnGuild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5201);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F17 RID: 102167 RVA: 0x007100F8 File Offset: 0x0070E2F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5202);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F18 RID: 102168 RVA: 0x00710140 File Offset: 0x0070E340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildJoinCoolDown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5203);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F19 RID: 102169 RVA: 0x00710188 File Offset: 0x0070E388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildNameDuplicate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5204);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1A RID: 102170 RVA: 0x007101D0 File Offset: 0x0070E3D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildSearchTimeLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5205);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1B RID: 102171 RVA: 0x00710218 File Offset: 0x0070E418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildNameIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5206);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1C RID: 102172 RVA: 0x00710260 File Offset: 0x0070E460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerNotInGuild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5207);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1D RID: 102173 RVA: 0x007102A8 File Offset: 0x0070E4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerNotPresidentOrVicePresident(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5208);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1E RID: 102174 RVA: 0x007102F0 File Offset: 0x0070E4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHiringDeclarationContentIsIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5209);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F1F RID: 102175 RVA: 0x00710338 File Offset: 0x0070E538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHiringDeclarationLengthIsIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5210);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F20 RID: 102176 RVA: 0x00710380 File Offset: 0x0070E580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHiringDeclarationIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5211);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F21 RID: 102177 RVA: 0x007103C8 File Offset: 0x0070E5C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildNameOutOfRange(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5212);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F22 RID: 102178 RVA: 0x00710410 File Offset: 0x0070E610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerNotPresident(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5213);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F23 RID: 102179 RVA: 0x00710458 File Offset: 0x0070E658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerIsAlreadyVicePresident(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5214);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F24 RID: 102180 RVA: 0x007104A0 File Offset: 0x0070E6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDestPlayerNotVicePresident(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5215);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F25 RID: 102181 RVA: 0x007104E8 File Offset: 0x0070E6E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildVicePresidentNumsReachMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5216);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F26 RID: 102182 RVA: 0x00710530 File Offset: 0x0070E730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeDestPlayerNotPresident(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5217);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F27 RID: 102183 RVA: 0x00710578 File Offset: 0x0070E778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodePlayerNotVicePresidentOrElite(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5218);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F28 RID: 102184 RVA: 0x007105C0 File Offset: 0x0070E7C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildPresidentNotOfflineTooLong(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5219);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F29 RID: 102185 RVA: 0x00710608 File Offset: 0x0070E808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5220);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2A RID: 102186 RVA: 0x00710650 File Offset: 0x0070E850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerNotHaveThisGuildOperateJurisdiction(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5221);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2B RID: 102187 RVA: 0x00710698 File Offset: 0x0070E898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildAnnouncementContentIsIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5222);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2C RID: 102188 RVA: 0x007106E0 File Offset: 0x0070E8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildAnnouncementLengthIsIllegal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5223);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2D RID: 102189 RVA: 0x00710728 File Offset: 0x0070E928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMemberIsFull(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5224);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2E RID: 102190 RVA: 0x00710770 File Offset: 0x0070E970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildJoinLevelNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5225);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F2F RID: 102191 RVA: 0x007107B8 File Offset: 0x0070E9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildJoinInvationNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5226);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F30 RID: 102192 RVA: 0x00710800 File Offset: 0x0070EA00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildApplyNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5227);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F31 RID: 102193 RVA: 0x00710848 File Offset: 0x0070EA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeSetPlayerJoinLevelError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5228);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F32 RID: 102194 RVA: 0x00710890 File Offset: 0x0070EA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildPresidentCannotAppointSelf(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5229);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F33 RID: 102195 RVA: 0x007108D8 File Offset: 0x0070EAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatMaxCombatsPerWeekExceeded(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5230);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F34 RID: 102196 RVA: 0x00710920 File Offset: 0x0070EB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatOnlyPresidentCanStartCombat(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5231);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F35 RID: 102197 RVA: 0x00710968 File Offset: 0x0070EB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildMassiveCombatMoreThanOneCombatNotAllowed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5232);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F36 RID: 102198 RVA: 0x007109B0 File Offset: 0x0070EBB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildMassiveCombatAvailableMembersNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5233);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F37 RID: 102199 RVA: 0x007109F8 File Offset: 0x0070EBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildMassiveCombatInvalidDifficulty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5234);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F38 RID: 102200 RVA: 0x00710A40 File Offset: 0x0070EC40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildMassiveCombatNoExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5235);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F39 RID: 102201 RVA: 0x00710A88 File Offset: 0x0070EC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatCannotParticipateInDifferentGuild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5236);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3A RID: 102202 RVA: 0x00710AD0 File Offset: 0x0070ECD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatHeroAlreadyUsed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5237);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3B RID: 102203 RVA: 0x00710B18 File Offset: 0x0070ED18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatStrongholdTaken(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5238);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3C RID: 102204 RVA: 0x00710B60 File Offset: 0x0070ED60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGuildMedalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5239);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3D RID: 102205 RVA: 0x00710BA8 File Offset: 0x0070EDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5240);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3E RID: 102206 RVA: 0x00710BF0 File Offset: 0x0070EDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeGuildMassiveCombatOnlyPresidentAndVPCanSurrender(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5241);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F3F RID: 102207 RVA: 0x00710C38 File Offset: 0x0070EE38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreNotOpenInCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F40 RID: 102208 RVA: 0x00710C80 File Offset: 0x0070EE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5301);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F41 RID: 102209 RVA: 0x00710CC8 File Offset: 0x0070EEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreChallengeLevelNotContains(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5302);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F42 RID: 102210 RVA: 0x00710D10 File Offset: 0x0070EF10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreChallengeLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5303);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F43 RID: 102211 RVA: 0x00710D58 File Offset: 0x0070EF58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreChallengeLevelNotUnlock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5304);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F44 RID: 102212 RVA: 0x00710DA0 File Offset: 0x0070EFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreChallengeLevelAlreadyAttack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5305);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F45 RID: 102213 RVA: 0x00710DE8 File Offset: 0x0070EFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreChallengeLevelPrevLevelNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5306);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F46 RID: 102214 RVA: 0x00710E30 File Offset: 0x0070F030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreScoreLevelNotContains(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5307);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F47 RID: 102215 RVA: 0x00710E78 File Offset: 0x0070F078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreScoreLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5308);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F48 RID: 102216 RVA: 0x00710EC0 File Offset: 0x0070F0C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreScoreLevelPlayerLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5309);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F49 RID: 102217 RVA: 0x00710F08 File Offset: 0x0070F108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreScoreLevelAlreadyAttack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5310);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4A RID: 102218 RVA: 0x00710F50 File Offset: 0x0070F150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreScoreLevelUnLock(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5311);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4B RID: 102219 RVA: 0x00710F98 File Offset: 0x0070F198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreRewardNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5312);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4C RID: 102220 RVA: 0x00710FE0 File Offset: 0x0070F1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreRewardScoreNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5313);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4D RID: 102221 RVA: 0x00711028 File Offset: 0x0070F228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeUnchartedScoreRewardGained(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5314);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4E RID: 102222 RVA: 0x00711070 File Offset: 0x0070F270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerFloorIdInvalid(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F4F RID: 102223 RVA: 0x007110B8 File Offset: 0x0070F2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerPrevFloorNotComplete(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5401);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F50 RID: 102224 RVA: 0x00711100 File Offset: 0x0070F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerLevelNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5402);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F51 RID: 102225 RVA: 0x00711148 File Offset: 0x0070F348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerAlreadyFlush(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5403);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F52 RID: 102226 RVA: 0x00711190 File Offset: 0x0070F390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeClimbTowerAttackCurFloorInvalid(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5404);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F53 RID: 102227 RVA: 0x007111D8 File Offset: 0x0070F3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerFloorNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5405);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F54 RID: 102228 RVA: 0x00711220 File Offset: 0x0070F420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerBonusHeroGroupNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5406);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F55 RID: 102229 RVA: 0x00711268 File Offset: 0x0070F468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeClimbTowerFloorConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5407);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F56 RID: 102230 RVA: 0x007112B0 File Offset: 0x0070F4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeClimbTowerBattleFinishFloorError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5408);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F57 RID: 102231 RVA: 0x007112F8 File Offset: 0x0070F4F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeClimbTowerFloorCantRaid(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5409);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F58 RID: 102232 RVA: 0x00711340 File Offset: 0x0070F540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeClimbTowerAlreadyReachTopTower(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5410);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F59 RID: 102233 RVA: 0x00711388 File Offset: 0x0070F588
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGoodsTypeRelatedIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5A RID: 102234 RVA: 0x007113D0 File Offset: 0x0070F5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSignRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -100001);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5B RID: 102235 RVA: 0x00711418 File Offset: 0x0070F618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeChapterRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10002);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5C RID: 102236 RVA: 0x00711460 File Offset: 0x0070F660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeEventRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10003);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5D RID: 102237 RVA: 0x007114A8 File Offset: 0x0070F6A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRiftRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10004);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5E RID: 102238 RVA: 0x007114F0 File Offset: 0x0070F6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeInitInfoRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10005);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F5F RID: 102239 RVA: 0x00711538 File Offset: 0x0070F738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomDropRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10006);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F60 RID: 102240 RVA: 0x00711580 File Offset: 0x0070F780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeScenarioRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F61 RID: 102241 RVA: 0x007115C8 File Offset: 0x0070F7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFreeCardPoolGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10008);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F62 RID: 102242 RVA: 0x00711610 File Offset: 0x0070F810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCrystalCardPoolGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10009);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F63 RID: 102243 RVA: 0x00711658 File Offset: 0x0070F858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeActivityCardPoolGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10010);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F64 RID: 102244 RVA: 0x007116A0 File Offset: 0x0070F8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDefiniteGroupRandomEventTotalWeightNotEqualMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10011);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F65 RID: 102245 RVA: 0x007116E8 File Offset: 0x0070F8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomGroupTotalWeightNotEqualMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10012);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F66 RID: 102246 RVA: 0x00711730 File Offset: 0x0070F930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomGroupRandomEventTotalWeightNotEqualMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10013);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F67 RID: 102247 RVA: 0x00711778 File Offset: 0x0070F978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeStoreWeightError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10014);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F68 RID: 102248 RVA: 0x007117C0 File Offset: 0x0070F9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFirstScenarioIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10015);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F69 RID: 102249 RVA: 0x00711808 File Offset: 0x0070FA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSkillHitMaxAboveZeroTime_MultiHitCountBelowZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10016);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6A RID: 102250 RVA: 0x00711850 File Offset: 0x0070FA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFlyItemSpeedNotAboveZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10017);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6B RID: 102251 RVA: 0x00711898 File Offset: 0x0070FA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDefaultSkillsCostAboveHeroFirstLevelSkillPoint(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10018);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6C RID: 102252 RVA: 0x007118E0 File Offset: 0x0070FAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeDefiniteGroupLevelZoneNotEqualRandomEventLevelZoneConfig(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10019);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6D RID: 102253 RVA: 0x00711928 File Offset: 0x0070FB28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomGroupLevelZoneNotEqualRandomEventLevelZoneConfig(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10020);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6E RID: 102254 RVA: 0x00711970 File Offset: 0x0070FB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolGroupTenSelectTotalMinCountIsAboveTen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10021);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F6F RID: 102255 RVA: 0x007119B8 File Offset: 0x0070FBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeConstRandomEventTimeConfigError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10022);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F70 RID: 102256 RVA: 0x00711A00 File Offset: 0x0070FC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobUnlockConditionItemCostIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10023);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F71 RID: 102257 RVA: 0x00711A48 File Offset: 0x0070FC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobUnlockConditionAchievementIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10024);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F72 RID: 102258 RVA: 0x00711A90 File Offset: 0x0070FC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroJobUnlockPreJobNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10025);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F73 RID: 102259 RVA: 0x00711AD8 File Offset: 0x0070FCD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeStaticBoxIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10026);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F74 RID: 102260 RVA: 0x00711B20 File Offset: 0x0070FD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomBoxIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10027);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F75 RID: 102261 RVA: 0x00711B68 File Offset: 0x0070FD68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomBoxMinCountAboveMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10028);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F76 RID: 102262 RVA: 0x00711BB0 File Offset: 0x0070FDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeThearchyTrialLevelRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10029);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F77 RID: 102263 RVA: 0x00711BF8 File Offset: 0x0070FDF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAnikiGymLevelRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10030);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F78 RID: 102264 RVA: 0x00711C40 File Offset: 0x0070FE40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroDefaultSkillIdCannotBeEquipedByDefaultJob(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10031);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F79 RID: 102265 RVA: 0x00711C88 File Offset: 0x0070FE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFixedStoreItemShowTimeFormError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10032);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7A RID: 102266 RVA: 0x00711CD0 File Offset: 0x0070FED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFixedStoreItemFirstRewardIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10033);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7B RID: 102267 RVA: 0x00711D18 File Offset: 0x0070FF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFixedStoreSellItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10034);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7C RID: 102268 RVA: 0x00711D60 File Offset: 0x0070FF60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFixedStoreItemDiscountTimeFormError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10035);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7D RID: 102269 RVA: 0x00711DA8 File Offset: 0x0070FFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTrainingHouseArmyListError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10036);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7E RID: 102270 RVA: 0x00711DF0 File Offset: 0x0070FFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTrainingHouseCoachNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10037);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F7F RID: 102271 RVA: 0x00711E38 File Offset: 0x00710038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCoachFavorabilityCoachNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10038);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F80 RID: 102272 RVA: 0x00711E80 File Offset: 0x00710080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCoachFavorabilityLevelError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10039);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F81 RID: 102273 RVA: 0x00711EC8 File Offset: 0x007100C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCoachFavorabilityLevelUpCostItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10040);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F82 RID: 102274 RVA: 0x00711F10 File Offset: 0x00710110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAboveTwoTrainingHouseHasSameCoach(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10041);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F83 RID: 102275 RVA: 0x00711F58 File Offset: 0x00710158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTrainingInstrumentStartLevelError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10042);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F84 RID: 102276 RVA: 0x00711FA0 File Offset: 0x007101A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCoachFavorabilityStartLevelError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10043);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F85 RID: 102277 RVA: 0x00711FE8 File Offset: 0x007101E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCoachFavorabilityTableCoachTotalNumberNotEqualCoachTableNumbers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10044);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F86 RID: 102278 RVA: 0x00712030 File Offset: 0x00710230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCoachFavorabilityUnlockInstrumentIdNotInTrainingHouseInstrumentIDList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10045);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F87 RID: 102279 RVA: 0x00712078 File Offset: 0x00710278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeInitInfoContainProtagonistHeroId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10046);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F88 RID: 102280 RVA: 0x007120C0 File Offset: 0x007102C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroInteractionInitialPleasureValueError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10047);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F89 RID: 102281 RVA: 0x00712108 File Offset: 0x00710308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroBodyZoneInitialToleranceValueError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10048);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8A RID: 102282 RVA: 0x00712150 File Offset: 0x00710350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeFirstInitInfoNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10049);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8B RID: 102283 RVA: 0x00712198 File Offset: 0x00710398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHerMaxLevelBelowPlayerMaxLevelCelling(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10050);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8C RID: 102284 RVA: 0x007121E0 File Offset: 0x007103E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRiftChapterContainsSameLevel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10051);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8D RID: 102285 RVA: 0x00712228 File Offset: 0x00710428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroHasInstanceLevelRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10052);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8E RID: 102286 RVA: 0x00712270 File Offset: 0x00710470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonStarRewardItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10053);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F8F RID: 102287 RVA: 0x007122B8 File Offset: 0x007104B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroDungeonLevelAchievementRewardItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10054);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F90 RID: 102288 RVA: 0x00712300 File Offset: 0x00710500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerMaxLevelAboveRandomEventLevelZoneMaxLeve(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10055);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F91 RID: 102289 RVA: 0x00712348 File Offset: 0x00710548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroHasFetterRepeated(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10056);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F92 RID: 102290 RVA: 0x00712390 File Offset: 0x00710590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRandomStoreItemInfoLevelZoneIDError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10057);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F93 RID: 102291 RVA: 0x007123D8 File Offset: 0x007105D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodePlayerLevelUpOperationalActivityItemGroupRewardParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10058);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F94 RID: 102292 RVA: 0x00712420 File Offset: 0x00710620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeLimitedTimeExchangeOperationalActivityItemItemGroupParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10059);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F95 RID: 102293 RVA: 0x00712468 File Offset: 0x00710668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSpecificDaysLoginOperationalActivityItemGroupRewardParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10060);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F96 RID: 102294 RVA: 0x007124B0 File Offset: 0x007106B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAccumulateDaysLoginOperationalActivityItemGroupRewardParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10061);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F97 RID: 102295 RVA: 0x007124F8 File Offset: 0x007106F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRewardAddOperationalActivityPlayParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10062);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F98 RID: 102296 RVA: 0x00712540 File Offset: 0x00710740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeChallengeNumsAddOperationalActivityPlayParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10063);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F99 RID: 102297 RVA: 0x00712588 File Offset: 0x00710788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolOperationalActivityCardPoolParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10064);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9A RID: 102298 RVA: 0x007125D0 File Offset: 0x007107D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeOperationalItemGroupItemIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10065);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9B RID: 102299 RVA: 0x00712618 File Offset: 0x00710818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeLimitedTimeExchangeOperationalActivityParmItemCannotBeEquipment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10066);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9C RID: 102300 RVA: 0x00712660 File Offset: 0x00710860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeRandomBoxRewardsGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10067);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9D RID: 102301 RVA: 0x007126A8 File Offset: 0x007108A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeStaticBoxRewardsGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10068);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9E RID: 102302 RVA: 0x007126F0 File Offset: 0x007108F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeEquipmentLevelTableRankNextExpsCountBelowEquipmentTableEquipmentMaxRank(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10069);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018F9F RID: 102303 RVA: 0x00712738 File Offset: 0x00710938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeBattleTreasureRewardGoodsIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10070);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA0 RID: 102304 RVA: 0x00712780 File Offset: 0x00710980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroInformationFetterIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10071);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA1 RID: 102305 RVA: 0x007127C8 File Offset: 0x007109C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroInformationConfessionIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10072);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA2 RID: 102306 RVA: 0x00712810 File Offset: 0x00710A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeHeroInitialJobConnectionNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10073);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA3 RID: 102307 RVA: 0x00712858 File Offset: 0x00710A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeJobConnnectionTalentSkillError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10074);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA4 RID: 102308 RVA: 0x007128A0 File Offset: 0x00710AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeTrainingGroundTechLevelMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10075);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA5 RID: 102309 RVA: 0x007128E8 File Offset: 0x00710AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTrainingGroundTechLevelupResourceNotEnough(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10076);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA6 RID: 102310 RVA: 0x00712930 File Offset: 0x00710B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeTrainingGroundTechLevelupFail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10077);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA7 RID: 102311 RVA: 0x00712978 File Offset: 0x00710B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFreeCardPoolGroupFirstSingleSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10078);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA8 RID: 102312 RVA: 0x007129C0 File Offset: 0x00710BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeFreeCardPoolGroupFirstTenSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1007);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FA9 RID: 102313 RVA: 0x00712A08 File Offset: 0x00710C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCrystalCardPoolGroupFirstSingleSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10080);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAA RID: 102314 RVA: 0x00712A50 File Offset: 0x00710C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCrystalCardPoolGroupFirstTenSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10081);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAB RID: 102315 RVA: 0x00712A98 File Offset: 0x00710C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActivityCardPoolGroupFirstSingleSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10082);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAC RID: 102316 RVA: 0x00712AE0 File Offset: 0x00710CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeActivityCardPoolGroupFirstTenSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10083);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAD RID: 102317 RVA: 0x00712B28 File Offset: 0x00710D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeHeroFetterTypeMissionCannotHaveReward(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10084);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAE RID: 102318 RVA: 0x00712B70 File Offset: 0x00710D70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMissionRewardIsEmpty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10085);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FAF RID: 102319 RVA: 0x00712BB8 File Offset: 0x00710DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeItemNumsError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10086);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB0 RID: 102320 RVA: 0x00712C00 File Offset: 0x00710E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGiftStoreItemShowTimeFormError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10087);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB1 RID: 102321 RVA: 0x00712C48 File Offset: 0x00710E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAppleSubscribeGoodsJustBeMonthCard(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10088);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB2 RID: 102322 RVA: 0x00712C90 File Offset: 0x00710E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNotMonthCardCannotBeSubscribed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10089);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB3 RID: 102323 RVA: 0x00712CD8 File Offset: 0x00710ED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGiftStoreGoodsTypeRelatedIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10090);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB4 RID: 102324 RVA: 0x00712D20 File Offset: 0x00710F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeGiftStoreFirstRewardTypeRelatedIdError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10091);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB5 RID: 102325 RVA: 0x00712D68 File Offset: 0x00710F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeRaffleOperationaRaffleParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10092);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB6 RID: 102326 RVA: 0x00712DB0 File Offset: 0x00710FB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeAccumulateRechargeOperationalActivityItemGroupRewardParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10093);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB7 RID: 102327 RVA: 0x00712DF8 File Offset: 0x00710FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeAccumulateConsumeCrystalOperationalActivityItemGroupRewardParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10094);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB8 RID: 102328 RVA: 0x00712E40 File Offset: 0x00711040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeMonthCardMissionError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10095);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FB9 RID: 102329 RVA: 0x00712E88 File Offset: 0x00711088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeNewUserAccumulatedValueError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10096);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBA RID: 102330 RVA: 0x00712ED0 File Offset: 0x007110D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOldUserAccumulatedValueError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10097);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBB RID: 102331 RVA: 0x00712F18 File Offset: 0x00711118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolTenSelectGuaranteedMinCountError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10098);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBC RID: 102332 RVA: 0x00712F60 File Offset: 0x00711160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCardPoolDefaultSingleSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10099);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBD RID: 102333 RVA: 0x00712FA8 File Offset: 0x007111A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolDefaultTenSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBE RID: 102334 RVA: 0x00712FF0 File Offset: 0x007111F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolFirstSingleSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10101);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FBF RID: 102335 RVA: 0x00713038 File Offset: 0x00711238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolFirstTenSelectWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10102);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC0 RID: 102336 RVA: 0x00713080 File Offset: 0x00711280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeCardPoolTenSelectAccumulateWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10103);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC1 RID: 102337 RVA: 0x007130C8 File Offset: 0x007112C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeCardPoolGroupAllItemWeightIsZero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10104);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC2 RID: 102338 RVA: 0x00713110 File Offset: 0x00711310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeUnchartedScoreOperationaUnchartedScoreIdParmError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10105);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC3 RID: 102339 RVA: 0x00713158 File Offset: 0x00711358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeOperactionalActivityDaysAfterServerOpenError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10106);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC4 RID: 102340 RVA: 0x007131A0 File Offset: 0x007113A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeOperactionalActivityDaysAfterPlayerCreatedError(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10107);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC5 RID: 102341 RVA: 0x007131E8 File Offset: 0x007113E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSrcCopyAccountNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10108);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC6 RID: 102342 RVA: 0x00713230 File Offset: 0x00711430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ErrCodeDestCopyPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10109);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC7 RID: 102343 RVA: 0x00713278 File Offset: 0x00711478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ErrCodeSrcCopyPlayerNotExist(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -10110);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018FC8 RID: 102344 RVA: 0x007132C0 File Offset: 0x007114C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.CommonDefine.ErrorCode");
		string name = "ErrCodeOk";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOk);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache0, null, false);
		string name2 = "ErrCodeUnknow";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnknow);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1, null, false);
		string name3 = "ErrorCodeNeedCreateCharacter";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeNeedCreateCharacter);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2, null, false);
		string name4 = "ErrCodePlayerNameInvalid";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNameInvalid);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3, null, false);
		string name5 = "ErrCodePlayerNameRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNameRepeated);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4, null, false);
		string name6 = "ErrCodePlayerNameLengthAboveMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNameLengthAboveMax);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5, null, false);
		string name7 = "ErrCodePlayerNameIsIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNameIsIllegal);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6, null, false);
		string name8 = "ErrCodePlayerSave2DBOperationFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerSave2DBOperationFail);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7, null, false);
		string name9 = "ErrCodeNameIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNameIllegal);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8, null, false);
		string name10 = "ErrCodePlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotExist);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9, null, false);
		string name11 = "ErrCodeNameEmptyNotAllowed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNameEmptyNotAllowed);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA, null, false);
		string name12 = "ErrCodeOrderHasDelivered";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOrderHasDelivered);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB, null, false);
		string name13 = "ErrCodeWrite2DBFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWrite2DBFail);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC, null, false);
		string name14 = "ErrCodeRMBStoreTypeNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRMBStoreTypeNotExist);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD, null, false);
		string name15 = "ErrCodeNotHasThisHeadFrame";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHasThisHeadFrame);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE, null, false);
		string name16 = "ErrCodeIsSameHeadFrame";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeIsSameHeadFrame);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF, null, false);
		string name17 = "ErrCodeWritePlayerData2DBFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWritePlayerData2DBFail);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10, null, false);
		string name18 = "ErrCodeErrorOrder";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeErrorOrder);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11, null, false);
		string name19 = "ErrCodeOrderduplicate";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOrderduplicate);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12, null, false);
		string name20 = "ErrCodeNetworkError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNetworkError);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13, null, false);
		string name21 = "ErrCodeGMMessageError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGMMessageError);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14, null, false);
		string name22 = "ErrCodeGMOptionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGMOptionTypeError);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15, null, false);
		string name23 = "ErrCodeGMOptionDataError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGMOptionDataError);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16, null, false);
		string name24 = "ErrCodeGMOptionDataNotDigit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGMOptionDataNotDigit);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17, null, false);
		string name25 = "ErrCodeHeroIdNotExistOrHeroExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroIdNotExistOrHeroExist);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18, null, false);
		string name26 = "ErrCodeHeroIdNotExistOrHeroNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroIdNotExistOrHeroNotExist);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19, null, false);
		string name27 = "ErrCodeFlushConfigFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFlushConfigFail);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A, null, false);
		string name28 = "ErrCodePlayerIsOffLine";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerIsOffLine);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B, null, false);
		string name29 = "ErrCodeGMOperationDataNotDateTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGMOperationDataNotDateTime);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C, null, false);
		string name30 = "ErrCodeAdvertisementFlowLayoutIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAdvertisementFlowLayoutIsEmpty);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D, null, false);
		string name31 = "ErrCodeAdvertisementFlowLayoutActivityNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAdvertisementFlowLayoutActivityNotExist);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E, null, false);
		string name32 = "ErrCodeInstanceItemNumsAboveBagCapacity";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeInstanceItemNumsAboveBagCapacity);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F, null, false);
		string name33 = "ErrCodePlayerListIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerListIsEmpty);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20, null, false);
		string name34 = "ErrCodeUserGuideListIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUserGuideListIsEmpty);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21, null, false);
		string name35 = "ErrCodeGoldNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGoldNotEnough);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22, null, false);
		string name36 = "ErrCodeCrystalNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalNotEnough);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23, null, false);
		string name37 = "ErrCodeEnergyNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEnergyNotEnough);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24, null, false);
		string name38 = "ErrCodeGoodsTypeIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGoodsTypeIdError);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25, null, false);
		string name39 = "ErrCodeCurrencyNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCurrencyNotEnough);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26, null, false);
		string name40 = "ErrCodePlayerLevelExpIsMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerLevelExpIsMax);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27, null, false);
		string name41 = "ErrCodePlayerRepeatSign";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerRepeatSign);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28, null, false);
		string name42 = "ErrCodeSignRewardConfigNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSignRewardConfigNotExist);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29, null, false);
		string name43 = "ErrCodeBuyEngryConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBuyEngryConfigError);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A, null, false);
		string name44 = "ErrCodeArenaHonourNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaHonourNotEnough);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B, null, false);
		string name45 = "ErrCodeBuyArenaTickrtConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBuyArenaTickrtConfigError);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C, null, false);
		string name46 = "ErrCodeGuideStepIdOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuideStepIdOutOfRange);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D, null, false);
		string name47 = "ErrCodeChangedNameEqualToCurrentName";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChangedNameEqualToCurrentName);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E, null, false);
		string name48 = "ErrCodePlayerLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerLevelNotEnough);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F, null, false);
		string name49 = "ErrCodeBuyEnergyNumsUsedOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBuyEnergyNumsUsedOut);
		}
		LuaObject.addMember(l, name49, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30, null, false);
		string name50 = "ErrCodeRealTimePVPHonorNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPHonorNotEnough);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache31, null, false);
		string name51 = "ErrCodeSkinTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSkinTicketNotEnough);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache32, null, false);
		string name52 = "ErrCodeFriendShipPointsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendShipPointsNotEnough);
		}
		LuaObject.addMember(l, name52, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache33, null, false);
		string name53 = "ErrCodeUserGuideNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUserGuideNotExist);
		}
		LuaObject.addMember(l, name53, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache34, null, false);
		string name54 = "ErrCodeMemoryEssenceNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryEssenceNotEnough);
		}
		LuaObject.addMember(l, name54, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache35, null, false);
		string name55 = "ErrCodeBrillianceMithralStoneNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBrillianceMithralStoneNotEnough);
		}
		LuaObject.addMember(l, name55, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache36, null, false);
		string name56 = "ErrCodeMithralStoneNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMithralStoneNotEnough);
		}
		LuaObject.addMember(l, name56, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache37, null, false);
		string name57 = "ErrCodeGoldOverFlow";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGoldOverFlow);
		}
		LuaObject.addMember(l, name57, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache38, null, false);
		string name58 = "ErrCodeExchangeGiftCDKeyGoodsNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeExchangeGiftCDKeyGoodsNotExist);
		}
		LuaObject.addMember(l, name58, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache39, null, false);
		string name59 = "ErrCodeExchangeGiftCDKeyGoodsParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeExchangeGiftCDKeyGoodsParamError);
		}
		LuaObject.addMember(l, name59, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3A, null, false);
		string name60 = "ErrCodeBagCapcityNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagCapcityNotEnough);
		}
		LuaObject.addMember(l, name60, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3B, null, false);
		string name61 = "ErrCodeBagItemNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemNumsNotEnough);
		}
		LuaObject.addMember(l, name61, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3C, null, false);
		string name62 = "ErrCodeBagItemNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemNotExsit);
		}
		LuaObject.addMember(l, name62, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3D, null, false);
		string name63 = "ErrCodeBagItemsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemsNotEnough);
		}
		LuaObject.addMember(l, name63, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3E, null, false);
		string name64 = "ErrCodeBagItemJobMaterialIdNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemJobMaterialIdNotExsit);
		}
		LuaObject.addMember(l, name64, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache3F, null, false);
		string name65 = "ErrCodeBagItemItemIdNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemItemIdNotExsit);
		}
		LuaObject.addMember(l, name65, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache40, null, false);
		string name66 = "ErrCodeBagItemItemCanNotUse";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemItemCanNotUse);
		}
		LuaObject.addMember(l, name66, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache41, null, false);
		string name67 = "ErrCodeBagItemTypeCanNotSell";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemTypeCanNotSell);
		}
		LuaObject.addMember(l, name67, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache42, null, false);
		string name68 = "ErrCodeBagItemCreateError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemCreateError);
		}
		LuaObject.addMember(l, name68, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache43, null, false);
		string name69 = "ErrCodeBagItemNotMatchGoodsType";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemNotMatchGoodsType);
		}
		LuaObject.addMember(l, name69, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache44, null, false);
		string name70 = "ErrCodeBagItemEnhanceEquipmentMaterialOutofRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEnhanceEquipmentMaterialOutofRange);
		}
		LuaObject.addMember(l, name70, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache45, null, false);
		string name71 = "ErrCodeBagItemEquipmentLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentLocked);
		}
		LuaObject.addMember(l, name71, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache46, null, false);
		string name72 = "ErrCodeBagItemEnhanceEquipmentMaterialEnhanced";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEnhanceEquipmentMaterialEnhanced);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache47, null, false);
		string name73 = "ErrCodeBagItemEnhanceEquipmentMaterialLevelUpStar";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEnhanceEquipmentMaterialLevelUpStar);
		}
		LuaObject.addMember(l, name73, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache48, null, false);
		string name74 = "ErrCodeBagItemEnhanceEquipmentLevelExpMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEnhanceEquipmentLevelExpMax);
		}
		LuaObject.addMember(l, name74, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache49, null, false);
		string name75 = "ErrCodeBagItemEnhanceEquipmentTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEnhanceEquipmentTypeError);
		}
		LuaObject.addMember(l, name75, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4A, null, false);
		string name76 = "ErrCodeBagItemLevelUpStarEquipmentMatrialTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemLevelUpStarEquipmentMatrialTypeError);
		}
		LuaObject.addMember(l, name76, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4B, null, false);
		string name77 = "ErrCodeBagItemEquipmentLevelUpStarRankDifferent";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentLevelUpStarRankDifferent);
		}
		LuaObject.addMember(l, name77, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4C, null, false);
		string name78 = "ErrCodeBagItemEquipmentLevelUpStarMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentLevelUpStarMax);
		}
		LuaObject.addMember(l, name78, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4D, null, false);
		string name79 = "ErrCodeBagItemEquipmentLevelUpLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentLevelUpLevelNotEnough);
		}
		LuaObject.addMember(l, name79, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4E, null, false);
		string name80 = "ErrCodeBagItemEquipmentAndMaterialIsSame";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentAndMaterialIsSame);
		}
		LuaObject.addMember(l, name80, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache4F, null, false);
		string name81 = "ErrCodeIllegalUseBagItemNums";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeIllegalUseBagItemNums);
		}
		LuaObject.addMember(l, name81, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache50, null, false);
		string name82 = "ErrCodeBagItemEquipmentIdNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemEquipmentIdNotExsit);
		}
		LuaObject.addMember(l, name82, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache51, null, false);
		string name83 = "ErrCodeConsumeItemNumsError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeConsumeItemNumsError);
		}
		LuaObject.addMember(l, name83, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache52, null, false);
		string name84 = "ErrCodeStarLeveUpEquipmentCannotEnhanceEquipment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeStarLeveUpEquipmentCannotEnhanceEquipment);
		}
		LuaObject.addMember(l, name84, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache53, null, false);
		string name85 = "ErrCodeBagItemStarLevelUpEquipmentTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemStarLevelUpEquipmentTypeError);
		}
		LuaObject.addMember(l, name85, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache54, null, false);
		string name86 = "ErrCodeCannotEquipmentThisEquipment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCannotEquipmentThisEquipment);
		}
		LuaObject.addMember(l, name86, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache55, null, false);
		string name87 = "ErrCodeBagItemCannotDecompose";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemCannotDecompose);
		}
		LuaObject.addMember(l, name87, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache56, null, false);
		string name88 = "ErrCodeBagItemNotStacking";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemNotStacking);
		}
		LuaObject.addMember(l, name88, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache57, null, false);
		string name89 = "ErrCodeNotItemTypeCannotUse";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotItemTypeCannotUse);
		}
		LuaObject.addMember(l, name89, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache58, null, false);
		string name90 = "ErrCodeHeroFavorabilityExpItemNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFavorabilityExpItemNotEnough);
		}
		LuaObject.addMember(l, name90, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache59, null, false);
		string name91 = "ErrCodeItemUseNumsError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeItemUseNumsError);
		}
		LuaObject.addMember(l, name91, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5A, null, false);
		string name92 = "ErrCodeBagItemSaveEnchantingEquipmentNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagItemSaveEnchantingEquipmentNotExist);
		}
		LuaObject.addMember(l, name92, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5B, null, false);
		string name93 = "ErrCodeOpenBoxNumReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOpenBoxNumReachMax);
		}
		LuaObject.addMember(l, name93, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5C, null, false);
		string name94 = "ErrCodeEnergyMedicineNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEnergyMedicineNotEnough);
		}
		LuaObject.addMember(l, name94, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5D, null, false);
		string name95 = "ErrCodeAlchemyOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAlchemyOutOfRange);
		}
		LuaObject.addMember(l, name95, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5E, null, false);
		string name96 = "ErrCodeStaticBoxNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeStaticBoxNotExist);
		}
		LuaObject.addMember(l, name96, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache5F, null, false);
		string name97 = "ErrCodeRandomBoxNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBoxNotExist);
		}
		LuaObject.addMember(l, name97, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache60, null, false);
		string name98 = "ErrCodeSelfSelectedBoxNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelfSelectedBoxNotExist);
		}
		LuaObject.addMember(l, name98, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache61, null, false);
		string name99 = "ErrCodeSelfSelectedBoxItemIndexNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelfSelectedBoxItemIndexNotExist);
		}
		LuaObject.addMember(l, name99, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache62, null, false);
		string name100 = "ErrCodeNotSelfSelectedBoxCanHaveIndexParm";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotSelfSelectedBoxCanHaveIndexParm);
		}
		LuaObject.addMember(l, name100, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache63, null, false);
		string name101 = "ErrCodeHeroJobIsExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobIsExsit);
		}
		LuaObject.addMember(l, name101, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache64, null, false);
		string name102 = "ErrCodeHeroJobNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobNotExsit);
		}
		LuaObject.addMember(l, name102, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache65, null, false);
		string name103 = "ErrCodeHeroNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroNotExsit);
		}
		LuaObject.addMember(l, name103, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache66, null, false);
		string name104 = "ErrCodeHeroExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroExsit);
		}
		LuaObject.addMember(l, name104, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache67, null, false);
		string name105 = "ErrCodeJobMaterialRemoveError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobMaterialRemoveError);
		}
		LuaObject.addMember(l, name105, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache68, null, false);
		string name106 = "ErrCodeJobMaterialSlotNotMatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobMaterialSlotNotMatch);
		}
		LuaObject.addMember(l, name106, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache69, null, false);
		string name107 = "ErrCodeJobMaterialHadEquiped";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobMaterialHadEquiped);
		}
		LuaObject.addMember(l, name107, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6A, null, false);
		string name108 = "ErrCodeJobMaterialNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobMaterialNotEnough);
		}
		LuaObject.addMember(l, name108, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6B, null, false);
		string name109 = "ErrCodeBagNotHaveJobMaterial";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBagNotHaveJobMaterial);
		}
		LuaObject.addMember(l, name109, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6C, null, false);
		string name110 = "ErrCodeSlotIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSlotIdError);
		}
		LuaObject.addMember(l, name110, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6D, null, false);
		string name111 = "ErrCodeLevelUpStarLevelConfigNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLevelUpStarLevelConfigNotExsit);
		}
		LuaObject.addMember(l, name111, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6E, null, false);
		string name112 = "ErrCodeJobLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobLevelNotEnough);
		}
		LuaObject.addMember(l, name112, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache6F, null, false);
		string name113 = "ErrCodeJobLevelOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobLevelOutOfRange);
		}
		LuaObject.addMember(l, name113, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache70, null, false);
		string name114 = "ErrCodeJobIdNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobIdNotExsit);
		}
		LuaObject.addMember(l, name114, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache71, null, false);
		string name115 = "ErrCodeJobRankError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobRankError);
		}
		LuaObject.addMember(l, name115, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache72, null, false);
		string name116 = "ErrCodeJobRelatedIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobRelatedIdError);
		}
		LuaObject.addMember(l, name116, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache73, null, false);
		string name117 = "ErrCodeJobLevelIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobLevelIdNotExist);
		}
		LuaObject.addMember(l, name117, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache74, null, false);
		string name118 = "ErrCodeHeroTransferJobRankOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTransferJobRankOutOfRange);
		}
		LuaObject.addMember(l, name118, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache75, null, false);
		string name119 = "ErrCodeHeroIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroIdNotExist);
		}
		LuaObject.addMember(l, name119, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache76, null, false);
		string name120 = "ErrCodeHeroNotHaveThisSoldier";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroNotHaveThisSoldier);
		}
		LuaObject.addMember(l, name120, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache77, null, false);
		string name121 = "ErrCodeHeroNotHaveThisSkill";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroNotHaveThisSkill);
		}
		LuaObject.addMember(l, name121, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache78, null, false);
		string name122 = "ErrCodeSkillIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSkillIdError);
		}
		LuaObject.addMember(l, name122, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache79, null, false);
		string name123 = "ErrCodeMaterialNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMaterialNotEnough);
		}
		LuaObject.addMember(l, name123, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7A, null, false);
		string name124 = "ErrCodeHeroLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroLevelNotEnough);
		}
		LuaObject.addMember(l, name124, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7B, null, false);
		string name125 = "ErrCodeHeroGetSkillEneryError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroGetSkillEneryError);
		}
		LuaObject.addMember(l, name125, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7C, null, false);
		string name126 = "ErrCodeHeroSkillEneryNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroSkillEneryNotEnough);
		}
		LuaObject.addMember(l, name126, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7D, null, false);
		string name127 = "ErrCodeHeroSlectedSkillCountOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroSlectedSkillCountOutOfRange);
		}
		LuaObject.addMember(l, name127, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7E, null, false);
		string name128 = "ErrCodeComposeMaterialNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeComposeMaterialNotExist);
		}
		LuaObject.addMember(l, name128, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache7F, null, false);
		string name129 = "ErrCodeNoJobMaterialCanEquiped";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNoJobMaterialCanEquiped);
		}
		LuaObject.addMember(l, name129, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache80, null, false);
		string name130 = "ErrCodeFragmentItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFragmentItemIdError);
		}
		LuaObject.addMember(l, name130, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache81, null, false);
		string name131 = "ErrCodeHeroStarLevelAboveHeroStarLevelMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroStarLevelAboveHeroStarLevelMax);
		}
		LuaObject.addMember(l, name131, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache82, null, false);
		string name132 = "ErrCodeHeroExpIsFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroExpIsFull);
		}
		LuaObject.addMember(l, name132, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache83, null, false);
		string name133 = "ErrCodeSkillIdRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSkillIdRepeated);
		}
		LuaObject.addMember(l, name133, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache84, null, false);
		string name134 = "ErrCodeHeroJobCannotTransferSelfJob";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobCannotTransferSelfJob);
		}
		LuaObject.addMember(l, name134, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache85, null, false);
		string name135 = "ErrCodeHeroTransferJobsNotContainThisJob";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTransferJobsNotContainThisJob);
		}
		LuaObject.addMember(l, name135, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache86, null, false);
		string name136 = "ErrCodeHeroStarIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroStarIdError);
		}
		LuaObject.addMember(l, name136, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache87, null, false);
		string name137 = "ErrCodePreJobNotOPen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePreJobNotOPen);
		}
		LuaObject.addMember(l, name137, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache88, null, false);
		string name138 = "ErrCodeHeroJobLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobLocked);
		}
		LuaObject.addMember(l, name138, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache89, null, false);
		string name139 = "ErrCodeHeroJobRepeateUnlock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobRepeateUnlock);
		}
		LuaObject.addMember(l, name139, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8A, null, false);
		string name140 = "ErrCodeHeroJobUnlockItemCostNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobUnlockItemCostNotEnough);
		}
		LuaObject.addMember(l, name140, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8B, null, false);
		string name141 = "ErrCodeHeroJobUnlockAcgievementsNotReach";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobUnlockAcgievementsNotReach);
		}
		LuaObject.addMember(l, name141, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8C, null, false);
		string name142 = "ErrCodeHeroJobNotNeedUnlock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobNotNeedUnlock);
		}
		LuaObject.addMember(l, name142, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8D, null, false);
		string name143 = "ErrCodePreHeroJobNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePreHeroJobNotExist);
		}
		LuaObject.addMember(l, name143, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8E, null, false);
		string name144 = "ErrCodeCurrentJobCannotEquipThisSkill";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCurrentJobCannotEquipThisSkill);
		}
		LuaObject.addMember(l, name144, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache8F, null, false);
		string name145 = "ErrCodeProtagonistIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeProtagonistIdError);
		}
		LuaObject.addMember(l, name145, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache90, null, false);
		string name146 = "ErrCodeProtagonistHasSetDown";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeProtagonistHasSetDown);
		}
		LuaObject.addMember(l, name146, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache91, null, false);
		string name147 = "ErrCodeHeroEquipmentHasWeared";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroEquipmentHasWeared);
		}
		LuaObject.addMember(l, name147, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache92, null, false);
		string name148 = "ErrCodeHeroEquipmentSoldierNotmatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroEquipmentSoldierNotmatch);
		}
		LuaObject.addMember(l, name148, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache93, null, false);
		string name149 = "ErrCodeHeroEquipmentJobNotmatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroEquipmentJobNotmatch);
		}
		LuaObject.addMember(l, name149, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache94, null, false);
		string name150 = "ErrCodeHeroEquipmentHasNotWeared";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroEquipmentHasNotWeared);
		}
		LuaObject.addMember(l, name150, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache95, null, false);
		string name151 = "ErrCodePreHeroJobNotMaster";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePreHeroJobNotMaster);
		}
		LuaObject.addMember(l, name151, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache96, null, false);
		string name152 = "ErrCodeCannotWearThisTypeEquipment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCannotWearThisTypeEquipment);
		}
		LuaObject.addMember(l, name152, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache97, null, false);
		string name153 = "ErrCodeHeroFragmentNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFragmentNumsNotEnough);
		}
		LuaObject.addMember(l, name153, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache98, null, false);
		string name154 = "ErrCodeHeroAutoEquipmentTimeTooClose";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAutoEquipmentTimeTooClose);
		}
		LuaObject.addMember(l, name154, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache99, null, false);
		string name155 = "ErrCodeHeroAutoEquipmentDontUpdate";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAutoEquipmentDontUpdate);
		}
		LuaObject.addMember(l, name155, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9A, null, false);
		string name156 = "ErrCodeProtagonistHeroCannotAddFavorabilityExp";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeProtagonistHeroCannotAddFavorabilityExp);
		}
		LuaObject.addMember(l, name156, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9B, null, false);
		string name157 = "ErrCodeHeroFavorabilityExpIsFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFavorabilityExpIsFull);
		}
		LuaObject.addMember(l, name157, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9C, null, false);
		string name158 = "ErrCodeHeroInformationNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInformationNotExist);
		}
		LuaObject.addMember(l, name158, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9D, null, false);
		string name159 = "ErrCodeUnlockHeroFetterFavorabilityLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroFetterFavorabilityLevelNotEnough);
		}
		LuaObject.addMember(l, name159, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9E, null, false);
		string name160 = "ErrCodeUnlockMissionNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockMissionNotComplete);
		}
		LuaObject.addMember(l, name160, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache9F, null, false);
		string name161 = "ErrCodeUnlockFetterConditionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockFetterConditionTypeError);
		}
		LuaObject.addMember(l, name161, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA0, null, false);
		string name162 = "ErrCodeHeroFetterLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFetterLocked);
		}
		LuaObject.addMember(l, name162, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA1, null, false);
		string name163 = "ErrCodeHeroNotHaveThisFetter";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroNotHaveThisFetter);
		}
		LuaObject.addMember(l, name163, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA2, null, false);
		string name164 = "ErrCodeHeroRepeatedlyUnlock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroRepeatedlyUnlock);
		}
		LuaObject.addMember(l, name164, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA3, null, false);
		string name165 = "ErrCodeHeroFetterLevelReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFetterLevelReachMax);
		}
		LuaObject.addMember(l, name165, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA4, null, false);
		string name166 = "ErrCodeHeroPerformanceIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroPerformanceIdError);
		}
		LuaObject.addMember(l, name166, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA5, null, false);
		string name167 = "ErrCodeUnlockHeroPerformanceFavorabilityLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroPerformanceFavorabilityLevelNotEnough);
		}
		LuaObject.addMember(l, name167, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA6, null, false);
		string name168 = "ErrCodeUnlockHeroPerformanceConditionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroPerformanceConditionTypeError);
		}
		LuaObject.addMember(l, name168, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA7, null, false);
		string name169 = "ErrCodeHeroBiographyIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroBiographyIdError);
		}
		LuaObject.addMember(l, name169, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA8, null, false);
		string name170 = "ErrCodeUnlockHeroBiographyFavorabilityLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroBiographyFavorabilityLevelNotEnough);
		}
		LuaObject.addMember(l, name170, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheA9, null, false);
		string name171 = "ErrCodeUnlockHeroBiographyConditionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroBiographyConditionTypeError);
		}
		LuaObject.addMember(l, name171, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAA, null, false);
		string name172 = "ErrCodeHeroConfessRepeatedly";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroConfessRepeatedly);
		}
		LuaObject.addMember(l, name172, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAB, null, false);
		string name173 = "ErrCodeHeroFetterLevelNotReachConfessLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFetterLevelNotReachConfessLevel);
		}
		LuaObject.addMember(l, name173, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAC, null, false);
		string name174 = "ErrCodeHeroConfessionIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroConfessionIdError);
		}
		LuaObject.addMember(l, name174, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAD, null, false);
		string name175 = "ErrCodeProtagonistHeroCannotBeConfessed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeProtagonistHeroCannotBeConfessed);
		}
		LuaObject.addMember(l, name175, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAE, null, false);
		string name176 = "ErrCodeHeroInteractNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInteractNumsNotEnough);
		}
		LuaObject.addMember(l, name176, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheAF, null, false);
		string name177 = "ErrCodeHeroInteractIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInteractIdError);
		}
		LuaObject.addMember(l, name177, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB0, null, false);
		string name178 = "ErrCodeHeroInteractBigUpResultNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInteractBigUpResultNotExist);
		}
		LuaObject.addMember(l, name178, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB1, null, false);
		string name179 = "ErrCodeHeroInteractResultConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInteractResultConfigError);
		}
		LuaObject.addMember(l, name179, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB2, null, false);
		string name180 = "ErrCodeHeroJobNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobNotOpen);
		}
		LuaObject.addMember(l, name180, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB3, null, false);
		string name181 = "ErrCodeNotExistExtralHeroFragement";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotExistExtralHeroFragement);
		}
		LuaObject.addMember(l, name181, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB4, null, false);
		string name182 = "ErrCodeScenarioIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeScenarioIdError);
		}
		LuaObject.addMember(l, name182, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB5, null, false);
		string name183 = "ErrCodeUnlockScenarioPlayerLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockScenarioPlayerLevelNotEnough);
		}
		LuaObject.addMember(l, name183, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB6, null, false);
		string name184 = "ErrCodeUnlockScenarioRiftProgressNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockScenarioRiftProgressNotEnough);
		}
		LuaObject.addMember(l, name184, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB7, null, false);
		string name185 = "ErrCodeScenarioStageIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeScenarioStageIdError);
		}
		LuaObject.addMember(l, name185, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB8, null, false);
		string name186 = "ErrCodeNextScenarioIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNextScenarioIsEmpty);
		}
		LuaObject.addMember(l, name186, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheB9, null, false);
		string name187 = "ErrCodeWayPointIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWayPointIdError);
		}
		LuaObject.addMember(l, name187, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBA, null, false);
		string name188 = "ErrCodeWayPointHaveScenario";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWayPointHaveScenario);
		}
		LuaObject.addMember(l, name188, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBB, null, false);
		string name189 = "ErrCodeCanNotMoveToThisWayPoint";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCanNotMoveToThisWayPoint);
		}
		LuaObject.addMember(l, name189, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBC, null, false);
		string name190 = "ErrCodeWayPointHaveEvent";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWayPointHaveEvent);
		}
		LuaObject.addMember(l, name190, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBD, null, false);
		string name191 = "ErrCodeTreasureIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTreasureIsEmpty);
		}
		LuaObject.addMember(l, name191, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBE, null, false);
		string name192 = "ErrCodeWayPointEventIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWayPointEventIdError);
		}
		LuaObject.addMember(l, name192, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheBF, null, false);
		string name193 = "ErrCodeNotHaveFight";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveFight);
		}
		LuaObject.addMember(l, name193, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC0, null, false);
		string name194 = "ErrCodeEventFunctionTypeNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEventFunctionTypeNotExsit);
		}
		LuaObject.addMember(l, name194, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC1, null, false);
		string name195 = "ErrCodeUnlockScenarioNotCompleteRiftLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockScenarioNotCompleteRiftLevel);
		}
		LuaObject.addMember(l, name195, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC2, null, false);
		string name196 = "ErrCodeRandomEventOperationNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomEventOperationNotOpen);
		}
		LuaObject.addMember(l, name196, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC3, null, false);
		string name197 = "ErrCodeAboveMapRandomEventMaxCount";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAboveMapRandomEventMaxCount);
		}
		LuaObject.addMember(l, name197, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC4, null, false);
		string name198 = "ErrCodeActionRandomEventComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActionRandomEventComplete);
		}
		LuaObject.addMember(l, name198, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC5, null, false);
		string name199 = "ErrCodeRandomEventIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomEventIdError);
		}
		LuaObject.addMember(l, name199, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC6, null, false);
		string name200 = "ErrCodeNotHaveWayPointPlaceRandomEvent";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveWayPointPlaceRandomEvent);
		}
		LuaObject.addMember(l, name200, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC7, null, false);
		string name201 = "ErrCodeScenarioChapterNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeScenarioChapterNotOpen);
		}
		LuaObject.addMember(l, name201, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC8, null, false);
		string name202 = "ErrCodeRiftLevelUnlock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelUnlock);
		}
		LuaObject.addMember(l, name202, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheC9, null, false);
		string name203 = "ErrCodeRiftLevelAttackNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelAttackNumsNotEnough);
		}
		LuaObject.addMember(l, name203, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCA, null, false);
		string name204 = "ErrCodeRiftLevelRaidStarNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelRaidStarNotEnough);
		}
		LuaObject.addMember(l, name204, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCB, null, false);
		string name205 = "ErrCodeRiftLevelRaidParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelRaidParamError);
		}
		LuaObject.addMember(l, name205, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCC, null, false);
		string name206 = "ErrCodeRiftLevelHasGainChapterReward";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelHasGainChapterReward);
		}
		LuaObject.addMember(l, name206, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCD, null, false);
		string name207 = "ErrCodeRiftChapterIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftChapterIdError);
		}
		LuaObject.addMember(l, name207, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCE, null, false);
		string name208 = "ErrCodeRiftChapterPlayerLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftChapterPlayerLevelNotEnough);
		}
		LuaObject.addMember(l, name208, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheCF, null, false);
		string name209 = "ErrCodeRiftChapterScenarioProcessNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftChapterScenarioProcessNotEnough);
		}
		LuaObject.addMember(l, name209, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD0, null, false);
		string name210 = "ErrCodeRiftLevelIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelIdError);
		}
		LuaObject.addMember(l, name210, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD1, null, false);
		string name211 = "ErrCodePreRiftLevelNotCompleted";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePreRiftLevelNotCompleted);
		}
		LuaObject.addMember(l, name211, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD2, null, false);
		string name212 = "ErrCodeNotHaveThisAchievement";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveThisAchievement);
		}
		LuaObject.addMember(l, name212, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD3, null, false);
		string name213 = "ErrCodeNotHaveThisHero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveThisHero);
		}
		LuaObject.addMember(l, name213, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD4, null, false);
		string name214 = "ErrCodeUnlockChapterParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockChapterParamError);
		}
		LuaObject.addMember(l, name214, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD5, null, false);
		string name215 = "ErrCodeUnlockRiftLevelParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockRiftLevelParamError);
		}
		LuaObject.addMember(l, name215, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD6, null, false);
		string name216 = "ErrCodeRiftGainChapterRewardStarNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftGainChapterRewardStarNotEnough);
		}
		LuaObject.addMember(l, name216, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD7, null, false);
		string name217 = "ErrCodeRiftGainChapterRewardIndexError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftGainChapterRewardIndexError);
		}
		LuaObject.addMember(l, name217, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD8, null, false);
		string name218 = "ErrCodeRiftLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelBattleIdError);
		}
		LuaObject.addMember(l, name218, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheD9, null, false);
		string name219 = "ErrCodeNotHaveUnlockedChapter";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveUnlockedChapter);
		}
		LuaObject.addMember(l, name219, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDA, null, false);
		string name220 = "ErrCodeRiftLevelNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelNotComplete);
		}
		LuaObject.addMember(l, name220, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDB, null, false);
		string name221 = "ErrCodeRiftLevelPlayerLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelPlayerLevelNotEnough);
		}
		LuaObject.addMember(l, name221, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDC, null, false);
		string name222 = "ErrCodeRiftLevelRelatedAchievementIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftLevelRelatedAchievementIdError);
		}
		LuaObject.addMember(l, name222, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDD, null, false);
		string name223 = "ErrCodeLevelRaidTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLevelRaidTicketNotEnough);
		}
		LuaObject.addMember(l, name223, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDE, null, false);
		string name224 = "ErrCodeChapterStarNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChapterStarNotEnough);
		}
		LuaObject.addMember(l, name224, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheDF, null, false);
		string name225 = "ErrCodeRiftAchievementRepeatelyComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftAchievementRepeatelyComplete);
		}
		LuaObject.addMember(l, name225, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE0, null, false);
		string name226 = "ErrCodeRiftFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftFunctionNotOpen);
		}
		LuaObject.addMember(l, name226, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE1, null, false);
		string name227 = "ErrCodeRiftGainChapterIndexParmOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftGainChapterIndexParmOutOfRange);
		}
		LuaObject.addMember(l, name227, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE2, null, false);
		string name228 = "ErrCodeRiftChapterNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftChapterNotOpen);
		}
		LuaObject.addMember(l, name228, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE3, null, false);
		string name229 = "ErrCodeBattleAttackIsFighting";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleAttackIsFighting);
		}
		LuaObject.addMember(l, name229, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE4, null, false);
		string name230 = "ErrCodeBattleFinishedIsNotFighting";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleFinishedIsNotFighting);
		}
		LuaObject.addMember(l, name230, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE5, null, false);
		string name231 = "ErrCodeBattleAttacklWayPointNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleAttacklWayPointNotExist);
		}
		LuaObject.addMember(l, name231, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE6, null, false);
		string name232 = "ErrCodeBattleAttackRiftLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleAttackRiftLevelNotExist);
		}
		LuaObject.addMember(l, name232, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE7, null, false);
		string name233 = "ErrCodeBattleCancelIsNotFighting";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleCancelIsNotFighting);
		}
		LuaObject.addMember(l, name233, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE8, null, false);
		string name234 = "ErrCodeBattleIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleIdNotExist);
		}
		LuaObject.addMember(l, name234, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheE9, null, false);
		string name235 = "ErrorCodeBattleReportError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleReportError);
		}
		LuaObject.addMember(l, name235, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEA, null, false);
		string name236 = "ErrorCodeBattleHeroesNumsOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleHeroesNumsOutOfRange);
		}
		LuaObject.addMember(l, name236, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEB, null, false);
		string name237 = "ErrorCodeBattleHeroPositionError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleHeroPositionError);
		}
		LuaObject.addMember(l, name237, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEC, null, false);
		string name238 = "ErrorCodeBattleCreatMapError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleCreatMapError);
		}
		LuaObject.addMember(l, name238, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheED, null, false);
		string name239 = "ErrorCodeBattleBattleReportError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleBattleReportError);
		}
		LuaObject.addMember(l, name239, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEE, null, false);
		string name240 = "ErrorCodeBattleInitError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeBattleInitError);
		}
		LuaObject.addMember(l, name240, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheEF, null, false);
		string name241 = "ErrCodeUnknownBattle";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnknownBattle);
		}
		LuaObject.addMember(l, name241, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF0, null, false);
		string name242 = "ErrCodeUnknownBattleMonsterLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnknownBattleMonsterLevel);
		}
		LuaObject.addMember(l, name242, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF1, null, false);
		string name243 = "ErrCodeArenaBattleIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaBattleIdNotExist);
		}
		LuaObject.addMember(l, name243, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF2, null, false);
		string name244 = "ErrCodeBattleTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleTypeError);
		}
		LuaObject.addMember(l, name244, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF3, null, false);
		string name245 = "ErrCodeBattleAttackHeroDungeonLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleAttackHeroDungeonLevelNotExist);
		}
		LuaObject.addMember(l, name245, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF4, null, false);
		string name246 = "ErrCodeBattleActionPositionIndexOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleActionPositionIndexOutOfRange);
		}
		LuaObject.addMember(l, name246, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF5, null, false);
		string name247 = "ErrCodeBattleActionValueOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleActionValueOutOfRange);
		}
		LuaObject.addMember(l, name247, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF6, null, false);
		string name248 = "ErrCodeRandomBattleArmyNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBattleArmyNotExist);
		}
		LuaObject.addMember(l, name248, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF7, null, false);
		string name249 = "ErrCodeRandomBattleArmyRoleWeightError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBattleArmyRoleWeightError);
		}
		LuaObject.addMember(l, name249, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF8, null, false);
		string name250 = "ErrCodeEventRiftLevelCannotBeRepeatedlyAttacked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEventRiftLevelCannotBeRepeatedlyAttacked);
		}
		LuaObject.addMember(l, name250, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheF9, null, false);
		string name251 = "ErrCodeNecessaryHeroNotInBattle";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNecessaryHeroNotInBattle);
		}
		LuaObject.addMember(l, name251, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFA, null, false);
		string name252 = "ErrCodeBattleAlreadyInBattleServer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleAlreadyInBattleServer);
		}
		LuaObject.addMember(l, name252, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFB, null, false);
		string name253 = "ErrCodeBattleRoomCreateBattleTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomCreateBattleTypeError);
		}
		LuaObject.addMember(l, name253, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFC, null, false);
		string name254 = "ErrCodeBattleServerNetError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleServerNetError);
		}
		LuaObject.addMember(l, name254, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFD, null, false);
		string name255 = "ErrCodeBattleNotFightingInBattleServer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleNotFightingInBattleServer);
		}
		LuaObject.addMember(l, name255, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFE, null, false);
		string name256 = "ErrCodeBattleChangePlayerBattleStatusOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleChangePlayerBattleStatusOutOfRange);
		}
		LuaObject.addMember(l, name256, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cacheFF, null, false);
		string name257 = "ErrCodeBattleSetupHeroError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleSetupHeroError);
		}
		LuaObject.addMember(l, name257, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache100, null, false);
		string name258 = "ErrCodeBattleRoomNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomNotExist);
		}
		LuaObject.addMember(l, name258, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache101, null, false);
		string name259 = "ErrCodeBattleCommandError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleCommandError);
		}
		LuaObject.addMember(l, name259, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache102, null, false);
		string name260 = "ErrCodeBattleRoomPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomPlayerNotExist);
		}
		LuaObject.addMember(l, name260, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache103, null, false);
		string name261 = "ErrCodeBattleRoomIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomIdError);
		}
		LuaObject.addMember(l, name261, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache104, null, false);
		string name262 = "ErrCodeBattleRoomHasSendActionBegin";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomHasSendActionBegin);
		}
		LuaObject.addMember(l, name262, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache105, null, false);
		string name263 = "ErrCodePVPBattleIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePVPBattleIdNotExist);
		}
		LuaObject.addMember(l, name263, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache106, null, false);
		string name264 = "ErrCodeRealTimePVPBattleIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPBattleIdNotExist);
		}
		LuaObject.addMember(l, name264, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache107, null, false);
		string name265 = "ErrCodeBattleRoomPutdownHeroError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleRoomPutdownHeroError);
		}
		LuaObject.addMember(l, name265, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache108, null, false);
		string name266 = "ErrCodeBattleGuildMassiveCombatSetupHeroNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleGuildMassiveCombatSetupHeroNotEnough);
		}
		LuaObject.addMember(l, name266, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache109, null, false);
		string name267 = "ErrCodeMailIdRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailIdRepeated);
		}
		LuaObject.addMember(l, name267, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10A, null, false);
		string name268 = "ErrCodeMailNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailNotExist);
		}
		LuaObject.addMember(l, name268, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10B, null, false);
		string name269 = "ErrCodeMailHadRead";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailHadRead);
		}
		LuaObject.addMember(l, name269, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10C, null, false);
		string name270 = "ErrCodeMailAttachmentHadGot";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailAttachmentHadGot);
		}
		LuaObject.addMember(l, name270, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10D, null, false);
		string name271 = "ErrCodeMailIsExpired";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailIsExpired);
		}
		LuaObject.addMember(l, name271, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10E, null, false);
		string name272 = "ErrCodeMailTemplateIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailTemplateIdError);
		}
		LuaObject.addMember(l, name272, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache10F, null, false);
		string name273 = "ErrCodeNotHaveMailExistAttachment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotHaveMailExistAttachment);
		}
		LuaObject.addMember(l, name273, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache110, null, false);
		string name274 = "ErrCodeMailNotHaveAttachment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMailNotHaveAttachment);
		}
		LuaObject.addMember(l, name274, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache111, null, false);
		string name275 = "ErrCodeRandomStoreNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreNotExist);
		}
		LuaObject.addMember(l, name275, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache112, null, false);
		string name276 = "ErrCodeRandomStoreBuyItemIndexOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreBuyItemIndexOutOfRange);
		}
		LuaObject.addMember(l, name276, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache113, null, false);
		string name277 = "ErrCodeRandomStoreItemIsBought";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreItemIsBought);
		}
		LuaObject.addMember(l, name277, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache114, null, false);
		string name278 = "ErrCodeRandomStoreIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreIdNotExist);
		}
		LuaObject.addMember(l, name278, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache115, null, false);
		string name279 = "ErrCodeRandomStoreBuyItemStoreHasFlushed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreBuyItemStoreHasFlushed);
		}
		LuaObject.addMember(l, name279, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache116, null, false);
		string name280 = "ErrCodeManualFlushNumsUsedOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeManualFlushNumsUsedOut);
		}
		LuaObject.addMember(l, name280, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache117, null, false);
		string name281 = "ErrCodeRandomEventLevelConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomEventLevelConfigError);
		}
		LuaObject.addMember(l, name281, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache118, null, false);
		string name282 = "ErrCodeDefiniteGroupRandomEventGroupNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDefiniteGroupRandomEventGroupNotExist);
		}
		LuaObject.addMember(l, name282, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache119, null, false);
		string name283 = "ErrCodeEventIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEventIdError);
		}
		LuaObject.addMember(l, name283, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11A, null, false);
		string name284 = "ErrCodeCurrentWayPointHaveUnfinishedRandomEvent";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCurrentWayPointHaveUnfinishedRandomEvent);
		}
		LuaObject.addMember(l, name284, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11B, null, false);
		string name285 = "ErrCodeRandomEventTimeOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomEventTimeOut);
		}
		LuaObject.addMember(l, name285, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11C, null, false);
		string name286 = "ErrCodeRandomEventGroupIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomEventGroupIdError);
		}
		LuaObject.addMember(l, name286, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11D, null, false);
		string name287 = "ErrCodeFixedStoreNotExistThisStore";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreNotExistThisStore);
		}
		LuaObject.addMember(l, name287, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11E, null, false);
		string name288 = "ErrCodeFixedStoreNotExistThisGoods";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreNotExistThisGoods);
		}
		LuaObject.addMember(l, name288, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache11F, null, false);
		string name289 = "ErrCodeFixedStoreThisGoodsHasSoldOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreThisGoodsHasSoldOut);
		}
		LuaObject.addMember(l, name289, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache120, null, false);
		string name290 = "ErrCodeFixedStoreGoodsNotInSellTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreGoodsNotInSellTime);
		}
		LuaObject.addMember(l, name290, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache121, null, false);
		string name291 = "ErrCodeChatPlayerNotEnoughLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatPlayerNotEnoughLevel);
		}
		LuaObject.addMember(l, name291, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache122, null, false);
		string name292 = "ErrCodeChatSendTooOften";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatSendTooOften);
		}
		LuaObject.addMember(l, name292, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache123, null, false);
		string name293 = "ErrCodeChatBanned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatBanned);
		}
		LuaObject.addMember(l, name293, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache124, null, false);
		string name294 = "ErrCodeChatChannelNotPermission";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatChannelNotPermission);
		}
		LuaObject.addMember(l, name294, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache125, null, false);
		string name295 = "ErrCodeChatPlayerOffline";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatPlayerOffline);
		}
		LuaObject.addMember(l, name295, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache126, null, false);
		string name296 = "ErrCodeChatWorldChannelAllocRoomPlayerAlreadyInsideRoom";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelAllocRoomPlayerAlreadyInsideRoom);
		}
		LuaObject.addMember(l, name296, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache127, null, false);
		string name297 = "ErrCodeChatWorldChannelAllocRoomAllRoomsFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelAllocRoomAllRoomsFull);
		}
		LuaObject.addMember(l, name297, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache128, null, false);
		string name298 = "ErrCodeChatWorldChannelRemovePlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelRemovePlayerNotExist);
		}
		LuaObject.addMember(l, name298, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache129, null, false);
		string name299 = "ErrCodeChatWorldChannelEnterRoomSameTwice";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelEnterRoomSameTwice);
		}
		LuaObject.addMember(l, name299, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12A, null, false);
		string name300 = "ErrCodeChatWorldChannelEnterRoomFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelEnterRoomFull);
		}
		LuaObject.addMember(l, name300, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12B, null, false);
		string name301 = "ErrCodeChatWorldChannelEnterRoomIllegalRoomId";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelEnterRoomIllegalRoomId);
		}
		LuaObject.addMember(l, name301, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12C, null, false);
		string name302 = "ErrCodeChatTeamChannelTeamRoomNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatTeamChannelTeamRoomNotExist);
		}
		LuaObject.addMember(l, name302, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12D, null, false);
		string name303 = "ErrCodeChatGroupChannelGroupNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupChannelGroupNotExist);
		}
		LuaObject.addMember(l, name303, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12E, null, false);
		string name304 = "ErrCodeChatGroupChannelPlayerNotBelongToGroup";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupChannelPlayerNotBelongToGroup);
		}
		LuaObject.addMember(l, name304, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache12F, null, false);
		string name305 = "ErrCodeChatVoiceContentTimeout";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatVoiceContentTimeout);
		}
		LuaObject.addMember(l, name305, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache130, null, false);
		string name306 = "ErrCodeChatPrivateChannelNotSelectTargetPlayer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatPrivateChannelNotSelectTargetPlayer);
		}
		LuaObject.addMember(l, name306, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache131, null, false);
		string name307 = "ErrCodeChatGroupChannelNotSelectTargetGroup";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupChannelNotSelectTargetGroup);
		}
		LuaObject.addMember(l, name307, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache132, null, false);
		string name308 = "ErrCodeChatPrivateChannelSrcPlayerBlockDestPlayer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatPrivateChannelSrcPlayerBlockDestPlayer);
		}
		LuaObject.addMember(l, name308, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache133, null, false);
		string name309 = "ErrCodeChatPrivateChannelDestPlayerBlockSrcPlayer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatPrivateChannelDestPlayerBlockSrcPlayer);
		}
		LuaObject.addMember(l, name309, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache134, null, false);
		string name310 = "ErrCodeChatWorldChannelServerBusy";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatWorldChannelServerBusy);
		}
		LuaObject.addMember(l, name310, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache135, null, false);
		string name311 = "ErrCodeChatGuildChannelHaveNoGuild";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGuildChannelHaveNoGuild);
		}
		LuaObject.addMember(l, name311, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache136, null, false);
		string name312 = "ErrCodeActivityCardPoolNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name312, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache137, null, false);
		string name313 = "ErrCodeActivityCardPoolSelectCountUsedOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolSelectCountUsedOut);
		}
		LuaObject.addMember(l, name313, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache138, null, false);
		string name314 = "ErrCodeSelectCardTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelectCardTicketNotEnough);
		}
		LuaObject.addMember(l, name314, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache139, null, false);
		string name315 = "ErrCodeSelectCardPoolNotExistById";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelectCardPoolNotExistById);
		}
		LuaObject.addMember(l, name315, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13A, null, false);
		string name316 = "ErrCodeCardPoolCannotUseTenSelect";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolCannotUseTenSelect);
		}
		LuaObject.addMember(l, name316, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13B, null, false);
		string name317 = "ErrCodeSelectCardPoolCannotUseCrystal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelectCardPoolCannotUseCrystal);
		}
		LuaObject.addMember(l, name317, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13C, null, false);
		string name318 = "ErrCodeFreeCardPoolJustUseTicket";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFreeCardPoolJustUseTicket);
		}
		LuaObject.addMember(l, name318, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13D, null, false);
		string name319 = "ErrCodeFreeCardJustCanUseTicketsTenSelect";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFreeCardJustCanUseTicketsTenSelect);
		}
		LuaObject.addMember(l, name319, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13E, null, false);
		string name320 = "ErrCodeUserGuidSelectCardStepHasCompleted";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUserGuidSelectCardStepHasCompleted);
		}
		LuaObject.addMember(l, name320, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache13F, null, false);
		string name321 = "ErrCodeSameGroupIdExistBetweenCrystalCardPoolGroupTableAndFreeCardPooGroupTable";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSameGroupIdExistBetweenCrystalCardPoolGroupTableAndFreeCardPooGroupTable);
		}
		LuaObject.addMember(l, name321, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache140, null, false);
		string name322 = "ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndFreeCardPooGroupTable";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndFreeCardPooGroupTable);
		}
		LuaObject.addMember(l, name322, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache141, null, false);
		string name323 = "ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndCrystalCardPooGroupTable";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndCrystalCardPooGroupTable);
		}
		LuaObject.addMember(l, name323, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache142, null, false);
		string name324 = "ErrCodeUserGuideRepeatedCompleted";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUserGuideRepeatedCompleted);
		}
		LuaObject.addMember(l, name324, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache143, null, false);
		string name325 = "ErrCodeCrystalCardPoolJustCanUseTicket";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalCardPoolJustCanUseTicket);
		}
		LuaObject.addMember(l, name325, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache144, null, false);
		string name326 = "ErrCodeCrstalCardPoolSelectConsumeMaterialNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrstalCardPoolSelectConsumeMaterialNotEnough);
		}
		LuaObject.addMember(l, name326, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache145, null, false);
		string name327 = "ErrCodeCrystalCardPoolUseTicketNotEnoughButCrystalEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalCardPoolUseTicketNotEnoughButCrystalEnough);
		}
		LuaObject.addMember(l, name327, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache146, null, false);
		string name328 = "ErrCodeActivityCardPoolJustCanUseTicket";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolJustCanUseTicket);
		}
		LuaObject.addMember(l, name328, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache147, null, false);
		string name329 = "ErrCodeMissionIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionIdError);
		}
		LuaObject.addMember(l, name329, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache148, null, false);
		string name330 = "ErrCodeMissionNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionNotComplete);
		}
		LuaObject.addMember(l, name330, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache149, null, false);
		string name331 = "ErrCodeMissionLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionLocked);
		}
		LuaObject.addMember(l, name331, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14A, null, false);
		string name332 = "ErrCodeMissionNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionNotExist);
		}
		LuaObject.addMember(l, name332, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14B, null, false);
		string name333 = "ErrCodeMissionServerDataHasSync2Client";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionServerDataHasSync2Client);
		}
		LuaObject.addMember(l, name333, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14C, null, false);
		string name334 = "ErrCodeMissionRewardHasGot";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionRewardHasGot);
		}
		LuaObject.addMember(l, name334, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14D, null, false);
		string name335 = "ErrCodeCommentHeroNumsIsMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentHeroNumsIsMax);
		}
		LuaObject.addMember(l, name335, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14E, null, false);
		string name336 = "ErrCodeCommentHeroNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentHeroNotExist);
		}
		LuaObject.addMember(l, name336, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache14F, null, false);
		string name337 = "ErrCodeCommentEntryHasPraised";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentEntryHasPraised);
		}
		LuaObject.addMember(l, name337, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache150, null, false);
		string name338 = "ErrCodeCommentPraiseEntryNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentPraiseEntryNotExist);
		}
		LuaObject.addMember(l, name338, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache151, null, false);
		string name339 = "ErrCodeCommentViewCommenterHeroNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentViewCommenterHeroNotExsit);
		}
		LuaObject.addMember(l, name339, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache152, null, false);
		string name340 = "ErrCodeCommentBanned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCommentBanned);
		}
		LuaObject.addMember(l, name340, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache153, null, false);
		string name341 = "ErrCodeThearchyTrialNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialNotOpen);
		}
		LuaObject.addMember(l, name341, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache154, null, false);
		string name342 = "ErrCodeThearchyTrialLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelNotExist);
		}
		LuaObject.addMember(l, name342, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache155, null, false);
		string name343 = "ErrCodeThearchyTrialLevelNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name343, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache156, null, false);
		string name344 = "ErrCodeThearchyTrialLevelPreLevelUnfinished";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelPreLevelUnfinished);
		}
		LuaObject.addMember(l, name344, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache157, null, false);
		string name345 = "ErrCodeThearchyTrialChallengeNumsReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialChallengeNumsReachMax);
		}
		LuaObject.addMember(l, name345, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache158, null, false);
		string name346 = "ErrCodeThearchyTrialLevelIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelIdError);
		}
		LuaObject.addMember(l, name346, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache159, null, false);
		string name347 = "ErrCodeThearchyTrialChallengeCountUseOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialChallengeCountUseOut);
		}
		LuaObject.addMember(l, name347, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15A, null, false);
		string name348 = "ErrCodeThearchyTrialLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelBattleIdError);
		}
		LuaObject.addMember(l, name348, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15B, null, false);
		string name349 = "ErrCodeThearchyTrialTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialTicketNotEnough);
		}
		LuaObject.addMember(l, name349, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15C, null, false);
		string name350 = "ErrCodeThearchyTrialFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialFunctionNotOpen);
		}
		LuaObject.addMember(l, name350, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15D, null, false);
		string name351 = "ErrCodeAnikiGymNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymNotOpen);
		}
		LuaObject.addMember(l, name351, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15E, null, false);
		string name352 = "ErrCodeAnikiGymLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymLevelNotExist);
		}
		LuaObject.addMember(l, name352, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache15F, null, false);
		string name353 = "ErrCodeAnikiGymLevelNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymLevelNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name353, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache160, null, false);
		string name354 = "ErrCodeAnikiGymlLevelPreLevelUnfinished";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymlLevelPreLevelUnfinished);
		}
		LuaObject.addMember(l, name354, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache161, null, false);
		string name355 = "ErrCodeAnikiGymChallengeNumsReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymChallengeNumsReachMax);
		}
		LuaObject.addMember(l, name355, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache162, null, false);
		string name356 = "ErrCodeAnikiGymLevelIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymLevelIdError);
		}
		LuaObject.addMember(l, name356, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache163, null, false);
		string name357 = "ErrCodeAnikiGymChallengeCountUseOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymChallengeCountUseOut);
		}
		LuaObject.addMember(l, name357, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache164, null, false);
		string name358 = "ErrCodeAnikiGymLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymLevelBattleIdError);
		}
		LuaObject.addMember(l, name358, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache165, null, false);
		string name359 = "ErrCodeAnikiGymTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymTicketNotEnough);
		}
		LuaObject.addMember(l, name359, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache166, null, false);
		string name360 = "ErrCodeAnikiGymFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymFunctionNotOpen);
		}
		LuaObject.addMember(l, name360, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache167, null, false);
		string name361 = "ErrCodeArenaNotEnoughTicket";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaNotEnoughTicket);
		}
		LuaObject.addMember(l, name361, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache168, null, false);
		string name362 = "ErrCodeArenaPlayerNotEnoughLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaPlayerNotEnoughLevel);
		}
		LuaObject.addMember(l, name362, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache169, null, false);
		string name363 = "ErrCodeArenaOpponentIndexOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaOpponentIndexOutOfRange);
		}
		LuaObject.addMember(l, name363, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16A, null, false);
		string name364 = "ErrCodeArenaOpponentHasAttacked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaOpponentHasAttacked);
		}
		LuaObject.addMember(l, name364, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16B, null, false);
		string name365 = "ErrCodeArenaNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaNotOpen);
		}
		LuaObject.addMember(l, name365, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16C, null, false);
		string name366 = "ErrCodeArenaManualFlushTimeNotReached";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaManualFlushTimeNotReached);
		}
		LuaObject.addMember(l, name366, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16D, null, false);
		string name367 = "ErrCodeArenaAttackOpponentGetDefensiveTeamInfoFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaAttackOpponentGetDefensiveTeamInfoFail);
		}
		LuaObject.addMember(l, name367, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16E, null, false);
		string name368 = "ErrCodeArenaBattleReportNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaBattleReportNotExist);
		}
		LuaObject.addMember(l, name368, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache16F, null, false);
		string name369 = "ErrCodeArenaBattleTimeOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaBattleTimeOut);
		}
		LuaObject.addMember(l, name369, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache170, null, false);
		string name370 = "ErrCodeArenaNotExistHostility";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaNotExistHostility);
		}
		LuaObject.addMember(l, name370, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache171, null, false);
		string name371 = "ErrCodeArenaRevengedOpponent";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaRevengedOpponent);
		}
		LuaObject.addMember(l, name371, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache172, null, false);
		string name372 = "ErrCodeArenaReportBattleReportFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaReportBattleReportFail);
		}
		LuaObject.addMember(l, name372, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache173, null, false);
		string name373 = "ErrCodeArenaVictoryPointsRewardRepeatedlyGot";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaVictoryPointsRewardRepeatedlyGot);
		}
		LuaObject.addMember(l, name373, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache174, null, false);
		string name374 = "ErrCodeArenaVictoryRewardIndexError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaVictoryRewardIndexError);
		}
		LuaObject.addMember(l, name374, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache175, null, false);
		string name375 = "ErrCodeArenaVictoryPointsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaVictoryPointsNotEnough);
		}
		LuaObject.addMember(l, name375, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache176, null, false);
		string name376 = "ErrCodeArenaIsNotFighting";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaIsNotFighting);
		}
		LuaObject.addMember(l, name376, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache177, null, false);
		string name377 = "ErrCodeArenaOpponentHasNotAttacked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaOpponentHasNotAttacked);
		}
		LuaObject.addMember(l, name377, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache178, null, false);
		string name378 = "ErrCodeArenaInSettleTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaInSettleTime);
		}
		LuaObject.addMember(l, name378, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache179, null, false);
		string name379 = "ErrCodeArenaNotInReady";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaNotInReady);
		}
		LuaObject.addMember(l, name379, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17A, null, false);
		string name380 = "ErrCodeArenaRevengeCheat";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaRevengeCheat);
		}
		LuaObject.addMember(l, name380, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17B, null, false);
		string name381 = "ErrCodeArenaException";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeArenaException);
		}
		LuaObject.addMember(l, name381, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17C, null, false);
		string name382 = "ErrCodeHeroAssistantTaskLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantTaskLocked);
		}
		LuaObject.addMember(l, name382, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17D, null, false);
		string name383 = "ErrCodeHeroAssistantTaskNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantTaskNotExist);
		}
		LuaObject.addMember(l, name383, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17E, null, false);
		string name384 = "ErrCodeHeroAssistantHeroNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroNotExist);
		}
		LuaObject.addMember(l, name384, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache17F, null, false);
		string name385 = "ErrCodeHeroAssistantHeroAssigned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroAssigned);
		}
		LuaObject.addMember(l, name385, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache180, null, false);
		string name386 = "ErrCodeHeroAssistantTaskInProcess";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantTaskInProcess);
		}
		LuaObject.addMember(l, name386, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache181, null, false);
		string name387 = "ErrCodeHeroAssistantHeroUnAssigned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroUnAssigned);
		}
		LuaObject.addMember(l, name387, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache182, null, false);
		string name388 = "ErrCodeHeroAssistantHeroTaskUnfinished";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroTaskUnfinished);
		}
		LuaObject.addMember(l, name388, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache183, null, false);
		string name389 = "ErrCodeHeroAssistantHeroTaskRewardsClaimed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroTaskRewardsClaimed);
		}
		LuaObject.addMember(l, name389, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache184, null, false);
		string name390 = "ErrCodeHeroAssistantHeroAssignCountMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantHeroAssignCountMax);
		}
		LuaObject.addMember(l, name390, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache185, null, false);
		string name391 = "ErrCodeHeroAssistantWorkHourTooShort";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantWorkHourTooShort);
		}
		LuaObject.addMember(l, name391, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache186, null, false);
		string name392 = "ErrCodeHeroAssistantNoHeroAssigned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantNoHeroAssigned);
		}
		LuaObject.addMember(l, name392, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache187, null, false);
		string name393 = "ErrCodeHeroAssistantTaskAssignmentSlotFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroAssistantTaskAssignmentSlotFull);
		}
		LuaObject.addMember(l, name393, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache188, null, false);
		string name394 = "ErrCodeLimitedTimeExchangeOperationalActivityNotExistThisItemExchanger";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLimitedTimeExchangeOperationalActivityNotExistThisItemExchanger);
		}
		LuaObject.addMember(l, name394, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache189, null, false);
		string name395 = "ErrCodeLimitedTimeExchangeOperationalActivityThisItemExchangeTimesNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLimitedTimeExchangeOperationalActivityThisItemExchangeTimesNotEnough);
		}
		LuaObject.addMember(l, name395, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18A, null, false);
		string name396 = "ErrCodeAwardOperationalActivityNotThisReward";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityNotThisReward);
		}
		LuaObject.addMember(l, name396, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18B, null, false);
		string name397 = "ErrCodeOperationalActivityRewardRepeatedlyGain";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperationalActivityRewardRepeatedlyGain);
		}
		LuaObject.addMember(l, name397, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18C, null, false);
		string name398 = "ErrCodeThisOperationalActivityNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThisOperationalActivityNotExist);
		}
		LuaObject.addMember(l, name398, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18D, null, false);
		string name399 = "ErrCodeNotAwardOperationalActivityCannotGainReward";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotAwardOperationalActivityCannotGainReward);
		}
		LuaObject.addMember(l, name399, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18E, null, false);
		string name400 = "ErrCodeOperationalActivityIsNotInOperationPeriod";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperationalActivityIsNotInOperationPeriod);
		}
		LuaObject.addMember(l, name400, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache18F, null, false);
		string name401 = "ErrCodeAwardOperationalActivityCannotGainRewardInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityCannotGainRewardInCurrentTime);
		}
		LuaObject.addMember(l, name401, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache190, null, false);
		string name402 = "ErrCodeAwardOperationalActivityPlayerLevelIsTooLow";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityPlayerLevelIsTooLow);
		}
		LuaObject.addMember(l, name402, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache191, null, false);
		string name403 = "ErrCodeAwardOperationalActivityNotLoginSpecificDays";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityNotLoginSpecificDays);
		}
		LuaObject.addMember(l, name403, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache192, null, false);
		string name404 = "ErrCodeAwardOperationalActivityNotReachAccumulateLoginDays";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityNotReachAccumulateLoginDays);
		}
		LuaObject.addMember(l, name404, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache193, null, false);
		string name405 = "ErrCodeAwardOperationalActivityRewardItemGroupIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityRewardItemGroupIdError);
		}
		LuaObject.addMember(l, name405, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache194, null, false);
		string name406 = "ErrCodeAwardOperationalActivityGainRewardTimeOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAwardOperationalActivityGainRewardTimeOut);
		}
		LuaObject.addMember(l, name406, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache195, null, false);
		string name407 = "ErrCodeNotLimitedTimeExchangeOperationalActivityCanExchangeItem";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotLimitedTimeExchangeOperationalActivityCanExchangeItem);
		}
		LuaObject.addMember(l, name407, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache196, null, false);
		string name408 = "ErrCodeUnknownOperationalActivity";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnknownOperationalActivity);
		}
		LuaObject.addMember(l, name408, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache197, null, false);
		string name409 = "ErroCodeOperationalActivityTimeConflict";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErroCodeOperationalActivityTimeConflict);
		}
		LuaObject.addMember(l, name409, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache198, null, false);
		string name410 = "ErrCodeAnnouncementTimeOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnnouncementTimeOut);
		}
		LuaObject.addMember(l, name410, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache199, null, false);
		string name411 = "ErrCodeOperactionalActivityTimeOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperactionalActivityTimeOut);
		}
		LuaObject.addMember(l, name411, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19A, null, false);
		string name412 = "ErrCodeAnnouncementNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnnouncementNotExist);
		}
		LuaObject.addMember(l, name412, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19B, null, false);
		string name413 = "ErrCodeRaffleItemsAllDrawd";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRaffleItemsAllDrawd);
		}
		LuaObject.addMember(l, name413, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19C, null, false);
		string name414 = "ErrCodeRaffleNotEnoughDrawItem";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRaffleNotEnoughDrawItem);
		}
		LuaObject.addMember(l, name414, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19D, null, false);
		string name415 = "ErrCodeNotRechargeEnoughRMB";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotRechargeEnoughRMB);
		}
		LuaObject.addMember(l, name415, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19E, null, false);
		string name416 = "ErrCodeNotConsumeEnoughCrystal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotConsumeEnoughCrystal);
		}
		LuaObject.addMember(l, name416, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache19F, null, false);
		string name417 = "ErrCodeAddSameEffectOpaerationalActivity";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAddSameEffectOpaerationalActivity);
		}
		LuaObject.addMember(l, name417, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A0, null, false);
		string name418 = "ErrCodeOpeningServerActivityCannotUpdate";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOpeningServerActivityCannotUpdate);
		}
		LuaObject.addMember(l, name418, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A1, null, false);
		string name419 = "ErrCodeOperacitivityTimeParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperacitivityTimeParmError);
		}
		LuaObject.addMember(l, name419, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A2, null, false);
		string name420 = "ErrCodeGmPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGmPlayerNotExist);
		}
		LuaObject.addMember(l, name420, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A3, null, false);
		string name421 = "ErrCodeGmDecreaseMoneyNumsError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGmDecreaseMoneyNumsError);
		}
		LuaObject.addMember(l, name421, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A4, null, false);
		string name422 = "ErrCodeGmMoneyTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGmMoneyTypeError);
		}
		LuaObject.addMember(l, name422, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A5, null, false);
		string name423 = "ErrCodeGmDecreaseGoodsTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGmDecreaseGoodsTypeError);
		}
		LuaObject.addMember(l, name423, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A6, null, false);
		string name424 = "ErrCodeGmDecreaseGoodsNumsError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGmDecreaseGoodsNumsError);
		}
		LuaObject.addMember(l, name424, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A7, null, false);
		string name425 = "ErrCodeGameFunctionIsLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGameFunctionIsLocked);
		}
		LuaObject.addMember(l, name425, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A8, null, false);
		string name426 = "ErrCodeSurveyRewardRepeatedlyGain";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSurveyRewardRepeatedlyGain);
		}
		LuaObject.addMember(l, name426, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1A9, null, false);
		string name427 = "ErrCodeSurveyNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSurveyNotExist);
		}
		LuaObject.addMember(l, name427, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AA, null, false);
		string name428 = "ErrCodeSurveyNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSurveyNotOpen);
		}
		LuaObject.addMember(l, name428, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AB, null, false);
		string name429 = "ErrCodeRepeatedOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRepeatedOpen);
		}
		LuaObject.addMember(l, name429, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AC, null, false);
		string name430 = "ErrCodeWriteSurveyPlayerLevelNotEnought";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWriteSurveyPlayerLevelNotEnought);
		}
		LuaObject.addMember(l, name430, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AD, null, false);
		string name431 = "ErrCodeSurveyTimeConflict";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSurveyTimeConflict);
		}
		LuaObject.addMember(l, name431, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AE, null, false);
		string name432 = "ErrCodeGlobalSurveyRepeatedlyAdd";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGlobalSurveyRepeatedlyAdd);
		}
		LuaObject.addMember(l, name432, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1AF, null, false);
		string name433 = "ErrorCodeTreasureMapNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeTreasureMapNotEnough);
		}
		LuaObject.addMember(l, name433, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B0, null, false);
		string name434 = "ErrCodeTreasureLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTreasureLevelNotExist);
		}
		LuaObject.addMember(l, name434, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B1, null, false);
		string name435 = "ErrCodeTreasureLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTreasureLevelBattleIdError);
		}
		LuaObject.addMember(l, name435, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B2, null, false);
		string name436 = "ErrCodeTeasureMapFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeasureMapFunctionNotOpen);
		}
		LuaObject.addMember(l, name436, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B3, null, false);
		string name437 = "ErrCodeDanmakuGameFunctionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDanmakuGameFunctionTypeError);
		}
		LuaObject.addMember(l, name437, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B4, null, false);
		string name438 = "ErrCodeDanmakuLocationIdNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDanmakuLocationIdNotExsit);
		}
		LuaObject.addMember(l, name438, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B5, null, false);
		string name439 = "ErrCodeDanmakuBattleTurnOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDanmakuBattleTurnOutOfRange);
		}
		LuaObject.addMember(l, name439, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B6, null, false);
		string name440 = "ErrCodeDanmakuNotUniqueOrSorted";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDanmakuNotUniqueOrSorted);
		}
		LuaObject.addMember(l, name440, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B7, null, false);
		string name441 = "ErrorCodeMemoryCorridorTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrorCodeMemoryCorridorTicketNotEnough);
		}
		LuaObject.addMember(l, name441, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B8, null, false);
		string name442 = "ErrCodeMemoryCorridorLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryCorridorLevelNotExist);
		}
		LuaObject.addMember(l, name442, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1B9, null, false);
		string name443 = "ErrCodeMemoryCorridorLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryCorridorLevelBattleIdError);
		}
		LuaObject.addMember(l, name443, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BA, null, false);
		string name444 = "ErrCodeMemoryCorridorLevelNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryCorridorLevelNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name444, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BB, null, false);
		string name445 = "ErrCodeMemoryCorridorNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryCorridorNotOpen);
		}
		LuaObject.addMember(l, name445, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BC, null, false);
		string name446 = "ErrCodeMemoryCorridorFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMemoryCorridorFunctionNotOpen);
		}
		LuaObject.addMember(l, name446, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BD, null, false);
		string name447 = "ErrCodeHeroDungeonLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelNotExist);
		}
		LuaObject.addMember(l, name447, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BE, null, false);
		string name448 = "ErrCodePreHeroDungeonLevelNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePreHeroDungeonLevelNotComplete);
		}
		LuaObject.addMember(l, name448, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1BF, null, false);
		string name449 = "ErrCodeHeroDungeonLevelUnlockConditionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelUnlockConditionTypeError);
		}
		LuaObject.addMember(l, name449, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C0, null, false);
		string name450 = "ErrCodeUnlockHeroDungeonLevelHeroFavorabilityLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnlockHeroDungeonLevelHeroFavorabilityLevelNotEnough);
		}
		LuaObject.addMember(l, name450, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C1, null, false);
		string name451 = "ErrCodeHeroDungeonLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelBattleIdError);
		}
		LuaObject.addMember(l, name451, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C2, null, false);
		string name452 = "ErrCodeHeroDungeonLevelAttackNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelAttackNumsNotEnough);
		}
		LuaObject.addMember(l, name452, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C3, null, false);
		string name453 = "ErrCodeHeroDungeonLevelNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelNotComplete);
		}
		LuaObject.addMember(l, name453, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C4, null, false);
		string name454 = "ErrCodeHeroDungeonLevelStarNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelStarNotEnough);
		}
		LuaObject.addMember(l, name454, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C5, null, false);
		string name455 = "ErrCodeHeroDungeonChapterNotAttack";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonChapterNotAttack);
		}
		LuaObject.addMember(l, name455, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C6, null, false);
		string name456 = "ErrCodeHeroDungeonLevelChapterIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelChapterIdError);
		}
		LuaObject.addMember(l, name456, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C7, null, false);
		string name457 = "ErrCodeGainHeroDungeonChapterStarRewardIndexError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGainHeroDungeonChapterStarRewardIndexError);
		}
		LuaObject.addMember(l, name457, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C8, null, false);
		string name458 = "ErrCodeHeroDungeonChapterStarsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonChapterStarsNotEnough);
		}
		LuaObject.addMember(l, name458, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1C9, null, false);
		string name459 = "ErrCodeHeroDungeonChapterStarRewardRepeatedlyGot";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonChapterStarRewardRepeatedlyGot);
		}
		LuaObject.addMember(l, name459, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CA, null, false);
		string name460 = "ErrCodeHeroDungeonLevelRaidParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelRaidParamError);
		}
		LuaObject.addMember(l, name460, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CB, null, false);
		string name461 = "ErrCodeHeroDungeonFunctioinNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonFunctioinNotOpen);
		}
		LuaObject.addMember(l, name461, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CC, null, false);
		string name462 = "ErrCodeHeroDungeonGainChapterIndexParmOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonGainChapterIndexParmOutOfRange);
		}
		LuaObject.addMember(l, name462, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CD, null, false);
		string name463 = "ErrCodeHeroFetterFunctioinNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFetterFunctioinNotOpen);
		}
		LuaObject.addMember(l, name463, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CE, null, false);
		string name464 = "ErrCodeTodayChallengeNumsUsedOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTodayChallengeNumsUsedOut);
		}
		LuaObject.addMember(l, name464, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1CF, null, false);
		string name465 = "ErrCodeTeamGameFunctionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamGameFunctionTypeError);
		}
		LuaObject.addMember(l, name465, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D0, null, false);
		string name466 = "ErrCodeTeamLocationIdNotFinished";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamLocationIdNotFinished);
		}
		LuaObject.addMember(l, name466, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D1, null, false);
		string name467 = "ErrCodeTeamLevelOutofRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamLevelOutofRange);
		}
		LuaObject.addMember(l, name467, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D2, null, false);
		string name468 = "ErrCodeTeamMemberNumsIsFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamMemberNumsIsFull);
		}
		LuaObject.addMember(l, name468, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D3, null, false);
		string name469 = "ErrCodeTeamPlayerHasBeenJoined";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamPlayerHasBeenJoined);
		}
		LuaObject.addMember(l, name469, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D4, null, false);
		string name470 = "ErrCodeTeamTheyAreNotSocialRelation";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamTheyAreNotSocialRelation);
		}
		LuaObject.addMember(l, name470, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D5, null, false);
		string name471 = "ErrCodeTeamRoomNotPublic";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamRoomNotPublic);
		}
		LuaObject.addMember(l, name471, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D6, null, false);
		string name472 = "ErrCodeTeamLevelNotFinished";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamLevelNotFinished);
		}
		LuaObject.addMember(l, name472, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D7, null, false);
		string name473 = "ErrCodeTeamAlreadyInTeam";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamAlreadyInTeam);
		}
		LuaObject.addMember(l, name473, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D8, null, false);
		string name474 = "ErrCodeTeamServerNetError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamServerNetError);
		}
		LuaObject.addMember(l, name474, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1D9, null, false);
		string name475 = "ErrCodeTeamRoomSettingAuthorityOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamRoomSettingAuthorityOutOfRange);
		}
		LuaObject.addMember(l, name475, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DA, null, false);
		string name476 = "ErrCodeTeamRoomSettingLevelOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamRoomSettingLevelOutOfRange);
		}
		LuaObject.addMember(l, name476, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DB, null, false);
		string name477 = "ErrCodeTeamViewTeamRoomGameFunctionTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamViewTeamRoomGameFunctionTypeError);
		}
		LuaObject.addMember(l, name477, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DC, null, false);
		string name478 = "ErrCodeTeamCancelAutoMatchNotInWaiting";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamCancelAutoMatchNotInWaiting);
		}
		LuaObject.addMember(l, name478, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DD, null, false);
		string name479 = "ErrCodeTeamNotInRoom";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamNotInRoom);
		}
		LuaObject.addMember(l, name479, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DE, null, false);
		string name480 = "ErrCodeTeamChangeAuthorityNotLeader";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamChangeAuthorityNotLeader);
		}
		LuaObject.addMember(l, name480, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1DF, null, false);
		string name481 = "ErrCodeTeamRoomIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamRoomIdNotExist);
		}
		LuaObject.addMember(l, name481, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E0, null, false);
		string name482 = "ErrCodeTeamJoinRoomSettingNotMatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamJoinRoomSettingNotMatch);
		}
		LuaObject.addMember(l, name482, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E1, null, false);
		string name483 = "ErrCodeTeamJoinRoomAuthorityNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamJoinRoomAuthorityNotEnough);
		}
		LuaObject.addMember(l, name483, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E2, null, false);
		string name484 = "ErrCodeTeamNotInTeam";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamNotInTeam);
		}
		LuaObject.addMember(l, name484, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E3, null, false);
		string name485 = "ErrCodeTeamChannelIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamChannelIdNotExist);
		}
		LuaObject.addMember(l, name485, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E4, null, false);
		string name486 = "ErrCodeTeamInvitationNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamInvitationNotExist);
		}
		LuaObject.addMember(l, name486, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E5, null, false);
		string name487 = "ErrCodeTeamInviteFriendNotOnline";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamInviteFriendNotOnline);
		}
		LuaObject.addMember(l, name487, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E6, null, false);
		string name488 = "ErrCodeTeamInviteTooBusy";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamInviteTooBusy);
		}
		LuaObject.addMember(l, name488, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E7, null, false);
		string name489 = "ErrCodeTeamCreateBattleRoomPermissionDenied";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamCreateBattleRoomPermissionDenied);
		}
		LuaObject.addMember(l, name489, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E8, null, false);
		string name490 = "ErrCodeTeamCannotFindSuitableBattleServer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamCannotFindSuitableBattleServer);
		}
		LuaObject.addMember(l, name490, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1E9, null, false);
		string name491 = "ErrCodeTeamCreateBattleRoomPlayerNumsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamCreateBattleRoomPlayerNumsNotEnough);
		}
		LuaObject.addMember(l, name491, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EA, null, false);
		string name492 = "ErrCodeTeamViewTeamRoomChapterIdNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamViewTeamRoomChapterIdNotExist);
		}
		LuaObject.addMember(l, name492, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EB, null, false);
		string name493 = "ErrCodeTeamGetInviteeLevelInfoNumsOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamGetInviteeLevelInfoNumsOutOfRange);
		}
		LuaObject.addMember(l, name493, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EC, null, false);
		string name494 = "ErrCodeTeamChangePositionNotLeader";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1ED == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1ED = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamChangePositionNotLeader);
		}
		LuaObject.addMember(l, name494, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1ED, null, false);
		string name495 = "ErrCodeTeamChangePositionParamError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTeamChangePositionParamError);
		}
		LuaObject.addMember(l, name495, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EE, null, false);
		string name496 = "ErrCodeFriendFriendsFullError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendFriendsFullError);
		}
		LuaObject.addMember(l, name496, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1EF, null, false);
		string name497 = "ErrCodeFriendTargetFriendsFullError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendTargetFriendsFullError);
		}
		LuaObject.addMember(l, name497, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F0, null, false);
		string name498 = "ErrCodeFriendInvitationFullError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendInvitationFullError);
		}
		LuaObject.addMember(l, name498, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F1, null, false);
		string name499 = "ErrCodeFriendAlreadyFriendError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadyFriendError);
		}
		LuaObject.addMember(l, name499, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F2, null, false);
		string name500 = "ErrCodeFriendCannotBecomeFriendsWhenBlocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotBecomeFriendsWhenBlocked);
		}
		LuaObject.addMember(l, name500, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F3, null, false);
		string name501 = "ErrCodeFriendCannotInviteBlockedPlayer";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteBlockedPlayer);
		}
		LuaObject.addMember(l, name501, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F4, null, false);
		string name502 = "ErrCodeFriendCannotInviteWhenBlocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteWhenBlocked);
		}
		LuaObject.addMember(l, name502, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F5, null, false);
		string name503 = "ErrCodeFriendCannotBlockFriend";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotBlockFriend);
		}
		LuaObject.addMember(l, name503, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F6, null, false);
		string name504 = "ErrCodeFriendServerNetError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendServerNetError);
		}
		LuaObject.addMember(l, name504, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F7, null, false);
		string name505 = "ErrCodeCannotSendLikesToSelf";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCannotSendLikesToSelf);
		}
		LuaObject.addMember(l, name505, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F8, null, false);
		string name506 = "ErrCodeHasSendLikesToday";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHasSendLikesToday);
		}
		LuaObject.addMember(l, name506, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1F9, null, false);
		string name507 = "ErrCodeSelectPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSelectPlayerNotExist);
		}
		LuaObject.addMember(l, name507, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FA, null, false);
		string name508 = "ErrCodeBusinessCardDescIsNullOrIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBusinessCardDescIsNullOrIllegal);
		}
		LuaObject.addMember(l, name508, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FB, null, false);
		string name509 = "ErrCodeBusineddCardDescTooLong";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBusineddCardDescTooLong);
		}
		LuaObject.addMember(l, name509, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FC, null, false);
		string name510 = "ErrCodeBusinessCardHeroSetIsNull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBusinessCardHeroSetIsNull);
		}
		LuaObject.addMember(l, name510, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FD, null, false);
		string name511 = "ErrCodeFriendServerNotFound";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendServerNotFound);
		}
		LuaObject.addMember(l, name511, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FE, null, false);
		string name512 = "ErrCodeTargetGameServerNotFound";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTargetGameServerNotFound);
		}
		LuaObject.addMember(l, name512, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache1FF, null, false);
		string name513 = "ErrCodeGSToFSRpcOperationFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache200 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache200 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGSToFSRpcOperationFail);
		}
		LuaObject.addMember(l, name513, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache200, null, false);
		string name514 = "ErrCodeFriendCannotInviteYourself";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache201 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache201 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteYourself);
		}
		LuaObject.addMember(l, name514, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache201, null, false);
		string name515 = "ErrCodeFriendInviteSameUser";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache202 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache202 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendInviteSameUser);
		}
		LuaObject.addMember(l, name515, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache202, null, false);
		string name516 = "ErrCodeFriendAlreadyInvited";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache203 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache203 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadyInvited);
		}
		LuaObject.addMember(l, name516, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache203, null, false);
		string name517 = "ErrCodeFriendPracticeTargetNotOnline";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache204 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache204 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendPracticeTargetNotOnline);
		}
		LuaObject.addMember(l, name517, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache204, null, false);
		string name518 = "ErrCodeFriendNotYourFriend";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache205 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache205 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendNotYourFriend);
		}
		LuaObject.addMember(l, name518, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache205, null, false);
		string name519 = "ErrCodeFriendAlreadySentFriendshipPoints";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache206 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache206 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadySentFriendshipPoints);
		}
		LuaObject.addMember(l, name519, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache206, null, false);
		string name520 = "ErrCodeFriendAlreadyReceivedFriendshipPoints";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache207 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache207 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadyReceivedFriendshipPoints);
		}
		LuaObject.addMember(l, name520, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache207, null, false);
		string name521 = "ErrCodeFriendSentFriendshipPointsTooManyTimes";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache208 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache208 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendSentFriendshipPointsTooManyTimes);
		}
		LuaObject.addMember(l, name521, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache208, null, false);
		string name522 = "ErrCodeFriendReceiveFriendshipPointsTooManyTimes";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache209 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache209 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendReceiveFriendshipPointsTooManyTimes);
		}
		LuaObject.addMember(l, name522, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache209, null, false);
		string name523 = "ErrCodeFriendReceiveFriendshipPointsSenderNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendReceiveFriendshipPointsSenderNotExist);
		}
		LuaObject.addMember(l, name523, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20A, null, false);
		string name524 = "ErrCodeFriendBlackListFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendBlackListFull);
		}
		LuaObject.addMember(l, name524, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20B, null, false);
		string name525 = "ErrCodeFriendTargetFriendsFullErrorBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendTargetFriendsFullErrorBatch);
		}
		LuaObject.addMember(l, name525, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20C, null, false);
		string name526 = "ErrCodeFriendInvitationFullErrorBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendInvitationFullErrorBatch);
		}
		LuaObject.addMember(l, name526, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20D, null, false);
		string name527 = "ErrCodeFriendAlreadyFriendErrorBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadyFriendErrorBatch);
		}
		LuaObject.addMember(l, name527, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20E, null, false);
		string name528 = "ErrCodeFriendCannotInviteBlockedPlayerBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteBlockedPlayerBatch);
		}
		LuaObject.addMember(l, name528, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache20F, null, false);
		string name529 = "ErrCodeFriendCannotInviteWhenBlockedBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache210 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache210 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteWhenBlockedBatch);
		}
		LuaObject.addMember(l, name529, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache210, null, false);
		string name530 = "ErrCodeFriendCannotInviteYourselfBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache211 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache211 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotInviteYourselfBatch);
		}
		LuaObject.addMember(l, name530, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache211, null, false);
		string name531 = "ErrCodeFriendInviteSameUserBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache212 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache212 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendInviteSameUserBatch);
		}
		LuaObject.addMember(l, name531, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache212, null, false);
		string name532 = "ErrCodeFriendAlreadyInvitedBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache213 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache213 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendAlreadyInvitedBatch);
		}
		LuaObject.addMember(l, name532, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache213, null, false);
		string name533 = "ErrCodeFriendFriendsFullErrorBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache214 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache214 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendFriendsFullErrorBatch);
		}
		LuaObject.addMember(l, name533, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache214, null, false);
		string name534 = "ErrCodeFriendCannotBecomeFriendsWhenBlockedBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache215 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache215 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotBecomeFriendsWhenBlockedBatch);
		}
		LuaObject.addMember(l, name534, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache215, null, false);
		string name535 = "ErrCodeFriendCannotBlockMyself";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache216 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache216 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendCannotBlockMyself);
		}
		LuaObject.addMember(l, name535, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache216, null, false);
		string name536 = "ErrCodeFriendBusinessCardDescBanned";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache217 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache217 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendBusinessCardDescBanned);
		}
		LuaObject.addMember(l, name536, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache217, null, false);
		string name537 = "ErrCodeFriendUnknown";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache218 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache218 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFriendUnknown);
		}
		LuaObject.addMember(l, name537, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache218, null, false);
		string name538 = "ErrCodeRankingListQuerySingleHeroIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache219 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache219 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRankingListQuerySingleHeroIdError);
		}
		LuaObject.addMember(l, name538, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache219, null, false);
		string name539 = "ErrCodeRankingListQueryLevelLimit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRankingListQueryLevelLimit);
		}
		LuaObject.addMember(l, name539, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21A, null, false);
		string name540 = "ErrCodeRankingListQueryPeriodLimit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRankingListQueryPeriodLimit);
		}
		LuaObject.addMember(l, name540, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21B, null, false);
		string name541 = "ErrCodeRankingListQueryUnknown";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRankingListQueryUnknown);
		}
		LuaObject.addMember(l, name541, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21C, null, false);
		string name542 = "ErrCodeSearchRankingListTypeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSearchRankingListTypeError);
		}
		LuaObject.addMember(l, name542, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21D, null, false);
		string name543 = "ErrCodeHeroTrainningNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningNotOpen);
		}
		LuaObject.addMember(l, name543, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21E, null, false);
		string name544 = "ErrCodeHeroTrainningLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningLevelNotExist);
		}
		LuaObject.addMember(l, name544, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache21F, null, false);
		string name545 = "ErrCodeHeroTrainningLevelNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache220 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache220 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningLevelNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name545, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache220, null, false);
		string name546 = "ErrCodeHeroTrainningChallengeNumsReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache221 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache221 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningChallengeNumsReachMax);
		}
		LuaObject.addMember(l, name546, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache221, null, false);
		string name547 = "ErrCodeHeroTrainningLevelIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache222 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache222 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningLevelIdError);
		}
		LuaObject.addMember(l, name547, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache222, null, false);
		string name548 = "ErrCodeHeroTrainningChallengeCountUseOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache223 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache223 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningChallengeCountUseOut);
		}
		LuaObject.addMember(l, name548, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache223, null, false);
		string name549 = "ErrCodeHeroTrainningLevelBattleIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache224 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache224 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningLevelBattleIdError);
		}
		LuaObject.addMember(l, name549, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache224, null, false);
		string name550 = "ErrCodeHeroTrainningTicketNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache225 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache225 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningTicketNotEnough);
		}
		LuaObject.addMember(l, name550, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache225, null, false);
		string name551 = "ErrCodeHeroTrainningFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache226 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache226 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroTrainningFunctionNotOpen);
		}
		LuaObject.addMember(l, name551, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache226, null, false);
		string name552 = "ErrCodeChatGroupCreateFailed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache227 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache227 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupCreateFailed);
		}
		LuaObject.addMember(l, name552, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache227, null, false);
		string name553 = "ErrCodeChatGroupFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache228 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache228 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupFull);
		}
		LuaObject.addMember(l, name553, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache228, null, false);
		string name554 = "ErrCodeChatGroupMemberFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache229 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache229 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupMemberFull);
		}
		LuaObject.addMember(l, name554, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache229, null, false);
		string name555 = "ErrCodeChatGroupNotOwner";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupNotOwner);
		}
		LuaObject.addMember(l, name555, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22A, null, false);
		string name556 = "ErrCodeChangeGroupOwnerFailed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChangeGroupOwnerFailed);
		}
		LuaObject.addMember(l, name556, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22B, null, false);
		string name557 = "ErrCodeChatGroupOwnerCannotLeave";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupOwnerCannotLeave);
		}
		LuaObject.addMember(l, name557, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22C, null, false);
		string name558 = "ErrCodeChatGroupNameIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupNameIllegal);
		}
		LuaObject.addMember(l, name558, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22D, null, false);
		string name559 = "ErrCodeChatGroupNameTooLong";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupNameTooLong);
		}
		LuaObject.addMember(l, name559, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22E, null, false);
		string name560 = "ErrCodeChatGroupTargetChatGroupFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupTargetChatGroupFull);
		}
		LuaObject.addMember(l, name560, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache22F, null, false);
		string name561 = "ErrCodeChatGroupNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache230 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache230 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupNotExist);
		}
		LuaObject.addMember(l, name561, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache230, null, false);
		string name562 = "ErrCodeChatGroupMemberFullBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache231 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache231 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupMemberFullBatch);
		}
		LuaObject.addMember(l, name562, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache231, null, false);
		string name563 = "ErrCodeChatGroupTargetChatGroupFullBatch";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache232 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache232 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChatGroupTargetChatGroupFullBatch);
		}
		LuaObject.addMember(l, name563, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache232, null, false);
		string name564 = "ErrCodeHeroPhantomNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache233 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache233 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroPhantomNotOpen);
		}
		LuaObject.addMember(l, name564, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache233, null, false);
		string name565 = "ErrCodeHeroPhantomLevelNotAvailable";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache234 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache234 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroPhantomLevelNotAvailable);
		}
		LuaObject.addMember(l, name565, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache234, null, false);
		string name566 = "ErrCodeHeroPhantomLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache235 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache235 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroPhantomLevelNotExist);
		}
		LuaObject.addMember(l, name566, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache235, null, false);
		string name567 = "ErrCodeCooperateBattleNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache236 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache236 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCooperateBattleNotOpen);
		}
		LuaObject.addMember(l, name567, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache236, null, false);
		string name568 = "ErrCodeCooperateBattleLevelNotAvailable";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache237 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache237 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCooperateBattleLevelNotAvailable);
		}
		LuaObject.addMember(l, name568, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache237, null, false);
		string name569 = "ErrCodeCooperateBattleLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache238 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache238 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCooperateBattleLevelNotExist);
		}
		LuaObject.addMember(l, name569, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache238, null, false);
		string name570 = "ErrCodeCooperateBattleFunctionNotOpen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache239 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache239 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCooperateBattleFunctionNotOpen);
		}
		LuaObject.addMember(l, name570, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache239, null, false);
		string name571 = "ErrCodeNoviceRewardNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNoviceRewardNotExist);
		}
		LuaObject.addMember(l, name571, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23A, null, false);
		string name572 = "ErrCodeNoviceRewardAlreadyClaimed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNoviceRewardAlreadyClaimed);
		}
		LuaObject.addMember(l, name572, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23B, null, false);
		string name573 = "ErrCodeNoviceMissionPointsNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNoviceMissionPointsNotEnough);
		}
		LuaObject.addMember(l, name573, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23C, null, false);
		string name574 = "ErrCodeMatchmakingTimeout";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMatchmakingTimeout);
		}
		LuaObject.addMember(l, name574, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23D, null, false);
		string name575 = "ErrCodeMatchmakingCancelFailed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMatchmakingCancelFailed);
		}
		LuaObject.addMember(l, name575, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23E, null, false);
		string name576 = "ErrCodeRealTimePVPWinsBonusNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPWinsBonusNotExist);
		}
		LuaObject.addMember(l, name576, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache23F, null, false);
		string name577 = "ErrCodeRealTimePVPWinsBonusAlreadyAcquired";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache240 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache240 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPWinsBonusAlreadyAcquired);
		}
		LuaObject.addMember(l, name577, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache240, null, false);
		string name578 = "ErrCodeRealTimePVPWinsBonusNotEnoughWins";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache241 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache241 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPWinsBonusNotEnoughWins);
		}
		LuaObject.addMember(l, name578, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache241, null, false);
		string name579 = "ErrCodeRealTimePVPGameFunctionLocked";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache242 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache242 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPGameFunctionLocked);
		}
		LuaObject.addMember(l, name579, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache242, null, false);
		string name580 = "ErrCodeRealTimePVPArenaClosed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache243 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache243 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRealTimePVPArenaClosed);
		}
		LuaObject.addMember(l, name580, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache243, null, false);
		string name581 = "ErrCodeMatchmakingAlreadyMatchmaking";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache244 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache244 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMatchmakingAlreadyMatchmaking);
		}
		LuaObject.addMember(l, name581, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache244, null, false);
		string name582 = "ErrCodeRechargeStoreGoodsNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache245 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache245 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRechargeStoreGoodsNotExist);
		}
		LuaObject.addMember(l, name582, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache245, null, false);
		string name583 = "ErrCodeRechargeStoreGoodsIsOnBanBuyingPeriod";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache246 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache246 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRechargeStoreGoodsIsOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, name583, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache246, null, false);
		string name584 = "ErrCodeRechargeStoreGoodsNotOnBanBuyingPeriod";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache247 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache247 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRechargeStoreGoodsNotOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, name584, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache247, null, false);
		string name585 = "ErrCodeRafflePoolNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache248 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache248 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRafflePoolNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name585, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache248, null, false);
		string name586 = "ErrCodeRafflePoolNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache249 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache249 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRafflePoolNotExist);
		}
		LuaObject.addMember(l, name586, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache249, null, false);
		string name587 = "ErrCodeResourceSkinNotExsit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeResourceSkinNotExsit);
		}
		LuaObject.addMember(l, name587, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24A, null, false);
		string name588 = "ErrCodeResourceSkinNotMatchHero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeResourceSkinNotMatchHero);
		}
		LuaObject.addMember(l, name588, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24B, null, false);
		string name589 = "ErrCodeResourceSkinNotMatchJob";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeResourceSkinNotMatchJob);
		}
		LuaObject.addMember(l, name589, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24C, null, false);
		string name590 = "ErrCodeResourceSkinNotMatchSoldier";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeResourceSkinNotMatchSoldier);
		}
		LuaObject.addMember(l, name590, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24D, null, false);
		string name591 = "ErrCodeResourceNoSkinWeared";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeResourceNoSkinWeared);
		}
		LuaObject.addMember(l, name591, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24E, null, false);
		string name592 = "ErrCodeGiftStoreItemNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreItemNotExist);
		}
		LuaObject.addMember(l, name592, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache24F, null, false);
		string name593 = "ErrCodeGiftStoreItemNotOnSaleTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache250 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache250 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreItemNotOnSaleTime);
		}
		LuaObject.addMember(l, name593, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache250, null, false);
		string name594 = "ErrCodeGiftStoreItemIsSellOut";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache251 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache251 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreItemIsSellOut);
		}
		LuaObject.addMember(l, name594, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache251, null, false);
		string name595 = "ErrCodeNotExistThisWaitPayingGoods";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache252 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache252 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotExistThisWaitPayingGoods);
		}
		LuaObject.addMember(l, name595, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache252, null, false);
		string name596 = "ErrCodeCheatBuyingFirstBuyGoods";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache253 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache253 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCheatBuyingFirstBuyGoods);
		}
		LuaObject.addMember(l, name596, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache253, null, false);
		string name597 = "ErrCodeGiftStoreItemAppleSubscribeAttributeError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache254 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache254 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreItemAppleSubscribeAttributeError);
		}
		LuaObject.addMember(l, name597, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache254, null, false);
		string name598 = "ErrCodeJustMonthCardCanBeAppleSubscribed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache255 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache255 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJustMonthCardCanBeAppleSubscribed);
		}
		LuaObject.addMember(l, name598, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache255, null, false);
		string name599 = "ErrCodeAppleSubscribeRepeatly";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache256 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache256 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAppleSubscribeRepeatly);
		}
		LuaObject.addMember(l, name599, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache256, null, false);
		string name600 = "ErrCodeCheatBuyingGiftStoreItem";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache257 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache257 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCheatBuyingGiftStoreItem);
		}
		LuaObject.addMember(l, name600, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache257, null, false);
		string name601 = "ErrCodeOperationalGoodsListIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache258 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache258 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperationalGoodsListIsEmpty);
		}
		LuaObject.addMember(l, name601, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache258, null, false);
		string name602 = "ErrCodeNotGiftStoreOperationalGoods";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache259 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache259 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotGiftStoreOperationalGoods);
		}
		LuaObject.addMember(l, name602, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache259, null, false);
		string name603 = "ErrCodeAppleSubscribeGoodsNotEqualToOne";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAppleSubscribeGoodsNotEqualToOne);
		}
		LuaObject.addMember(l, name603, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25A, null, false);
		string name604 = "ErrCodeWaitZilongCheckGoodsSubscribing";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeWaitZilongCheckGoodsSubscribing);
		}
		LuaObject.addMember(l, name604, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25B, null, false);
		string name605 = "ErrCodeGiftStoreGoodsIsOnBanBuyingPeriod";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreGoodsIsOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, name605, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25C, null, false);
		string name606 = "ErrCodeGiftStoreGoodsNotOnBanBuyingPeriod";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreGoodsNotOnBanBuyingPeriod);
		}
		LuaObject.addMember(l, name606, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25D, null, false);
		string name607 = "ErrCodeOrderNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOrderNotExist);
		}
		LuaObject.addMember(l, name607, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25E, null, false);
		string name608 = "ErrCodeGuildCreateLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildCreateLevelNotEnough);
		}
		LuaObject.addMember(l, name608, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache25F, null, false);
		string name609 = "ErrCodeGuildHasOwnGuild";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache260 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache260 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildHasOwnGuild);
		}
		LuaObject.addMember(l, name609, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache260, null, false);
		string name610 = "ErrCodeGuildPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache261 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache261 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildPlayerNotExist);
		}
		LuaObject.addMember(l, name610, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache261, null, false);
		string name611 = "ErrCodeGuildJoinCoolDown";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache262 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache262 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildJoinCoolDown);
		}
		LuaObject.addMember(l, name611, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache262, null, false);
		string name612 = "ErrCodeGuildNameDuplicate";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache263 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache263 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildNameDuplicate);
		}
		LuaObject.addMember(l, name612, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache263, null, false);
		string name613 = "ErrCodeGuildSearchTimeLimit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache264 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache264 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildSearchTimeLimit);
		}
		LuaObject.addMember(l, name613, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache264, null, false);
		string name614 = "ErrCodeGuildNameIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache265 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache265 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildNameIllegal);
		}
		LuaObject.addMember(l, name614, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache265, null, false);
		string name615 = "ErrCodePlayerNotInGuild";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache266 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache266 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotInGuild);
		}
		LuaObject.addMember(l, name615, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache266, null, false);
		string name616 = "ErrCodePlayerNotPresidentOrVicePresident";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache267 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache267 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotPresidentOrVicePresident);
		}
		LuaObject.addMember(l, name616, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache267, null, false);
		string name617 = "ErrCodeHiringDeclarationContentIsIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache268 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache268 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHiringDeclarationContentIsIllegal);
		}
		LuaObject.addMember(l, name617, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache268, null, false);
		string name618 = "ErrCodeHiringDeclarationLengthIsIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache269 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache269 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHiringDeclarationLengthIsIllegal);
		}
		LuaObject.addMember(l, name618, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache269, null, false);
		string name619 = "ErrCodeHiringDeclarationIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHiringDeclarationIsEmpty);
		}
		LuaObject.addMember(l, name619, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26A, null, false);
		string name620 = "ErrCodeGuildNameOutOfRange";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildNameOutOfRange);
		}
		LuaObject.addMember(l, name620, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26B, null, false);
		string name621 = "ErrCodePlayerNotPresident";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotPresident);
		}
		LuaObject.addMember(l, name621, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26C, null, false);
		string name622 = "ErrCodePlayerIsAlreadyVicePresident";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerIsAlreadyVicePresident);
		}
		LuaObject.addMember(l, name622, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26D, null, false);
		string name623 = "ErrCodeDestPlayerNotVicePresident";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDestPlayerNotVicePresident);
		}
		LuaObject.addMember(l, name623, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26E, null, false);
		string name624 = "ErrCodeGuildVicePresidentNumsReachMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildVicePresidentNumsReachMax);
		}
		LuaObject.addMember(l, name624, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache26F, null, false);
		string name625 = "ErrCodeDestPlayerNotPresident";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache270 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache270 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDestPlayerNotPresident);
		}
		LuaObject.addMember(l, name625, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache270, null, false);
		string name626 = "ErrCodePlayerNotVicePresidentOrElite";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache271 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache271 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotVicePresidentOrElite);
		}
		LuaObject.addMember(l, name626, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache271, null, false);
		string name627 = "ErrCodeGuildPresidentNotOfflineTooLong";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache272 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache272 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildPresidentNotOfflineTooLong);
		}
		LuaObject.addMember(l, name627, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache272, null, false);
		string name628 = "ErrCodeGuildNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache273 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache273 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildNotExist);
		}
		LuaObject.addMember(l, name628, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache273, null, false);
		string name629 = "ErrCodePlayerNotHaveThisGuildOperateJurisdiction";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache274 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache274 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerNotHaveThisGuildOperateJurisdiction);
		}
		LuaObject.addMember(l, name629, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache274, null, false);
		string name630 = "ErrCodeGuildAnnouncementContentIsIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache275 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache275 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildAnnouncementContentIsIllegal);
		}
		LuaObject.addMember(l, name630, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache275, null, false);
		string name631 = "ErrCodeGuildAnnouncementLengthIsIllegal";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache276 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache276 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildAnnouncementLengthIsIllegal);
		}
		LuaObject.addMember(l, name631, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache276, null, false);
		string name632 = "ErrCodeGuildMemberIsFull";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache277 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache277 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMemberIsFull);
		}
		LuaObject.addMember(l, name632, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache277, null, false);
		string name633 = "ErrCodeGuildJoinLevelNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache278 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache278 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildJoinLevelNotEnough);
		}
		LuaObject.addMember(l, name633, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache278, null, false);
		string name634 = "ErrCodeGuildJoinInvationNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache279 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache279 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildJoinInvationNotExist);
		}
		LuaObject.addMember(l, name634, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache279, null, false);
		string name635 = "ErrCodeGuildApplyNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildApplyNotExist);
		}
		LuaObject.addMember(l, name635, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27A, null, false);
		string name636 = "ErrCodeSetPlayerJoinLevelError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSetPlayerJoinLevelError);
		}
		LuaObject.addMember(l, name636, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27B, null, false);
		string name637 = "ErrCodeGuildPresidentCannotAppointSelf";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildPresidentCannotAppointSelf);
		}
		LuaObject.addMember(l, name637, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27C, null, false);
		string name638 = "ErrCodeGuildMassiveCombatMaxCombatsPerWeekExceeded";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatMaxCombatsPerWeekExceeded);
		}
		LuaObject.addMember(l, name638, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27D, null, false);
		string name639 = "ErrCodeGuildMassiveCombatOnlyPresidentCanStartCombat";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatOnlyPresidentCanStartCombat);
		}
		LuaObject.addMember(l, name639, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27E, null, false);
		string name640 = "ErrCodeGuildMassiveCombatMoreThanOneCombatNotAllowed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatMoreThanOneCombatNotAllowed);
		}
		LuaObject.addMember(l, name640, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache27F, null, false);
		string name641 = "ErrCodeGuildMassiveCombatAvailableMembersNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache280 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache280 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatAvailableMembersNotEnough);
		}
		LuaObject.addMember(l, name641, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache280, null, false);
		string name642 = "ErrCodeGuildMassiveCombatInvalidDifficulty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache281 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache281 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatInvalidDifficulty);
		}
		LuaObject.addMember(l, name642, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache281, null, false);
		string name643 = "ErrCodeGuildMassiveCombatNoExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache282 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache282 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatNoExist);
		}
		LuaObject.addMember(l, name643, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache282, null, false);
		string name644 = "ErrCodeGuildMassiveCombatCannotParticipateInDifferentGuild";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache283 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache283 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatCannotParticipateInDifferentGuild);
		}
		LuaObject.addMember(l, name644, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache283, null, false);
		string name645 = "ErrCodeGuildMassiveCombatHeroAlreadyUsed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache284 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache284 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatHeroAlreadyUsed);
		}
		LuaObject.addMember(l, name645, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache284, null, false);
		string name646 = "ErrCodeGuildMassiveCombatStrongholdTaken";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache285 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache285 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatStrongholdTaken);
		}
		LuaObject.addMember(l, name646, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache285, null, false);
		string name647 = "ErrCodeGuildMedalNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache286 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache286 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMedalNotEnough);
		}
		LuaObject.addMember(l, name647, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache286, null, false);
		string name648 = "ErrCodeGuildMassiveCombatLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache287 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache287 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatLevelNotExist);
		}
		LuaObject.addMember(l, name648, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache287, null, false);
		string name649 = "ErrCodeGuildMassiveCombatOnlyPresidentAndVPCanSurrender";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache288 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache288 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGuildMassiveCombatOnlyPresidentAndVPCanSurrender);
		}
		LuaObject.addMember(l, name649, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache288, null, false);
		string name650 = "ErrCodeUnchartedScoreNotOpenInCurrentTime";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache289 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache289 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreNotOpenInCurrentTime);
		}
		LuaObject.addMember(l, name650, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache289, null, false);
		string name651 = "ErrCodeUnchartedScoreNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreNotExist);
		}
		LuaObject.addMember(l, name651, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28A, null, false);
		string name652 = "ErrCodeUnchartedScoreChallengeLevelNotContains";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreChallengeLevelNotContains);
		}
		LuaObject.addMember(l, name652, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28B, null, false);
		string name653 = "ErrCodeUnchartedScoreChallengeLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreChallengeLevelNotExist);
		}
		LuaObject.addMember(l, name653, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28C, null, false);
		string name654 = "ErrCodeUnchartedScoreChallengeLevelNotUnlock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreChallengeLevelNotUnlock);
		}
		LuaObject.addMember(l, name654, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28D, null, false);
		string name655 = "ErrCodeUnchartedScoreChallengeLevelAlreadyAttack";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreChallengeLevelAlreadyAttack);
		}
		LuaObject.addMember(l, name655, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28E, null, false);
		string name656 = "ErrCodeUnchartedScoreChallengeLevelPrevLevelNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreChallengeLevelPrevLevelNotComplete);
		}
		LuaObject.addMember(l, name656, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache28F, null, false);
		string name657 = "ErrCodeUnchartedScoreScoreLevelNotContains";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache290 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache290 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreScoreLevelNotContains);
		}
		LuaObject.addMember(l, name657, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache290, null, false);
		string name658 = "ErrCodeUnchartedScoreScoreLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache291 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache291 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreScoreLevelNotExist);
		}
		LuaObject.addMember(l, name658, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache291, null, false);
		string name659 = "ErrCodeUnchartedScoreScoreLevelPlayerLimit";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache292 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache292 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreScoreLevelPlayerLimit);
		}
		LuaObject.addMember(l, name659, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache292, null, false);
		string name660 = "ErrCodeUnchartedScoreScoreLevelAlreadyAttack";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache293 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache293 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreScoreLevelAlreadyAttack);
		}
		LuaObject.addMember(l, name660, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache293, null, false);
		string name661 = "ErrCodeUnchartedScoreScoreLevelUnLock";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache294 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache294 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreScoreLevelUnLock);
		}
		LuaObject.addMember(l, name661, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache294, null, false);
		string name662 = "ErrCodeUnchartedScoreRewardNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache295 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache295 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreRewardNotExist);
		}
		LuaObject.addMember(l, name662, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache295, null, false);
		string name663 = "ErrCodeUnchartedScoreRewardScoreNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache296 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache296 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreRewardScoreNotEnough);
		}
		LuaObject.addMember(l, name663, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache296, null, false);
		string name664 = "ErrCodeUnchartedScoreRewardGained";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache297 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache297 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreRewardGained);
		}
		LuaObject.addMember(l, name664, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache297, null, false);
		string name665 = "ErrCodeClimbTowerFloorIdInvalid";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache298 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache298 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerFloorIdInvalid);
		}
		LuaObject.addMember(l, name665, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache298, null, false);
		string name666 = "ErrCodeClimbTowerPrevFloorNotComplete";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache299 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache299 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerPrevFloorNotComplete);
		}
		LuaObject.addMember(l, name666, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache299, null, false);
		string name667 = "ErrCodeClimbTowerLevelNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerLevelNotExist);
		}
		LuaObject.addMember(l, name667, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29A, null, false);
		string name668 = "ErrCodeClimbTowerAlreadyFlush";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerAlreadyFlush);
		}
		LuaObject.addMember(l, name668, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29B, null, false);
		string name669 = "ErrCodeClimbTowerAttackCurFloorInvalid";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerAttackCurFloorInvalid);
		}
		LuaObject.addMember(l, name669, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29C, null, false);
		string name670 = "ErrCodeClimbTowerFloorNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerFloorNotExist);
		}
		LuaObject.addMember(l, name670, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29D, null, false);
		string name671 = "ErrCodeClimbTowerBonusHeroGroupNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerBonusHeroGroupNotExist);
		}
		LuaObject.addMember(l, name671, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29E, null, false);
		string name672 = "ErrCodeClimbTowerFloorConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerFloorConfigError);
		}
		LuaObject.addMember(l, name672, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache29F, null, false);
		string name673 = "ErrCodeClimbTowerBattleFinishFloorError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerBattleFinishFloorError);
		}
		LuaObject.addMember(l, name673, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A0, null, false);
		string name674 = "ErrCodeClimbTowerFloorCantRaid";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerFloorCantRaid);
		}
		LuaObject.addMember(l, name674, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A1, null, false);
		string name675 = "ErrCodeClimbTowerAlreadyReachTopTower";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeClimbTowerAlreadyReachTopTower);
		}
		LuaObject.addMember(l, name675, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A2, null, false);
		string name676 = "ErrCodeGoodsTypeRelatedIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGoodsTypeRelatedIdError);
		}
		LuaObject.addMember(l, name676, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A3, null, false);
		string name677 = "ErrCodeSignRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSignRewardIdError);
		}
		LuaObject.addMember(l, name677, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A4, null, false);
		string name678 = "ErrCodeChapterRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChapterRewardIdError);
		}
		LuaObject.addMember(l, name678, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A5, null, false);
		string name679 = "ErrCodeEventRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEventRewardIdError);
		}
		LuaObject.addMember(l, name679, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A6, null, false);
		string name680 = "ErrCodeRiftRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftRewardIdError);
		}
		LuaObject.addMember(l, name680, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A7, null, false);
		string name681 = "ErrCodeInitInfoRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeInitInfoRewardIdError);
		}
		LuaObject.addMember(l, name681, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A8, null, false);
		string name682 = "ErrCodeRandomDropRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomDropRewardIdError);
		}
		LuaObject.addMember(l, name682, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2A9, null, false);
		string name683 = "ErrCodeScenarioRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeScenarioRewardIdError);
		}
		LuaObject.addMember(l, name683, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AA, null, false);
		string name684 = "ErrCodeFreeCardPoolGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFreeCardPoolGoodsIdError);
		}
		LuaObject.addMember(l, name684, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AB, null, false);
		string name685 = "ErrCodeCrystalCardPoolGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalCardPoolGoodsIdError);
		}
		LuaObject.addMember(l, name685, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AC, null, false);
		string name686 = "ErrCodeActivityCardPoolGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolGoodsIdError);
		}
		LuaObject.addMember(l, name686, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AD, null, false);
		string name687 = "ErrCodeDefiniteGroupRandomEventTotalWeightNotEqualMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDefiniteGroupRandomEventTotalWeightNotEqualMax);
		}
		LuaObject.addMember(l, name687, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AE, null, false);
		string name688 = "ErrCodeRandomGroupTotalWeightNotEqualMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomGroupTotalWeightNotEqualMax);
		}
		LuaObject.addMember(l, name688, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2AF, null, false);
		string name689 = "ErrCodeRandomGroupRandomEventTotalWeightNotEqualMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomGroupRandomEventTotalWeightNotEqualMax);
		}
		LuaObject.addMember(l, name689, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B0, null, false);
		string name690 = "ErrCodeStoreWeightError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeStoreWeightError);
		}
		LuaObject.addMember(l, name690, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B1, null, false);
		string name691 = "ErrCodeFirstScenarioIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFirstScenarioIdError);
		}
		LuaObject.addMember(l, name691, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B2, null, false);
		string name692 = "ErrCodeSkillHitMaxAboveZeroTime_MultiHitCountBelowZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSkillHitMaxAboveZeroTime_MultiHitCountBelowZero);
		}
		LuaObject.addMember(l, name692, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B3, null, false);
		string name693 = "ErrCodeFlyItemSpeedNotAboveZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFlyItemSpeedNotAboveZero);
		}
		LuaObject.addMember(l, name693, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B4, null, false);
		string name694 = "ErrCodeHeroDefaultSkillsCostAboveHeroFirstLevelSkillPoint";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDefaultSkillsCostAboveHeroFirstLevelSkillPoint);
		}
		LuaObject.addMember(l, name694, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B5, null, false);
		string name695 = "ErrCodeDefiniteGroupLevelZoneNotEqualRandomEventLevelZoneConfig";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDefiniteGroupLevelZoneNotEqualRandomEventLevelZoneConfig);
		}
		LuaObject.addMember(l, name695, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B6, null, false);
		string name696 = "ErrCodeRandomGroupLevelZoneNotEqualRandomEventLevelZoneConfig";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomGroupLevelZoneNotEqualRandomEventLevelZoneConfig);
		}
		LuaObject.addMember(l, name696, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B7, null, false);
		string name697 = "ErrCodeCardPoolGroupTenSelectTotalMinCountIsAboveTen";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolGroupTenSelectTotalMinCountIsAboveTen);
		}
		LuaObject.addMember(l, name697, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B8, null, false);
		string name698 = "ErrCodeConstRandomEventTimeConfigError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeConstRandomEventTimeConfigError);
		}
		LuaObject.addMember(l, name698, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2B9, null, false);
		string name699 = "ErrCodeHeroJobUnlockConditionItemCostIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobUnlockConditionItemCostIdError);
		}
		LuaObject.addMember(l, name699, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BA, null, false);
		string name700 = "ErrCodeHeroJobUnlockConditionAchievementIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobUnlockConditionAchievementIdError);
		}
		LuaObject.addMember(l, name700, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BB, null, false);
		string name701 = "ErrCodeHeroJobUnlockPreJobNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroJobUnlockPreJobNotExist);
		}
		LuaObject.addMember(l, name701, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BC, null, false);
		string name702 = "ErrCodeStaticBoxIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeStaticBoxIdError);
		}
		LuaObject.addMember(l, name702, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BD, null, false);
		string name703 = "ErrCodeRandomBoxIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBoxIdError);
		}
		LuaObject.addMember(l, name703, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BE, null, false);
		string name704 = "ErrCodeRandomBoxMinCountAboveMaxCount";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBoxMinCountAboveMaxCount);
		}
		LuaObject.addMember(l, name704, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2BF, null, false);
		string name705 = "ErrCodeThearchyTrialLevelRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeThearchyTrialLevelRepeated);
		}
		LuaObject.addMember(l, name705, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C0, null, false);
		string name706 = "ErrCodeAnikiGymLevelRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAnikiGymLevelRepeated);
		}
		LuaObject.addMember(l, name706, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C1, null, false);
		string name707 = "ErrCodeHeroDefaultSkillIdCannotBeEquipedByDefaultJob";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDefaultSkillIdCannotBeEquipedByDefaultJob);
		}
		LuaObject.addMember(l, name707, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C2, null, false);
		string name708 = "ErrCodeFixedStoreItemShowTimeFormError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreItemShowTimeFormError);
		}
		LuaObject.addMember(l, name708, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C3, null, false);
		string name709 = "ErrCodeFixedStoreItemFirstRewardIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreItemFirstRewardIdError);
		}
		LuaObject.addMember(l, name709, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C4, null, false);
		string name710 = "ErrCodeFixedStoreSellItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreSellItemIdError);
		}
		LuaObject.addMember(l, name710, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C5, null, false);
		string name711 = "ErrCodeFixedStoreItemDiscountTimeFormError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFixedStoreItemDiscountTimeFormError);
		}
		LuaObject.addMember(l, name711, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C6, null, false);
		string name712 = "ErrCodeTrainingHouseArmyListError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingHouseArmyListError);
		}
		LuaObject.addMember(l, name712, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C7, null, false);
		string name713 = "ErrCodeTrainingHouseCoachNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingHouseCoachNotExist);
		}
		LuaObject.addMember(l, name713, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C8, null, false);
		string name714 = "ErrCodeCoachFavorabilityCoachNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityCoachNotExist);
		}
		LuaObject.addMember(l, name714, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2C9, null, false);
		string name715 = "ErrCodeCoachFavorabilityLevelError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityLevelError);
		}
		LuaObject.addMember(l, name715, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CA, null, false);
		string name716 = "ErrCodeCoachFavorabilityLevelUpCostItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityLevelUpCostItemIdError);
		}
		LuaObject.addMember(l, name716, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CB, null, false);
		string name717 = "ErrCodeAboveTwoTrainingHouseHasSameCoach";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAboveTwoTrainingHouseHasSameCoach);
		}
		LuaObject.addMember(l, name717, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CC, null, false);
		string name718 = "ErrCodeTrainingInstrumentStartLevelError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingInstrumentStartLevelError);
		}
		LuaObject.addMember(l, name718, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CD, null, false);
		string name719 = "ErrCodeCoachFavorabilityStartLevelError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityStartLevelError);
		}
		LuaObject.addMember(l, name719, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CE, null, false);
		string name720 = "ErrCodeCoachFavorabilityTableCoachTotalNumberNotEqualCoachTableNumbers";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityTableCoachTotalNumberNotEqualCoachTableNumbers);
		}
		LuaObject.addMember(l, name720, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2CF, null, false);
		string name721 = "ErrCodeCoachFavorabilityUnlockInstrumentIdNotInTrainingHouseInstrumentIDList";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCoachFavorabilityUnlockInstrumentIdNotInTrainingHouseInstrumentIDList);
		}
		LuaObject.addMember(l, name721, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D0, null, false);
		string name722 = "ErrCodeInitInfoContainProtagonistHeroId";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeInitInfoContainProtagonistHeroId);
		}
		LuaObject.addMember(l, name722, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D1, null, false);
		string name723 = "ErrCodeHeroInteractionInitialPleasureValueError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInteractionInitialPleasureValueError);
		}
		LuaObject.addMember(l, name723, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D2, null, false);
		string name724 = "ErrCodeHeroBodyZoneInitialToleranceValueError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroBodyZoneInitialToleranceValueError);
		}
		LuaObject.addMember(l, name724, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D3, null, false);
		string name725 = "ErrCodeFirstInitInfoNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFirstInitInfoNotExist);
		}
		LuaObject.addMember(l, name725, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D4, null, false);
		string name726 = "ErrCodeHerMaxLevelBelowPlayerMaxLevelCelling";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHerMaxLevelBelowPlayerMaxLevelCelling);
		}
		LuaObject.addMember(l, name726, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D5, null, false);
		string name727 = "ErrCodeRiftChapterContainsSameLevel";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRiftChapterContainsSameLevel);
		}
		LuaObject.addMember(l, name727, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D6, null, false);
		string name728 = "ErrCodeHeroHasInstanceLevelRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroHasInstanceLevelRepeated);
		}
		LuaObject.addMember(l, name728, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D7, null, false);
		string name729 = "ErrCodeHeroDungeonStarRewardItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonStarRewardItemIdError);
		}
		LuaObject.addMember(l, name729, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D8, null, false);
		string name730 = "ErrCodeHeroDungeonLevelAchievementRewardItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroDungeonLevelAchievementRewardItemIdError);
		}
		LuaObject.addMember(l, name730, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2D9, null, false);
		string name731 = "ErrCodePlayerMaxLevelAboveRandomEventLevelZoneMaxLeve";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerMaxLevelAboveRandomEventLevelZoneMaxLeve);
		}
		LuaObject.addMember(l, name731, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DA, null, false);
		string name732 = "ErrCodeHeroHasFetterRepeated";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroHasFetterRepeated);
		}
		LuaObject.addMember(l, name732, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DB, null, false);
		string name733 = "ErrCodeRandomStoreItemInfoLevelZoneIDError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomStoreItemInfoLevelZoneIDError);
		}
		LuaObject.addMember(l, name733, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DC, null, false);
		string name734 = "ErrCodePlayerLevelUpOperationalActivityItemGroupRewardParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodePlayerLevelUpOperationalActivityItemGroupRewardParmError);
		}
		LuaObject.addMember(l, name734, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DD, null, false);
		string name735 = "ErrCodeLimitedTimeExchangeOperationalActivityItemItemGroupParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLimitedTimeExchangeOperationalActivityItemItemGroupParmError);
		}
		LuaObject.addMember(l, name735, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DE, null, false);
		string name736 = "ErrCodeSpecificDaysLoginOperationalActivityItemGroupRewardParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSpecificDaysLoginOperationalActivityItemGroupRewardParmError);
		}
		LuaObject.addMember(l, name736, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2DF, null, false);
		string name737 = "ErrCodeAccumulateDaysLoginOperationalActivityItemGroupRewardParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAccumulateDaysLoginOperationalActivityItemGroupRewardParmError);
		}
		LuaObject.addMember(l, name737, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E0, null, false);
		string name738 = "ErrCodeRewardAddOperationalActivityPlayParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRewardAddOperationalActivityPlayParmError);
		}
		LuaObject.addMember(l, name738, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E1, null, false);
		string name739 = "ErrCodeChallengeNumsAddOperationalActivityPlayParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeChallengeNumsAddOperationalActivityPlayParmError);
		}
		LuaObject.addMember(l, name739, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E2, null, false);
		string name740 = "ErrCodeCardPoolOperationalActivityCardPoolParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolOperationalActivityCardPoolParmError);
		}
		LuaObject.addMember(l, name740, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E3, null, false);
		string name741 = "ErrCodeOperationalItemGroupItemIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperationalItemGroupItemIdError);
		}
		LuaObject.addMember(l, name741, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E4, null, false);
		string name742 = "ErrCodeLimitedTimeExchangeOperationalActivityParmItemCannotBeEquipment";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeLimitedTimeExchangeOperationalActivityParmItemCannotBeEquipment);
		}
		LuaObject.addMember(l, name742, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E5, null, false);
		string name743 = "ErrCodeRandomBoxRewardsGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRandomBoxRewardsGoodsIdError);
		}
		LuaObject.addMember(l, name743, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E6, null, false);
		string name744 = "ErrCodeStaticBoxRewardsGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeStaticBoxRewardsGoodsIdError);
		}
		LuaObject.addMember(l, name744, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E7, null, false);
		string name745 = "ErrCodeEquipmentLevelTableRankNextExpsCountBelowEquipmentTableEquipmentMaxRank";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeEquipmentLevelTableRankNextExpsCountBelowEquipmentTableEquipmentMaxRank);
		}
		LuaObject.addMember(l, name745, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E8, null, false);
		string name746 = "ErrCodeBattleTreasureRewardGoodsIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeBattleTreasureRewardGoodsIdError);
		}
		LuaObject.addMember(l, name746, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2E9, null, false);
		string name747 = "ErrCodeHeroInformationFetterIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInformationFetterIdError);
		}
		LuaObject.addMember(l, name747, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EA, null, false);
		string name748 = "ErrCodeHeroInformationConfessionIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInformationConfessionIdError);
		}
		LuaObject.addMember(l, name748, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EB, null, false);
		string name749 = "ErrCodeHeroInitialJobConnectionNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroInitialJobConnectionNotExist);
		}
		LuaObject.addMember(l, name749, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EC, null, false);
		string name750 = "ErrCodeJobConnnectionTalentSkillError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2ED == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2ED = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeJobConnnectionTalentSkillError);
		}
		LuaObject.addMember(l, name750, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2ED, null, false);
		string name751 = "ErrCodeTrainingGroundTechLevelMax";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingGroundTechLevelMax);
		}
		LuaObject.addMember(l, name751, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EE, null, false);
		string name752 = "ErrCodeTrainingGroundTechLevelupResourceNotEnough";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingGroundTechLevelupResourceNotEnough);
		}
		LuaObject.addMember(l, name752, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2EF, null, false);
		string name753 = "ErrCodeTrainingGroundTechLevelupFail";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F0 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F0 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeTrainingGroundTechLevelupFail);
		}
		LuaObject.addMember(l, name753, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F0, null, false);
		string name754 = "ErrCodeFreeCardPoolGroupFirstSingleSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F1 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F1 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFreeCardPoolGroupFirstSingleSelectWeightIsZero);
		}
		LuaObject.addMember(l, name754, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F1, null, false);
		string name755 = "ErrCodeFreeCardPoolGroupFirstTenSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F2 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F2 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeFreeCardPoolGroupFirstTenSelectWeightIsZero);
		}
		LuaObject.addMember(l, name755, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F2, null, false);
		string name756 = "ErrCodeCrystalCardPoolGroupFirstSingleSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F3 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F3 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalCardPoolGroupFirstSingleSelectWeightIsZero);
		}
		LuaObject.addMember(l, name756, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F3, null, false);
		string name757 = "ErrCodeCrystalCardPoolGroupFirstTenSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F4 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F4 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCrystalCardPoolGroupFirstTenSelectWeightIsZero);
		}
		LuaObject.addMember(l, name757, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F4, null, false);
		string name758 = "ErrCodeActivityCardPoolGroupFirstSingleSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F5 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F5 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolGroupFirstSingleSelectWeightIsZero);
		}
		LuaObject.addMember(l, name758, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F5, null, false);
		string name759 = "ErrCodeActivityCardPoolGroupFirstTenSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F6 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F6 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeActivityCardPoolGroupFirstTenSelectWeightIsZero);
		}
		LuaObject.addMember(l, name759, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F6, null, false);
		string name760 = "ErrCodeHeroFetterTypeMissionCannotHaveReward";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F7 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F7 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeHeroFetterTypeMissionCannotHaveReward);
		}
		LuaObject.addMember(l, name760, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F7, null, false);
		string name761 = "ErrCodeMissionRewardIsEmpty";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F8 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F8 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMissionRewardIsEmpty);
		}
		LuaObject.addMember(l, name761, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F8, null, false);
		string name762 = "ErrCodeItemNumsError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F9 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F9 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeItemNumsError);
		}
		LuaObject.addMember(l, name762, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2F9, null, false);
		string name763 = "ErrCodeGiftStoreItemShowTimeFormError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FA == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FA = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreItemShowTimeFormError);
		}
		LuaObject.addMember(l, name763, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FA, null, false);
		string name764 = "ErrCodeAppleSubscribeGoodsJustBeMonthCard";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FB == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FB = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAppleSubscribeGoodsJustBeMonthCard);
		}
		LuaObject.addMember(l, name764, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FB, null, false);
		string name765 = "ErrCodeNotMonthCardCannotBeSubscribed";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FC == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FC = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNotMonthCardCannotBeSubscribed);
		}
		LuaObject.addMember(l, name765, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FC, null, false);
		string name766 = "ErrCodeGiftStoreGoodsTypeRelatedIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FD == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FD = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreGoodsTypeRelatedIdError);
		}
		LuaObject.addMember(l, name766, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FD, null, false);
		string name767 = "ErrCodeGiftStoreFirstRewardTypeRelatedIdError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FE == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FE = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeGiftStoreFirstRewardTypeRelatedIdError);
		}
		LuaObject.addMember(l, name767, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FE, null, false);
		string name768 = "ErrCodeRaffleOperationaRaffleParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FF == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FF = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeRaffleOperationaRaffleParmError);
		}
		LuaObject.addMember(l, name768, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache2FF, null, false);
		string name769 = "ErrCodeAccumulateRechargeOperationalActivityItemGroupRewardParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache300 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache300 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAccumulateRechargeOperationalActivityItemGroupRewardParmError);
		}
		LuaObject.addMember(l, name769, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache300, null, false);
		string name770 = "ErrCodeAccumulateConsumeCrystalOperationalActivityItemGroupRewardParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache301 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache301 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeAccumulateConsumeCrystalOperationalActivityItemGroupRewardParmError);
		}
		LuaObject.addMember(l, name770, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache301, null, false);
		string name771 = "ErrCodeMonthCardMissionError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache302 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache302 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeMonthCardMissionError);
		}
		LuaObject.addMember(l, name771, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache302, null, false);
		string name772 = "ErrCodeNewUserAccumulatedValueError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache303 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache303 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeNewUserAccumulatedValueError);
		}
		LuaObject.addMember(l, name772, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache303, null, false);
		string name773 = "ErrCodeOldUserAccumulatedValueError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache304 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache304 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOldUserAccumulatedValueError);
		}
		LuaObject.addMember(l, name773, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache304, null, false);
		string name774 = "ErrCodeCardPoolTenSelectGuaranteedMinCountError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache305 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache305 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolTenSelectGuaranteedMinCountError);
		}
		LuaObject.addMember(l, name774, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache305, null, false);
		string name775 = "ErrCodeCardPoolDefaultSingleSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache306 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache306 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolDefaultSingleSelectWeightIsZero);
		}
		LuaObject.addMember(l, name775, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache306, null, false);
		string name776 = "ErrCodeCardPoolDefaultTenSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache307 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache307 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolDefaultTenSelectWeightIsZero);
		}
		LuaObject.addMember(l, name776, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache307, null, false);
		string name777 = "ErrCodeCardPoolFirstSingleSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache308 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache308 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolFirstSingleSelectWeightIsZero);
		}
		LuaObject.addMember(l, name777, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache308, null, false);
		string name778 = "ErrCodeCardPoolFirstTenSelectWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache309 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache309 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolFirstTenSelectWeightIsZero);
		}
		LuaObject.addMember(l, name778, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache309, null, false);
		string name779 = "ErrCodeCardPoolTenSelectAccumulateWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30A == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30A = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolTenSelectAccumulateWeightIsZero);
		}
		LuaObject.addMember(l, name779, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30A, null, false);
		string name780 = "ErrCodeCardPoolGroupAllItemWeightIsZero";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30B == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30B = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeCardPoolGroupAllItemWeightIsZero);
		}
		LuaObject.addMember(l, name780, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30B, null, false);
		string name781 = "ErrCodeUnchartedScoreOperationaUnchartedScoreIdParmError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30C == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30C = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeUnchartedScoreOperationaUnchartedScoreIdParmError);
		}
		LuaObject.addMember(l, name781, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30C, null, false);
		string name782 = "ErrCodeOperactionalActivityDaysAfterServerOpenError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30D == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30D = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperactionalActivityDaysAfterServerOpenError);
		}
		LuaObject.addMember(l, name782, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30D, null, false);
		string name783 = "ErrCodeOperactionalActivityDaysAfterPlayerCreatedError";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30E == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30E = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeOperactionalActivityDaysAfterPlayerCreatedError);
		}
		LuaObject.addMember(l, name783, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30E, null, false);
		string name784 = "ErrCodeSrcCopyAccountNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30F == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30F = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSrcCopyAccountNotExist);
		}
		LuaObject.addMember(l, name784, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache30F, null, false);
		string name785 = "ErrCodeDestCopyPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache310 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache310 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeDestCopyPlayerNotExist);
		}
		LuaObject.addMember(l, name785, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache310, null, false);
		string name786 = "ErrCodeSrcCopyPlayerNotExist";
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache311 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache311 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.get_ErrCodeSrcCopyPlayerNotExist);
		}
		LuaObject.addMember(l, name786, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache311, null, false);
		if (Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache312 == null)
		{
			Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache312 = new LuaCSFunction(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.<>f__mg$cache312, typeof(ErrorCode));
	}

	// Token: 0x0400F169 RID: 61801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F16A RID: 61802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F16B RID: 61803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F16C RID: 61804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F16D RID: 61805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F16E RID: 61806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F16F RID: 61807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F170 RID: 61808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F171 RID: 61809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F172 RID: 61810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F173 RID: 61811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F174 RID: 61812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F175 RID: 61813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F176 RID: 61814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F177 RID: 61815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F178 RID: 61816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F179 RID: 61817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F17A RID: 61818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F17B RID: 61819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F17C RID: 61820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F17D RID: 61821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F17E RID: 61822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F17F RID: 61823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F180 RID: 61824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F181 RID: 61825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F182 RID: 61826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F183 RID: 61827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F184 RID: 61828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F185 RID: 61829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F186 RID: 61830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F187 RID: 61831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F188 RID: 61832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F189 RID: 61833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F18A RID: 61834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F18B RID: 61835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F18C RID: 61836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F18D RID: 61837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F18E RID: 61838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F18F RID: 61839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F190 RID: 61840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F191 RID: 61841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F192 RID: 61842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F193 RID: 61843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F194 RID: 61844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F195 RID: 61845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F196 RID: 61846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F197 RID: 61847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F198 RID: 61848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F199 RID: 61849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F19A RID: 61850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F19B RID: 61851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F19C RID: 61852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F19D RID: 61853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F19E RID: 61854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F19F RID: 61855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F1A0 RID: 61856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F1A1 RID: 61857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F1A2 RID: 61858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F1A3 RID: 61859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F1A4 RID: 61860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F1A5 RID: 61861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F1A6 RID: 61862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F1A7 RID: 61863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F1A8 RID: 61864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F1A9 RID: 61865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F1AA RID: 61866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F1AB RID: 61867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F1AC RID: 61868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400F1AD RID: 61869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400F1AE RID: 61870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400F1AF RID: 61871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400F1B0 RID: 61872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400F1B1 RID: 61873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400F1B2 RID: 61874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400F1B3 RID: 61875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400F1B4 RID: 61876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400F1B5 RID: 61877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400F1B6 RID: 61878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400F1B7 RID: 61879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400F1B8 RID: 61880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400F1B9 RID: 61881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400F1BA RID: 61882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400F1BB RID: 61883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400F1BC RID: 61884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400F1BD RID: 61885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400F1BE RID: 61886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400F1BF RID: 61887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400F1C0 RID: 61888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400F1C1 RID: 61889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400F1C2 RID: 61890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400F1C3 RID: 61891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400F1C4 RID: 61892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400F1C5 RID: 61893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400F1C6 RID: 61894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400F1C7 RID: 61895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400F1C8 RID: 61896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400F1C9 RID: 61897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400F1CA RID: 61898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400F1CB RID: 61899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400F1CC RID: 61900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400F1CD RID: 61901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400F1CE RID: 61902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400F1CF RID: 61903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400F1D0 RID: 61904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400F1D1 RID: 61905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400F1D2 RID: 61906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400F1D3 RID: 61907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400F1D4 RID: 61908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400F1D5 RID: 61909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400F1D6 RID: 61910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400F1D7 RID: 61911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400F1D8 RID: 61912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400F1D9 RID: 61913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400F1DA RID: 61914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400F1DB RID: 61915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400F1DC RID: 61916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400F1DD RID: 61917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400F1DE RID: 61918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400F1DF RID: 61919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400F1E0 RID: 61920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400F1E1 RID: 61921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400F1E2 RID: 61922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400F1E3 RID: 61923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400F1E4 RID: 61924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400F1E5 RID: 61925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400F1E6 RID: 61926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400F1E7 RID: 61927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400F1E8 RID: 61928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400F1E9 RID: 61929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400F1EA RID: 61930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400F1EB RID: 61931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400F1EC RID: 61932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400F1ED RID: 61933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400F1EE RID: 61934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400F1EF RID: 61935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400F1F0 RID: 61936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400F1F1 RID: 61937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400F1F2 RID: 61938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400F1F3 RID: 61939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400F1F4 RID: 61940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400F1F5 RID: 61941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400F1F6 RID: 61942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400F1F7 RID: 61943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400F1F8 RID: 61944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400F1F9 RID: 61945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400F1FA RID: 61946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400F1FB RID: 61947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400F1FC RID: 61948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400F1FD RID: 61949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400F1FE RID: 61950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400F1FF RID: 61951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400F200 RID: 61952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400F201 RID: 61953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400F202 RID: 61954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400F203 RID: 61955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400F204 RID: 61956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400F205 RID: 61957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400F206 RID: 61958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400F207 RID: 61959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400F208 RID: 61960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400F209 RID: 61961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400F20A RID: 61962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400F20B RID: 61963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400F20C RID: 61964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400F20D RID: 61965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0400F20E RID: 61966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0400F20F RID: 61967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0400F210 RID: 61968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0400F211 RID: 61969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0400F212 RID: 61970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0400F213 RID: 61971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0400F214 RID: 61972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0400F215 RID: 61973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0400F216 RID: 61974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0400F217 RID: 61975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0400F218 RID: 61976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0400F219 RID: 61977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0400F21A RID: 61978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0400F21B RID: 61979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x0400F21C RID: 61980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x0400F21D RID: 61981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0400F21E RID: 61982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0400F21F RID: 61983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0400F220 RID: 61984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0400F221 RID: 61985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0400F222 RID: 61986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0400F223 RID: 61987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0400F224 RID: 61988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0400F225 RID: 61989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0400F226 RID: 61990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0400F227 RID: 61991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0400F228 RID: 61992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0400F229 RID: 61993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x0400F22A RID: 61994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x0400F22B RID: 61995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x0400F22C RID: 61996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x0400F22D RID: 61997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0400F22E RID: 61998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0400F22F RID: 61999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0400F230 RID: 62000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0400F231 RID: 62001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0400F232 RID: 62002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0400F233 RID: 62003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0400F234 RID: 62004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0400F235 RID: 62005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0400F236 RID: 62006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0400F237 RID: 62007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0400F238 RID: 62008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0400F239 RID: 62009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x0400F23A RID: 62010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x0400F23B RID: 62011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x0400F23C RID: 62012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0400F23D RID: 62013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0400F23E RID: 62014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0400F23F RID: 62015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0400F240 RID: 62016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0400F241 RID: 62017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0400F242 RID: 62018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x0400F243 RID: 62019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0400F244 RID: 62020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0400F245 RID: 62021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0400F246 RID: 62022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0400F247 RID: 62023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0400F248 RID: 62024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0400F249 RID: 62025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0400F24A RID: 62026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0400F24B RID: 62027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0400F24C RID: 62028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0400F24D RID: 62029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x0400F24E RID: 62030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x0400F24F RID: 62031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x0400F250 RID: 62032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x0400F251 RID: 62033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x0400F252 RID: 62034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x0400F253 RID: 62035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x0400F254 RID: 62036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x0400F255 RID: 62037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x0400F256 RID: 62038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x0400F257 RID: 62039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0400F258 RID: 62040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0400F259 RID: 62041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x0400F25A RID: 62042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x0400F25B RID: 62043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x0400F25C RID: 62044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x0400F25D RID: 62045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x0400F25E RID: 62046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x0400F25F RID: 62047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x0400F260 RID: 62048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x0400F261 RID: 62049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x0400F262 RID: 62050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x0400F263 RID: 62051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x0400F264 RID: 62052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x0400F265 RID: 62053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x0400F266 RID: 62054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x0400F267 RID: 62055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x0400F268 RID: 62056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x0400F269 RID: 62057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x0400F26A RID: 62058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x0400F26B RID: 62059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x0400F26C RID: 62060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x0400F26D RID: 62061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x0400F26E RID: 62062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x0400F26F RID: 62063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x0400F270 RID: 62064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x0400F271 RID: 62065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x0400F272 RID: 62066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x0400F273 RID: 62067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x0400F274 RID: 62068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0400F275 RID: 62069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x0400F276 RID: 62070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x0400F277 RID: 62071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0400F278 RID: 62072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0400F279 RID: 62073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0400F27A RID: 62074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x0400F27B RID: 62075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0400F27C RID: 62076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0400F27D RID: 62077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x0400F27E RID: 62078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x0400F27F RID: 62079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x0400F280 RID: 62080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x0400F281 RID: 62081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x0400F282 RID: 62082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x0400F283 RID: 62083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x0400F284 RID: 62084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x0400F285 RID: 62085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0400F286 RID: 62086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0400F287 RID: 62087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0400F288 RID: 62088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0400F289 RID: 62089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0400F28A RID: 62090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0400F28B RID: 62091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0400F28C RID: 62092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0400F28D RID: 62093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x0400F28E RID: 62094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x0400F28F RID: 62095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x0400F290 RID: 62096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x0400F291 RID: 62097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x0400F292 RID: 62098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x0400F293 RID: 62099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x0400F294 RID: 62100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x0400F295 RID: 62101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x0400F296 RID: 62102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x0400F297 RID: 62103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0400F298 RID: 62104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0400F299 RID: 62105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0400F29A RID: 62106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0400F29B RID: 62107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0400F29C RID: 62108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0400F29D RID: 62109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x0400F29E RID: 62110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x0400F29F RID: 62111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x0400F2A0 RID: 62112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x0400F2A1 RID: 62113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x0400F2A2 RID: 62114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x0400F2A3 RID: 62115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x0400F2A4 RID: 62116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x0400F2A5 RID: 62117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x0400F2A6 RID: 62118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x0400F2A7 RID: 62119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x0400F2A8 RID: 62120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x0400F2A9 RID: 62121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0400F2AA RID: 62122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x0400F2AB RID: 62123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0400F2AC RID: 62124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0400F2AD RID: 62125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0400F2AE RID: 62126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0400F2AF RID: 62127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0400F2B0 RID: 62128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0400F2B1 RID: 62129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x0400F2B2 RID: 62130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x0400F2B3 RID: 62131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x0400F2B4 RID: 62132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x0400F2B5 RID: 62133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x0400F2B6 RID: 62134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x0400F2B7 RID: 62135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0400F2B8 RID: 62136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0400F2B9 RID: 62137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0400F2BA RID: 62138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x0400F2BB RID: 62139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x0400F2BC RID: 62140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x0400F2BD RID: 62141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x0400F2BE RID: 62142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x0400F2BF RID: 62143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x0400F2C0 RID: 62144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x0400F2C1 RID: 62145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x0400F2C2 RID: 62146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x0400F2C3 RID: 62147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x0400F2C4 RID: 62148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x0400F2C5 RID: 62149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x0400F2C6 RID: 62150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x0400F2C7 RID: 62151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0400F2C8 RID: 62152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0400F2C9 RID: 62153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0400F2CA RID: 62154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x0400F2CB RID: 62155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x0400F2CC RID: 62156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x0400F2CD RID: 62157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x0400F2CE RID: 62158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x0400F2CF RID: 62159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x0400F2D0 RID: 62160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x0400F2D1 RID: 62161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x0400F2D2 RID: 62162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x0400F2D3 RID: 62163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x0400F2D4 RID: 62164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x0400F2D5 RID: 62165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x0400F2D6 RID: 62166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x0400F2D7 RID: 62167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x0400F2D8 RID: 62168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x0400F2D9 RID: 62169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x0400F2DA RID: 62170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x0400F2DB RID: 62171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x0400F2DC RID: 62172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x0400F2DD RID: 62173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x0400F2DE RID: 62174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x0400F2DF RID: 62175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x0400F2E0 RID: 62176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x0400F2E1 RID: 62177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x0400F2E2 RID: 62178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x0400F2E3 RID: 62179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x0400F2E4 RID: 62180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x0400F2E5 RID: 62181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x0400F2E6 RID: 62182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x0400F2E7 RID: 62183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x0400F2E8 RID: 62184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x0400F2E9 RID: 62185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x0400F2EA RID: 62186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x0400F2EB RID: 62187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x0400F2EC RID: 62188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x0400F2ED RID: 62189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x0400F2EE RID: 62190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x0400F2EF RID: 62191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x0400F2F0 RID: 62192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x0400F2F1 RID: 62193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x0400F2F2 RID: 62194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x0400F2F3 RID: 62195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x0400F2F4 RID: 62196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x0400F2F5 RID: 62197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x0400F2F6 RID: 62198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x0400F2F7 RID: 62199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x0400F2F8 RID: 62200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x0400F2F9 RID: 62201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x0400F2FA RID: 62202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x0400F2FB RID: 62203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x0400F2FC RID: 62204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x0400F2FD RID: 62205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x0400F2FE RID: 62206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x0400F2FF RID: 62207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x0400F300 RID: 62208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x0400F301 RID: 62209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x0400F302 RID: 62210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x0400F303 RID: 62211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x0400F304 RID: 62212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x0400F305 RID: 62213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x0400F306 RID: 62214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x0400F307 RID: 62215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x0400F308 RID: 62216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x0400F309 RID: 62217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x0400F30A RID: 62218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x0400F30B RID: 62219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x0400F30C RID: 62220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x0400F30D RID: 62221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x0400F30E RID: 62222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x0400F30F RID: 62223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x0400F310 RID: 62224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;

	// Token: 0x0400F311 RID: 62225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A8;

	// Token: 0x0400F312 RID: 62226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A9;

	// Token: 0x0400F313 RID: 62227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AA;

	// Token: 0x0400F314 RID: 62228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AB;

	// Token: 0x0400F315 RID: 62229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AC;

	// Token: 0x0400F316 RID: 62230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AD;

	// Token: 0x0400F317 RID: 62231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AE;

	// Token: 0x0400F318 RID: 62232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AF;

	// Token: 0x0400F319 RID: 62233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B0;

	// Token: 0x0400F31A RID: 62234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B1;

	// Token: 0x0400F31B RID: 62235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B2;

	// Token: 0x0400F31C RID: 62236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B3;

	// Token: 0x0400F31D RID: 62237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B4;

	// Token: 0x0400F31E RID: 62238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B5;

	// Token: 0x0400F31F RID: 62239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B6;

	// Token: 0x0400F320 RID: 62240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B7;

	// Token: 0x0400F321 RID: 62241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B8;

	// Token: 0x0400F322 RID: 62242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B9;

	// Token: 0x0400F323 RID: 62243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BA;

	// Token: 0x0400F324 RID: 62244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BB;

	// Token: 0x0400F325 RID: 62245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BC;

	// Token: 0x0400F326 RID: 62246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BD;

	// Token: 0x0400F327 RID: 62247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BE;

	// Token: 0x0400F328 RID: 62248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BF;

	// Token: 0x0400F329 RID: 62249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C0;

	// Token: 0x0400F32A RID: 62250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C1;

	// Token: 0x0400F32B RID: 62251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C2;

	// Token: 0x0400F32C RID: 62252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C3;

	// Token: 0x0400F32D RID: 62253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C4;

	// Token: 0x0400F32E RID: 62254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C5;

	// Token: 0x0400F32F RID: 62255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C6;

	// Token: 0x0400F330 RID: 62256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C7;

	// Token: 0x0400F331 RID: 62257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C8;

	// Token: 0x0400F332 RID: 62258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C9;

	// Token: 0x0400F333 RID: 62259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CA;

	// Token: 0x0400F334 RID: 62260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CB;

	// Token: 0x0400F335 RID: 62261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CC;

	// Token: 0x0400F336 RID: 62262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CD;

	// Token: 0x0400F337 RID: 62263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CE;

	// Token: 0x0400F338 RID: 62264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1CF;

	// Token: 0x0400F339 RID: 62265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D0;

	// Token: 0x0400F33A RID: 62266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D1;

	// Token: 0x0400F33B RID: 62267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D2;

	// Token: 0x0400F33C RID: 62268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D3;

	// Token: 0x0400F33D RID: 62269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D4;

	// Token: 0x0400F33E RID: 62270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D5;

	// Token: 0x0400F33F RID: 62271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D6;

	// Token: 0x0400F340 RID: 62272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D7;

	// Token: 0x0400F341 RID: 62273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D8;

	// Token: 0x0400F342 RID: 62274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D9;

	// Token: 0x0400F343 RID: 62275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DA;

	// Token: 0x0400F344 RID: 62276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DB;

	// Token: 0x0400F345 RID: 62277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DC;

	// Token: 0x0400F346 RID: 62278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DD;

	// Token: 0x0400F347 RID: 62279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DE;

	// Token: 0x0400F348 RID: 62280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1DF;

	// Token: 0x0400F349 RID: 62281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E0;

	// Token: 0x0400F34A RID: 62282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E1;

	// Token: 0x0400F34B RID: 62283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E2;

	// Token: 0x0400F34C RID: 62284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E3;

	// Token: 0x0400F34D RID: 62285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E4;

	// Token: 0x0400F34E RID: 62286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E5;

	// Token: 0x0400F34F RID: 62287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E6;

	// Token: 0x0400F350 RID: 62288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E7;

	// Token: 0x0400F351 RID: 62289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E8;

	// Token: 0x0400F352 RID: 62290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E9;

	// Token: 0x0400F353 RID: 62291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EA;

	// Token: 0x0400F354 RID: 62292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EB;

	// Token: 0x0400F355 RID: 62293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EC;

	// Token: 0x0400F356 RID: 62294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1ED;

	// Token: 0x0400F357 RID: 62295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EE;

	// Token: 0x0400F358 RID: 62296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1EF;

	// Token: 0x0400F359 RID: 62297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F0;

	// Token: 0x0400F35A RID: 62298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F1;

	// Token: 0x0400F35B RID: 62299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F2;

	// Token: 0x0400F35C RID: 62300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F3;

	// Token: 0x0400F35D RID: 62301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F4;

	// Token: 0x0400F35E RID: 62302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F5;

	// Token: 0x0400F35F RID: 62303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F6;

	// Token: 0x0400F360 RID: 62304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F7;

	// Token: 0x0400F361 RID: 62305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F8;

	// Token: 0x0400F362 RID: 62306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F9;

	// Token: 0x0400F363 RID: 62307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FA;

	// Token: 0x0400F364 RID: 62308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FB;

	// Token: 0x0400F365 RID: 62309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FC;

	// Token: 0x0400F366 RID: 62310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FD;

	// Token: 0x0400F367 RID: 62311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FE;

	// Token: 0x0400F368 RID: 62312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1FF;

	// Token: 0x0400F369 RID: 62313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache200;

	// Token: 0x0400F36A RID: 62314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache201;

	// Token: 0x0400F36B RID: 62315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache202;

	// Token: 0x0400F36C RID: 62316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache203;

	// Token: 0x0400F36D RID: 62317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache204;

	// Token: 0x0400F36E RID: 62318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache205;

	// Token: 0x0400F36F RID: 62319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache206;

	// Token: 0x0400F370 RID: 62320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache207;

	// Token: 0x0400F371 RID: 62321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache208;

	// Token: 0x0400F372 RID: 62322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache209;

	// Token: 0x0400F373 RID: 62323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20A;

	// Token: 0x0400F374 RID: 62324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20B;

	// Token: 0x0400F375 RID: 62325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20C;

	// Token: 0x0400F376 RID: 62326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20D;

	// Token: 0x0400F377 RID: 62327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20E;

	// Token: 0x0400F378 RID: 62328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20F;

	// Token: 0x0400F379 RID: 62329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache210;

	// Token: 0x0400F37A RID: 62330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache211;

	// Token: 0x0400F37B RID: 62331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache212;

	// Token: 0x0400F37C RID: 62332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache213;

	// Token: 0x0400F37D RID: 62333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache214;

	// Token: 0x0400F37E RID: 62334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache215;

	// Token: 0x0400F37F RID: 62335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache216;

	// Token: 0x0400F380 RID: 62336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache217;

	// Token: 0x0400F381 RID: 62337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache218;

	// Token: 0x0400F382 RID: 62338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache219;

	// Token: 0x0400F383 RID: 62339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21A;

	// Token: 0x0400F384 RID: 62340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21B;

	// Token: 0x0400F385 RID: 62341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21C;

	// Token: 0x0400F386 RID: 62342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21D;

	// Token: 0x0400F387 RID: 62343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21E;

	// Token: 0x0400F388 RID: 62344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21F;

	// Token: 0x0400F389 RID: 62345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache220;

	// Token: 0x0400F38A RID: 62346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache221;

	// Token: 0x0400F38B RID: 62347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache222;

	// Token: 0x0400F38C RID: 62348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache223;

	// Token: 0x0400F38D RID: 62349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache224;

	// Token: 0x0400F38E RID: 62350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache225;

	// Token: 0x0400F38F RID: 62351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache226;

	// Token: 0x0400F390 RID: 62352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache227;

	// Token: 0x0400F391 RID: 62353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache228;

	// Token: 0x0400F392 RID: 62354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache229;

	// Token: 0x0400F393 RID: 62355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22A;

	// Token: 0x0400F394 RID: 62356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22B;

	// Token: 0x0400F395 RID: 62357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22C;

	// Token: 0x0400F396 RID: 62358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22D;

	// Token: 0x0400F397 RID: 62359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22E;

	// Token: 0x0400F398 RID: 62360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22F;

	// Token: 0x0400F399 RID: 62361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache230;

	// Token: 0x0400F39A RID: 62362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache231;

	// Token: 0x0400F39B RID: 62363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache232;

	// Token: 0x0400F39C RID: 62364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache233;

	// Token: 0x0400F39D RID: 62365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache234;

	// Token: 0x0400F39E RID: 62366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache235;

	// Token: 0x0400F39F RID: 62367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache236;

	// Token: 0x0400F3A0 RID: 62368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache237;

	// Token: 0x0400F3A1 RID: 62369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache238;

	// Token: 0x0400F3A2 RID: 62370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache239;

	// Token: 0x0400F3A3 RID: 62371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23A;

	// Token: 0x0400F3A4 RID: 62372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23B;

	// Token: 0x0400F3A5 RID: 62373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23C;

	// Token: 0x0400F3A6 RID: 62374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23D;

	// Token: 0x0400F3A7 RID: 62375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23E;

	// Token: 0x0400F3A8 RID: 62376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23F;

	// Token: 0x0400F3A9 RID: 62377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache240;

	// Token: 0x0400F3AA RID: 62378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache241;

	// Token: 0x0400F3AB RID: 62379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache242;

	// Token: 0x0400F3AC RID: 62380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache243;

	// Token: 0x0400F3AD RID: 62381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache244;

	// Token: 0x0400F3AE RID: 62382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache245;

	// Token: 0x0400F3AF RID: 62383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache246;

	// Token: 0x0400F3B0 RID: 62384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache247;

	// Token: 0x0400F3B1 RID: 62385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache248;

	// Token: 0x0400F3B2 RID: 62386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache249;

	// Token: 0x0400F3B3 RID: 62387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24A;

	// Token: 0x0400F3B4 RID: 62388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24B;

	// Token: 0x0400F3B5 RID: 62389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24C;

	// Token: 0x0400F3B6 RID: 62390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24D;

	// Token: 0x0400F3B7 RID: 62391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24E;

	// Token: 0x0400F3B8 RID: 62392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24F;

	// Token: 0x0400F3B9 RID: 62393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache250;

	// Token: 0x0400F3BA RID: 62394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache251;

	// Token: 0x0400F3BB RID: 62395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache252;

	// Token: 0x0400F3BC RID: 62396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache253;

	// Token: 0x0400F3BD RID: 62397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache254;

	// Token: 0x0400F3BE RID: 62398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache255;

	// Token: 0x0400F3BF RID: 62399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache256;

	// Token: 0x0400F3C0 RID: 62400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache257;

	// Token: 0x0400F3C1 RID: 62401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache258;

	// Token: 0x0400F3C2 RID: 62402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache259;

	// Token: 0x0400F3C3 RID: 62403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25A;

	// Token: 0x0400F3C4 RID: 62404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25B;

	// Token: 0x0400F3C5 RID: 62405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25C;

	// Token: 0x0400F3C6 RID: 62406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25D;

	// Token: 0x0400F3C7 RID: 62407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25E;

	// Token: 0x0400F3C8 RID: 62408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25F;

	// Token: 0x0400F3C9 RID: 62409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache260;

	// Token: 0x0400F3CA RID: 62410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache261;

	// Token: 0x0400F3CB RID: 62411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache262;

	// Token: 0x0400F3CC RID: 62412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache263;

	// Token: 0x0400F3CD RID: 62413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache264;

	// Token: 0x0400F3CE RID: 62414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache265;

	// Token: 0x0400F3CF RID: 62415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache266;

	// Token: 0x0400F3D0 RID: 62416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache267;

	// Token: 0x0400F3D1 RID: 62417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache268;

	// Token: 0x0400F3D2 RID: 62418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache269;

	// Token: 0x0400F3D3 RID: 62419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26A;

	// Token: 0x0400F3D4 RID: 62420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26B;

	// Token: 0x0400F3D5 RID: 62421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26C;

	// Token: 0x0400F3D6 RID: 62422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26D;

	// Token: 0x0400F3D7 RID: 62423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26E;

	// Token: 0x0400F3D8 RID: 62424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26F;

	// Token: 0x0400F3D9 RID: 62425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache270;

	// Token: 0x0400F3DA RID: 62426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache271;

	// Token: 0x0400F3DB RID: 62427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache272;

	// Token: 0x0400F3DC RID: 62428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache273;

	// Token: 0x0400F3DD RID: 62429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache274;

	// Token: 0x0400F3DE RID: 62430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache275;

	// Token: 0x0400F3DF RID: 62431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache276;

	// Token: 0x0400F3E0 RID: 62432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache277;

	// Token: 0x0400F3E1 RID: 62433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache278;

	// Token: 0x0400F3E2 RID: 62434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache279;

	// Token: 0x0400F3E3 RID: 62435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27A;

	// Token: 0x0400F3E4 RID: 62436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27B;

	// Token: 0x0400F3E5 RID: 62437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27C;

	// Token: 0x0400F3E6 RID: 62438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27D;

	// Token: 0x0400F3E7 RID: 62439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27E;

	// Token: 0x0400F3E8 RID: 62440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27F;

	// Token: 0x0400F3E9 RID: 62441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache280;

	// Token: 0x0400F3EA RID: 62442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache281;

	// Token: 0x0400F3EB RID: 62443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache282;

	// Token: 0x0400F3EC RID: 62444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache283;

	// Token: 0x0400F3ED RID: 62445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache284;

	// Token: 0x0400F3EE RID: 62446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache285;

	// Token: 0x0400F3EF RID: 62447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache286;

	// Token: 0x0400F3F0 RID: 62448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache287;

	// Token: 0x0400F3F1 RID: 62449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache288;

	// Token: 0x0400F3F2 RID: 62450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache289;

	// Token: 0x0400F3F3 RID: 62451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28A;

	// Token: 0x0400F3F4 RID: 62452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28B;

	// Token: 0x0400F3F5 RID: 62453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28C;

	// Token: 0x0400F3F6 RID: 62454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28D;

	// Token: 0x0400F3F7 RID: 62455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28E;

	// Token: 0x0400F3F8 RID: 62456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28F;

	// Token: 0x0400F3F9 RID: 62457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache290;

	// Token: 0x0400F3FA RID: 62458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache291;

	// Token: 0x0400F3FB RID: 62459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache292;

	// Token: 0x0400F3FC RID: 62460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache293;

	// Token: 0x0400F3FD RID: 62461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache294;

	// Token: 0x0400F3FE RID: 62462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache295;

	// Token: 0x0400F3FF RID: 62463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache296;

	// Token: 0x0400F400 RID: 62464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache297;

	// Token: 0x0400F401 RID: 62465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache298;

	// Token: 0x0400F402 RID: 62466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache299;

	// Token: 0x0400F403 RID: 62467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29A;

	// Token: 0x0400F404 RID: 62468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29B;

	// Token: 0x0400F405 RID: 62469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29C;

	// Token: 0x0400F406 RID: 62470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29D;

	// Token: 0x0400F407 RID: 62471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29E;

	// Token: 0x0400F408 RID: 62472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29F;

	// Token: 0x0400F409 RID: 62473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A0;

	// Token: 0x0400F40A RID: 62474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A1;

	// Token: 0x0400F40B RID: 62475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A2;

	// Token: 0x0400F40C RID: 62476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A3;

	// Token: 0x0400F40D RID: 62477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A4;

	// Token: 0x0400F40E RID: 62478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A5;

	// Token: 0x0400F40F RID: 62479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A6;

	// Token: 0x0400F410 RID: 62480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A7;

	// Token: 0x0400F411 RID: 62481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A8;

	// Token: 0x0400F412 RID: 62482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A9;

	// Token: 0x0400F413 RID: 62483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AA;

	// Token: 0x0400F414 RID: 62484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AB;

	// Token: 0x0400F415 RID: 62485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AC;

	// Token: 0x0400F416 RID: 62486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AD;

	// Token: 0x0400F417 RID: 62487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AE;

	// Token: 0x0400F418 RID: 62488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2AF;

	// Token: 0x0400F419 RID: 62489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B0;

	// Token: 0x0400F41A RID: 62490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B1;

	// Token: 0x0400F41B RID: 62491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B2;

	// Token: 0x0400F41C RID: 62492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B3;

	// Token: 0x0400F41D RID: 62493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B4;

	// Token: 0x0400F41E RID: 62494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B5;

	// Token: 0x0400F41F RID: 62495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B6;

	// Token: 0x0400F420 RID: 62496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B7;

	// Token: 0x0400F421 RID: 62497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B8;

	// Token: 0x0400F422 RID: 62498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B9;

	// Token: 0x0400F423 RID: 62499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BA;

	// Token: 0x0400F424 RID: 62500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BB;

	// Token: 0x0400F425 RID: 62501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BC;

	// Token: 0x0400F426 RID: 62502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BD;

	// Token: 0x0400F427 RID: 62503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BE;

	// Token: 0x0400F428 RID: 62504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2BF;

	// Token: 0x0400F429 RID: 62505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C0;

	// Token: 0x0400F42A RID: 62506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C1;

	// Token: 0x0400F42B RID: 62507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C2;

	// Token: 0x0400F42C RID: 62508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C3;

	// Token: 0x0400F42D RID: 62509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C4;

	// Token: 0x0400F42E RID: 62510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C5;

	// Token: 0x0400F42F RID: 62511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C6;

	// Token: 0x0400F430 RID: 62512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C7;

	// Token: 0x0400F431 RID: 62513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C8;

	// Token: 0x0400F432 RID: 62514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C9;

	// Token: 0x0400F433 RID: 62515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CA;

	// Token: 0x0400F434 RID: 62516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CB;

	// Token: 0x0400F435 RID: 62517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CC;

	// Token: 0x0400F436 RID: 62518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CD;

	// Token: 0x0400F437 RID: 62519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CE;

	// Token: 0x0400F438 RID: 62520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2CF;

	// Token: 0x0400F439 RID: 62521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D0;

	// Token: 0x0400F43A RID: 62522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D1;

	// Token: 0x0400F43B RID: 62523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D2;

	// Token: 0x0400F43C RID: 62524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D3;

	// Token: 0x0400F43D RID: 62525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D4;

	// Token: 0x0400F43E RID: 62526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D5;

	// Token: 0x0400F43F RID: 62527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D6;

	// Token: 0x0400F440 RID: 62528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D7;

	// Token: 0x0400F441 RID: 62529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D8;

	// Token: 0x0400F442 RID: 62530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D9;

	// Token: 0x0400F443 RID: 62531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DA;

	// Token: 0x0400F444 RID: 62532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DB;

	// Token: 0x0400F445 RID: 62533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DC;

	// Token: 0x0400F446 RID: 62534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DD;

	// Token: 0x0400F447 RID: 62535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DE;

	// Token: 0x0400F448 RID: 62536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2DF;

	// Token: 0x0400F449 RID: 62537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E0;

	// Token: 0x0400F44A RID: 62538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E1;

	// Token: 0x0400F44B RID: 62539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E2;

	// Token: 0x0400F44C RID: 62540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E3;

	// Token: 0x0400F44D RID: 62541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E4;

	// Token: 0x0400F44E RID: 62542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E5;

	// Token: 0x0400F44F RID: 62543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E6;

	// Token: 0x0400F450 RID: 62544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E7;

	// Token: 0x0400F451 RID: 62545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E8;

	// Token: 0x0400F452 RID: 62546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E9;

	// Token: 0x0400F453 RID: 62547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2EA;

	// Token: 0x0400F454 RID: 62548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2EB;

	// Token: 0x0400F455 RID: 62549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2EC;

	// Token: 0x0400F456 RID: 62550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2ED;

	// Token: 0x0400F457 RID: 62551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2EE;

	// Token: 0x0400F458 RID: 62552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2EF;

	// Token: 0x0400F459 RID: 62553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F0;

	// Token: 0x0400F45A RID: 62554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F1;

	// Token: 0x0400F45B RID: 62555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F2;

	// Token: 0x0400F45C RID: 62556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F3;

	// Token: 0x0400F45D RID: 62557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F4;

	// Token: 0x0400F45E RID: 62558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F5;

	// Token: 0x0400F45F RID: 62559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F6;

	// Token: 0x0400F460 RID: 62560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F7;

	// Token: 0x0400F461 RID: 62561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F8;

	// Token: 0x0400F462 RID: 62562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F9;

	// Token: 0x0400F463 RID: 62563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FA;

	// Token: 0x0400F464 RID: 62564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FB;

	// Token: 0x0400F465 RID: 62565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FC;

	// Token: 0x0400F466 RID: 62566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FD;

	// Token: 0x0400F467 RID: 62567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FE;

	// Token: 0x0400F468 RID: 62568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2FF;

	// Token: 0x0400F469 RID: 62569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache300;

	// Token: 0x0400F46A RID: 62570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache301;

	// Token: 0x0400F46B RID: 62571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache302;

	// Token: 0x0400F46C RID: 62572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache303;

	// Token: 0x0400F46D RID: 62573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache304;

	// Token: 0x0400F46E RID: 62574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache305;

	// Token: 0x0400F46F RID: 62575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache306;

	// Token: 0x0400F470 RID: 62576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache307;

	// Token: 0x0400F471 RID: 62577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache308;

	// Token: 0x0400F472 RID: 62578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache309;

	// Token: 0x0400F473 RID: 62579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30A;

	// Token: 0x0400F474 RID: 62580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30B;

	// Token: 0x0400F475 RID: 62581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30C;

	// Token: 0x0400F476 RID: 62582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30D;

	// Token: 0x0400F477 RID: 62583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30E;

	// Token: 0x0400F478 RID: 62584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30F;

	// Token: 0x0400F479 RID: 62585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache310;

	// Token: 0x0400F47A RID: 62586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache311;

	// Token: 0x0400F47B RID: 62587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache312;
}
