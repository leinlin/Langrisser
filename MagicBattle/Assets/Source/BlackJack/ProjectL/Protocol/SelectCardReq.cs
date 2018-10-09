using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000820 RID: 2080
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SelectCardReq")]
	[Serializable]
	public class SelectCardReq : IExtensible
	{
		// Token: 0x060068D2 RID: 26834 RVA: 0x001D88D0 File Offset: 0x001D6AD0
		public SelectCardReq()
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

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x001D8938 File Offset: 0x001D6B38
		// (set) Token: 0x060068D4 RID: 26836 RVA: 0x001D8940 File Offset: 0x001D6B40
		[ProtoMember(1, IsRequired = true, Name = "CardPoolId", DataFormat = DataFormat.TwosComplement)]
		public int CardPoolId
		{
			get
			{
				return this._CardPoolId;
			}
			set
			{
				this._CardPoolId = value;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060068D5 RID: 26837 RVA: 0x001D894C File Offset: 0x001D6B4C
		// (set) Token: 0x060068D6 RID: 26838 RVA: 0x001D8954 File Offset: 0x001D6B54
		[ProtoMember(2, IsRequired = true, Name = "IsSingleSelect", DataFormat = DataFormat.Default)]
		public bool IsSingleSelect
		{
			get
			{
				return this._IsSingleSelect;
			}
			set
			{
				this._IsSingleSelect = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060068D7 RID: 26839 RVA: 0x001D8960 File Offset: 0x001D6B60
		// (set) Token: 0x060068D8 RID: 26840 RVA: 0x001D8968 File Offset: 0x001D6B68
		[ProtoMember(3, IsRequired = true, Name = "IsUsingTicket", DataFormat = DataFormat.Default)]
		public bool IsUsingTicket
		{
			get
			{
				return this._IsUsingTicket;
			}
			set
			{
				this._IsUsingTicket = value;
			}
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x001D8974 File Offset: 0x001D6B74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x001D8984 File Offset: 0x001D6B84
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

		// Token: 0x060068DB RID: 26843 RVA: 0x001D8A50 File Offset: 0x001D6C50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050C6 RID: 20678
		private int _CardPoolId;

		// Token: 0x040050C7 RID: 20679
		private bool _IsSingleSelect;

		// Token: 0x040050C8 RID: 20680
		private bool _IsUsingTicket;

		// Token: 0x040050C9 RID: 20681
		private IExtension extensionObject;

		// Token: 0x040050CA RID: 20682
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050CB RID: 20683
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050CC RID: 20684
		private LuaFunction m_ctor_hotfix;
	}
}
