using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074C RID: 1868
	[ProtoContract(Name = "PullOrderRewardReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class PullOrderRewardReq : IExtensible
	{
		// Token: 0x060061E2 RID: 25058 RVA: 0x001B8C6C File Offset: 0x001B6E6C
		public PullOrderRewardReq()
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

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x001B8CD4 File Offset: 0x001B6ED4
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x001B8CDC File Offset: 0x001B6EDC
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

		// Token: 0x060061E5 RID: 25061 RVA: 0x001B8CE8 File Offset: 0x001B6EE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x001B8CF8 File Offset: 0x001B6EF8
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

		// Token: 0x060061E7 RID: 25063 RVA: 0x001B8DC4 File Offset: 0x001B6FC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PullOrderRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004951 RID: 18769
		private string _OrderId;

		// Token: 0x04004952 RID: 18770
		private IExtension extensionObject;

		// Token: 0x04004953 RID: 18771
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004954 RID: 18772
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004955 RID: 18773
		private LuaFunction m_ctor_hotfix;
	}
}
