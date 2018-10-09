using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073A RID: 1850
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSGiftStoreNtf")]
	[Serializable]
	public class DSGiftStoreNtf : IExtensible
	{
		// Token: 0x06006153 RID: 24915 RVA: 0x001B6B60 File Offset: 0x001B4D60
		public DSGiftStoreNtf()
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

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06006154 RID: 24916 RVA: 0x001B6BE8 File Offset: 0x001B4DE8
		// (set) Token: 0x06006155 RID: 24917 RVA: 0x001B6BF0 File Offset: 0x001B4DF0
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x001B6BFC File Offset: 0x001B4DFC
		[ProtoMember(2, Name = "BoughtItems", DataFormat = DataFormat.Default)]
		public List<ProGiftStoreItem> BoughtItems
		{
			get
			{
				return this._BoughtItems;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06006157 RID: 24919 RVA: 0x001B6C04 File Offset: 0x001B4E04
		[ProtoMember(3, Name = "Records", DataFormat = DataFormat.Default)]
		public List<ProGiftStoreFirstBoughtRecord> Records
		{
			get
			{
				return this._Records;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x001B6C0C File Offset: 0x001B4E0C
		[ProtoMember(4, Name = "OrderRewards", DataFormat = DataFormat.Default)]
		public List<ProOrderReward> OrderRewards
		{
			get
			{
				return this._OrderRewards;
			}
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x001B6C14 File Offset: 0x001B4E14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x001B6C24 File Offset: 0x001B4E24
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

		// Token: 0x0600615B RID: 24923 RVA: 0x001B6CF0 File Offset: 0x001B4EF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSGiftStoreNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048E3 RID: 18659
		private uint _Version;

		// Token: 0x040048E4 RID: 18660
		private readonly List<ProGiftStoreItem> _BoughtItems = new List<ProGiftStoreItem>();

		// Token: 0x040048E5 RID: 18661
		private readonly List<ProGiftStoreFirstBoughtRecord> _Records = new List<ProGiftStoreFirstBoughtRecord>();

		// Token: 0x040048E6 RID: 18662
		private readonly List<ProOrderReward> _OrderRewards = new List<ProOrderReward>();

		// Token: 0x040048E7 RID: 18663
		private IExtension extensionObject;

		// Token: 0x040048E8 RID: 18664
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048E9 RID: 18665
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048EA RID: 18666
		private LuaFunction m_ctor_hotfix;
	}
}
