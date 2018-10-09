using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F6 RID: 4598
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionBag : LuaObject
{
	// Token: 0x06017D79 RID: 97657 RVA: 0x0069457C File Offset: 0x0069277C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag o = new DataSectionBag();
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

	// Token: 0x06017D7A RID: 97658 RVA: 0x006945C4 File Offset: 0x006927C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			dataSectionBag.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D7B RID: 97659 RVA: 0x00694610 File Offset: 0x00692810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeMultipleToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			List<object> o = dataSectionBag.SerializeMultipleToClient();
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

	// Token: 0x06017D7C RID: 97660 RVA: 0x00694664 File Offset: 0x00692864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBagItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			dataSectionBag.InitBagItem(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D7D RID: 97661 RVA: 0x006946BC File Offset: 0x006928BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBagItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			dataSectionBag.AddBagItem(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D7E RID: 97662 RVA: 0x00694714 File Offset: 0x00692914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBagItemNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			BagItemBase o = dataSectionBag.SetBagItemNums(bagItem, nums);
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

	// Token: 0x06017D7F RID: 97663 RVA: 0x00694784 File Offset: 0x00692984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveBagItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			BagItemBase o = dataSectionBag.RemoveBagItem(bagItem, nums);
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

	// Token: 0x06017D80 RID: 97664 RVA: 0x006947F4 File Offset: 0x006929F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			dataSectionBag.RemoveAllBagItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D81 RID: 97665 RVA: 0x00694840 File Offset: 0x00692A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindBagItem(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
				ulong instanceId;
				LuaObject.checkType(l, 2, out instanceId);
				BagItemBase o = dataSectionBag.FindBagItem(instanceId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				DataSectionBag dataSectionBag2 = (DataSectionBag)LuaObject.checkSelf(l);
				GoodsType goodsTypeId;
				LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
				int contentId;
				LuaObject.checkType(l, 3, out contentId);
				BagItemBase o2 = dataSectionBag2.FindBagItem(goodsTypeId, contentId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindBagItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D82 RID: 97666 RVA: 0x00694918 File Offset: 0x00692B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBagItemDirty(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemBase bagItemDirty;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItemDirty);
			dataSectionBag.SetBagItemDirty(bagItemDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D83 RID: 97667 RVA: 0x00694970 File Offset: 0x00692B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Size(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			int i = dataSectionBag.Size();
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

	// Token: 0x06017D84 RID: 97668 RVA: 0x006949C4 File Offset: 0x00692BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			List<BagItemBase> allBagItems = dataSectionBag.GetAllBagItems();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allBagItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D85 RID: 97669 RVA: 0x00694A18 File Offset: 0x00692C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IterateAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			IEnumerable<BagItemBase> o = dataSectionBag.IterateAllBagItems();
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

	// Token: 0x06017D86 RID: 97670 RVA: 0x00694A6C File Offset: 0x00692C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId2CacheIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBag.InstanceId2CacheIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D87 RID: 97671 RVA: 0x00694AC0 File Offset: 0x00692CC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Bag(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionBag.Bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D88 RID: 97672 RVA: 0x00694B14 File Offset: 0x00692D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Bag(IntPtr l)
	{
		int result;
		try
		{
			DataSectionBag dataSectionBag = (DataSectionBag)LuaObject.checkSelf(l);
			BagItemUpdateCache bag;
			LuaObject.checkType<BagItemUpdateCache>(l, 2, out bag);
			dataSectionBag.Bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D89 RID: 97673 RVA: 0x00694B6C File Offset: 0x00692D6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionBag");
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.SerializeMultipleToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.InitBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.AddBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.SetBagItemNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.RemoveBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.RemoveAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.FindBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.SetBagItemDirty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.Size);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.GetAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.IterateAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheB);
		string name = "InstanceId2CacheIndex";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.get_InstanceId2CacheIndex);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheC, null, true);
		string name2 = "Bag";
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.get_Bag);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.set_Bag);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheE, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionBag.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionBag.<>f__mg$cacheF, typeof(DataSectionBag), typeof(DataSection));
	}

	// Token: 0x0400E36F RID: 58223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E370 RID: 58224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E371 RID: 58225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E372 RID: 58226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E373 RID: 58227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E374 RID: 58228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E375 RID: 58229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E376 RID: 58230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E377 RID: 58231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E378 RID: 58232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E379 RID: 58233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E37A RID: 58234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E37B RID: 58235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E37C RID: 58236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E37D RID: 58237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E37E RID: 58238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
