using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000257 RID: 599
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataItemInfo")]
	[Serializable]
	public class ConfigDataItemInfo : IExtensible
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x000A91C4 File Offset: 0x000A73C4
		public ConfigDataItemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000A9240 File Offset: 0x000A7440
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x000A9248 File Offset: 0x000A7448
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000A9254 File Offset: 0x000A7454
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x000A925C File Offset: 0x000A745C
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000A9268 File Offset: 0x000A7468
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x000A9270 File Offset: 0x000A7470
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000A927C File Offset: 0x000A747C
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x000A9284 File Offset: 0x000A7484
		[ProtoMember(5, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000A9290 File Offset: 0x000A7490
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x000A9298 File Offset: 0x000A7498
		[ProtoMember(6, IsRequired = true, Name = "SellGold", DataFormat = DataFormat.TwosComplement)]
		public int SellGold
		{
			get
			{
				return this._SellGold;
			}
			set
			{
				this._SellGold = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000A92A4 File Offset: 0x000A74A4
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x000A92AC File Offset: 0x000A74AC
		[ProtoMember(7, IsRequired = true, Name = "DisplayType", DataFormat = DataFormat.TwosComplement)]
		public ItemDisplayType DisplayType
		{
			get
			{
				return this._DisplayType;
			}
			set
			{
				this._DisplayType = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000A92B8 File Offset: 0x000A74B8
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x000A92C0 File Offset: 0x000A74C0
		[ProtoMember(8, IsRequired = true, Name = "FuncType", DataFormat = DataFormat.TwosComplement)]
		public ItemFuncType FuncType
		{
			get
			{
				return this._FuncType;
			}
			set
			{
				this._FuncType = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x000A92CC File Offset: 0x000A74CC
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x000A92D4 File Offset: 0x000A74D4
		[ProtoMember(9, IsRequired = true, Name = "FuncTypeParam1", DataFormat = DataFormat.TwosComplement)]
		public int FuncTypeParam1
		{
			get
			{
				return this._FuncTypeParam1;
			}
			set
			{
				this._FuncTypeParam1 = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000A92E0 File Offset: 0x000A74E0
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x000A92E8 File Offset: 0x000A74E8
		[ProtoMember(10, IsRequired = true, Name = "FuncTypeParam2", DataFormat = DataFormat.TwosComplement)]
		public int FuncTypeParam2
		{
			get
			{
				return this._FuncTypeParam2;
			}
			set
			{
				this._FuncTypeParam2 = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000A92F4 File Offset: 0x000A74F4
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x000A92FC File Offset: 0x000A74FC
		[ProtoMember(11, IsRequired = true, Name = "FuncTypeParam3", DataFormat = DataFormat.TwosComplement)]
		public int FuncTypeParam3
		{
			get
			{
				return this._FuncTypeParam3;
			}
			set
			{
				this._FuncTypeParam3 = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000A9308 File Offset: 0x000A7508
		[ProtoMember(12, Name = "FuncTypeParam4", DataFormat = DataFormat.TwosComplement)]
		public List<int> FuncTypeParam4
		{
			get
			{
				return this._FuncTypeParam4;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000A9310 File Offset: 0x000A7510
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x000A9318 File Offset: 0x000A7518
		[ProtoMember(13, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000A9324 File Offset: 0x000A7524
		[ProtoMember(15, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000A932C File Offset: 0x000A752C
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x000A9334 File Offset: 0x000A7534
		[ProtoMember(16, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
		public string GetPathDesc
		{
			get
			{
				return this._GetPathDesc;
			}
			set
			{
				this._GetPathDesc = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000A9340 File Offset: 0x000A7540
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x000A9348 File Offset: 0x000A7548
		[ProtoMember(17, IsRequired = true, Name = "AlchemyGold", DataFormat = DataFormat.TwosComplement)]
		public int AlchemyGold
		{
			get
			{
				return this._AlchemyGold;
			}
			set
			{
				this._AlchemyGold = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000A9354 File Offset: 0x000A7554
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x000A935C File Offset: 0x000A755C
		[ProtoMember(18, IsRequired = true, Name = "RandomDropRewardID", DataFormat = DataFormat.TwosComplement)]
		public int RandomDropRewardID
		{
			get
			{
				return this._RandomDropRewardID;
			}
			set
			{
				this._RandomDropRewardID = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000A9368 File Offset: 0x000A7568
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x000A9370 File Offset: 0x000A7570
		[ProtoMember(19, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
		public int DisplayRewardCount
		{
			get
			{
				return this._DisplayRewardCount;
			}
			set
			{
				this._DisplayRewardCount = value;
			}
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000A937C File Offset: 0x000A757C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000A938C File Offset: 0x000A758C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000A9458 File Offset: 0x000A7658
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataItemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016F6 RID: 5878
		private int _ID;

		// Token: 0x040016F7 RID: 5879
		private string _Name;

		// Token: 0x040016F8 RID: 5880
		private string _Desc;

		// Token: 0x040016F9 RID: 5881
		private int _Rank;

		// Token: 0x040016FA RID: 5882
		private int _SellGold;

		// Token: 0x040016FB RID: 5883
		private ItemDisplayType _DisplayType;

		// Token: 0x040016FC RID: 5884
		private ItemFuncType _FuncType;

		// Token: 0x040016FD RID: 5885
		private int _FuncTypeParam1;

		// Token: 0x040016FE RID: 5886
		private int _FuncTypeParam2;

		// Token: 0x040016FF RID: 5887
		private int _FuncTypeParam3;

		// Token: 0x04001700 RID: 5888
		private readonly List<int> _FuncTypeParam4 = new List<int>();

		// Token: 0x04001701 RID: 5889
		private string _Icon;

		// Token: 0x04001702 RID: 5890
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x04001703 RID: 5891
		private string _GetPathDesc;

		// Token: 0x04001704 RID: 5892
		private int _AlchemyGold;

		// Token: 0x04001705 RID: 5893
		private int _RandomDropRewardID;

		// Token: 0x04001706 RID: 5894
		private int _DisplayRewardCount;

		// Token: 0x04001707 RID: 5895
		private IExtension extensionObject;

		// Token: 0x04001708 RID: 5896
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001709 RID: 5897
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400170A RID: 5898
		private LuaFunction m_ctor_hotfix;
	}
}
