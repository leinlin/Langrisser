using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E1 RID: 1761
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeDeclineReq")]
	[Serializable]
	public class BattlePracticeDeclineReq : IExtensible
	{
		// Token: 0x06005E40 RID: 24128 RVA: 0x001AC3E0 File Offset: 0x001AA5E0
		public BattlePracticeDeclineReq()
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

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x001AC448 File Offset: 0x001AA648
		// (set) Token: 0x06005E42 RID: 24130 RVA: 0x001AC450 File Offset: 0x001AA650
		[ProtoMember(1, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x001AC45C File Offset: 0x001AA65C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x001AC46C File Offset: 0x001AA66C
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

		// Token: 0x06005E45 RID: 24133 RVA: 0x001AC538 File Offset: 0x001AA738
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeDeclineReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400468F RID: 18063
		private string _TargetUserId;

		// Token: 0x04004690 RID: 18064
		private IExtension extensionObject;

		// Token: 0x04004691 RID: 18065
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004692 RID: 18066
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004693 RID: 18067
		private LuaFunction m_ctor_hotfix;
	}
}
