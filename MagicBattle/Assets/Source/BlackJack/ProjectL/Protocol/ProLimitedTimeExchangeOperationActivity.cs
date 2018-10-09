using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000666 RID: 1638
	[ProtoContract(Name = "ProLimitedTimeExchangeOperationActivity")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProLimitedTimeExchangeOperationActivity : IExtensible
	{
		// Token: 0x06005978 RID: 22904 RVA: 0x0019D734 File Offset: 0x0019B934
		public ProLimitedTimeExchangeOperationActivity()
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

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06005979 RID: 22905 RVA: 0x0019D7A8 File Offset: 0x0019B9A8
		// (set) Token: 0x0600597A RID: 22906 RVA: 0x0019D7B0 File Offset: 0x0019B9B0
		[ProtoMember(1, IsRequired = true, Name = "BasicInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo BasicInfo
		{
			get
			{
				return this._BasicInfo;
			}
			set
			{
				this._BasicInfo = value;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x0019D7BC File Offset: 0x0019B9BC
		[ProtoMember(2, Name = "ExchangedItemGroups", DataFormat = DataFormat.Default)]
		public List<ProLimitedTimeExchangeOperationActivityItemGroup> ExchangedItemGroups
		{
			get
			{
				return this._ExchangedItemGroups;
			}
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x0019D7C4 File Offset: 0x0019B9C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x0019D7D4 File Offset: 0x0019B9D4
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

		// Token: 0x0600597E RID: 22910 RVA: 0x0019D8A0 File Offset: 0x0019BAA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProLimitedTimeExchangeOperationActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004314 RID: 17172
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x04004315 RID: 17173
		private readonly List<ProLimitedTimeExchangeOperationActivityItemGroup> _ExchangedItemGroups = new List<ProLimitedTimeExchangeOperationActivityItemGroup>();

		// Token: 0x04004316 RID: 17174
		private IExtension extensionObject;

		// Token: 0x04004317 RID: 17175
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004318 RID: 17176
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004319 RID: 17177
		private LuaFunction m_ctor_hotfix;
	}
}
