using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007FB RID: 2043
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "NewOperationalActivityNtf")]
	[Serializable]
	public class NewOperationalActivityNtf : IExtensible
	{
		// Token: 0x06006798 RID: 26520 RVA: 0x001CD018 File Offset: 0x001CB218
		public NewOperationalActivityNtf()
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

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06006799 RID: 26521 RVA: 0x001CD080 File Offset: 0x001CB280
		// (set) Token: 0x0600679A RID: 26522 RVA: 0x001CD088 File Offset: 0x001CB288
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

		// Token: 0x0600679B RID: 26523 RVA: 0x001CD094 File Offset: 0x001CB294
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x001CD0A4 File Offset: 0x001CB2A4
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

		// Token: 0x0600679D RID: 26525 RVA: 0x001CD170 File Offset: 0x001CB370
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NewOperationalActivityNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D9A RID: 19866
		private ProOperationalActivityBasicInfo _OperationalActivityInfo;

		// Token: 0x04004D9B RID: 19867
		private IExtension extensionObject;

		// Token: 0x04004D9C RID: 19868
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D9D RID: 19869
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D9E RID: 19870
		private LuaFunction m_ctor_hotfix;
	}
}
