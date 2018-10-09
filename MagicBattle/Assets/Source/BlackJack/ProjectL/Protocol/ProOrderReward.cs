using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A2 RID: 1698
	[ProtoContract(Name = "ProOrderReward")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProOrderReward : IExtensible
	{
		// Token: 0x06005C09 RID: 23561 RVA: 0x001A4D00 File Offset: 0x001A2F00
		public ProOrderReward()
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

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x001A4D74 File Offset: 0x001A2F74
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x001A4D7C File Offset: 0x001A2F7C
		[ProtoMember(1, IsRequired = true, Name = "OrderId", DataFormat = DataFormat.Default)]
		public string OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				this._OrderId = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x001A4D88 File Offset: 0x001A2F88
		[ProtoMember(2, Name = "Rewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> Rewards
		{
			get
			{
				return this._Rewards;
			}
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x001A4D90 File Offset: 0x001A2F90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x001A4DA0 File Offset: 0x001A2FA0
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

		// Token: 0x06005C0F RID: 23567 RVA: 0x001A4E6C File Offset: 0x001A306C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProOrderReward));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044E5 RID: 17637
		private string _OrderId;

		// Token: 0x040044E6 RID: 17638
		private readonly List<ProGoods> _Rewards = new List<ProGoods>();

		// Token: 0x040044E7 RID: 17639
		private IExtension extensionObject;

		// Token: 0x040044E8 RID: 17640
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044E9 RID: 17641
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044EA RID: 17642
		private LuaFunction m_ctor_hotfix;
	}
}
