using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FD RID: 2045
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UpdateOperationalActivityNtf")]
	[Serializable]
	public class UpdateOperationalActivityNtf : IExtensible
	{
		// Token: 0x060067A4 RID: 26532 RVA: 0x001CD398 File Offset: 0x001CB598
		public UpdateOperationalActivityNtf()
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

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x001CD400 File Offset: 0x001CB600
		// (set) Token: 0x060067A6 RID: 26534 RVA: 0x001CD408 File Offset: 0x001CB608
		[ProtoMember(1, IsRequired = true, Name = "OperationalActivityInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo OperationalActivityInfo
		{
			get
			{
				return this._OperationalActivityInfo;
			}
			set
			{
				this._OperationalActivityInfo = value;
			}
		}

		// Token: 0x060067A7 RID: 26535 RVA: 0x001CD414 File Offset: 0x001CB614
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x001CD424 File Offset: 0x001CB624
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

		// Token: 0x060067A9 RID: 26537 RVA: 0x001CD4F0 File Offset: 0x001CB6F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UpdateOperationalActivityNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004DA4 RID: 19876
		private ProOperationalActivityBasicInfo _OperationalActivityInfo;

		// Token: 0x04004DA5 RID: 19877
		private IExtension extensionObject;

		// Token: 0x04004DA6 RID: 19878
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004DA7 RID: 19879
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004DA8 RID: 19880
		private LuaFunction m_ctor_hotfix;
	}
}
