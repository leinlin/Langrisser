using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000742 RID: 1858
	[ProtoContract(Name = "GiftStoreBuyGoodsNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GiftStoreBuyGoodsNtf : IExtensible
	{
		// Token: 0x06006195 RID: 24981 RVA: 0x001B7A38 File Offset: 0x001B5C38
		public GiftStoreBuyGoodsNtf()
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

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06006196 RID: 24982 RVA: 0x001B7AA0 File Offset: 0x001B5CA0
		// (set) Token: 0x06006197 RID: 24983 RVA: 0x001B7AA8 File Offset: 0x001B5CA8
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x001B7AB4 File Offset: 0x001B5CB4
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x001B7ABC File Offset: 0x001B5CBC
		[ProtoMember(2, IsRequired = true, Name = "GoodsRegisterId", DataFormat = DataFormat.Default)]
		public string GoodsRegisterId
		{
			get
			{
				return this._GoodsRegisterId;
			}
			set
			{
				this._GoodsRegisterId = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x001B7AC8 File Offset: 0x001B5CC8
		// (set) Token: 0x0600619B RID: 24987 RVA: 0x001B7AD0 File Offset: 0x001B5CD0
		[ProtoMember(3, IsRequired = true, Name = "BoughtNums", DataFormat = DataFormat.TwosComplement)]
		public int BoughtNums
		{
			get
			{
				return this._BoughtNums;
			}
			set
			{
				this._BoughtNums = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600619C RID: 24988 RVA: 0x001B7ADC File Offset: 0x001B5CDC
		// (set) Token: 0x0600619D RID: 24989 RVA: 0x001B7AE4 File Offset: 0x001B5CE4
		[ProtoMember(4, IsRequired = true, Name = "NextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushTime
		{
			get
			{
				return this._NextFlushTime;
			}
			set
			{
				this._NextFlushTime = value;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600619E RID: 24990 RVA: 0x001B7AF0 File Offset: 0x001B5CF0
		// (set) Token: 0x0600619F RID: 24991 RVA: 0x001B7AF8 File Offset: 0x001B5CF8
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060061A0 RID: 24992 RVA: 0x001B7B04 File Offset: 0x001B5D04
		// (set) Token: 0x060061A1 RID: 24993 RVA: 0x001B7B0C File Offset: 0x001B5D0C
		[ProtoMember(6, IsRequired = true, Name = "Reward", DataFormat = DataFormat.Default)]
		public ProOrderReward Reward
		{
			get
			{
				return this._Reward;
			}
			set
			{
				this._Reward = value;
			}
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x001B7B18 File Offset: 0x001B5D18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x001B7B28 File Offset: 0x001B5D28
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

		// Token: 0x060061A4 RID: 24996 RVA: 0x001B7BF4 File Offset: 0x001B5DF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreBuyGoodsNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004916 RID: 18710
		private int _GoodsId;

		// Token: 0x04004917 RID: 18711
		private string _GoodsRegisterId;

		// Token: 0x04004918 RID: 18712
		private int _BoughtNums;

		// Token: 0x04004919 RID: 18713
		private long _NextFlushTime;

		// Token: 0x0400491A RID: 18714
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x0400491B RID: 18715
		private ProOrderReward _Reward;

		// Token: 0x0400491C RID: 18716
		private IExtension extensionObject;

		// Token: 0x0400491D RID: 18717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400491E RID: 18718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400491F RID: 18719
		private LuaFunction m_ctor_hotfix;
	}
}
