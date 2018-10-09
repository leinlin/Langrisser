using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D2 RID: 1746
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BusinessCardSelectReq")]
	[Serializable]
	public class BusinessCardSelectReq : IExtensible
	{
		// Token: 0x06005DD6 RID: 24022 RVA: 0x001AA8E0 File Offset: 0x001A8AE0
		public BusinessCardSelectReq()
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

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x001AA948 File Offset: 0x001A8B48
		// (set) Token: 0x06005DD8 RID: 24024 RVA: 0x001AA950 File Offset: 0x001A8B50
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

		// Token: 0x06005DD9 RID: 24025 RVA: 0x001AA95C File Offset: 0x001A8B5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x001AA96C File Offset: 0x001A8B6C
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

		// Token: 0x06005DDB RID: 24027 RVA: 0x001AAA38 File Offset: 0x001A8C38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardSelectReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400463B RID: 17979
		private string _TargetUserId;

		// Token: 0x0400463C RID: 17980
		private IExtension extensionObject;

		// Token: 0x0400463D RID: 17981
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400463E RID: 17982
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400463F RID: 17983
		private LuaFunction m_ctor_hotfix;
	}
}
