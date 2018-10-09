using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000305 RID: 773
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ReplaceAnim")]
	[Serializable]
	public class ReplaceAnim : IExtensible
	{
		// Token: 0x06002E59 RID: 11865 RVA: 0x000B9540 File Offset: 0x000B7740
		public ReplaceAnim()
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x000B95A8 File Offset: 0x000B77A8
		// (set) Token: 0x06002E5B RID: 11867 RVA: 0x000B95B0 File Offset: 0x000B77B0
		[ProtoMember(1, IsRequired = true, Name = "DefaultName", DataFormat = DataFormat.Default)]
		public string DefaultName
		{
			get
			{
				return this._DefaultName;
			}
			set
			{
				this._DefaultName = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x000B95BC File Offset: 0x000B77BC
		// (set) Token: 0x06002E5D RID: 11869 RVA: 0x000B95C4 File Offset: 0x000B77C4
		[ProtoMember(2, IsRequired = true, Name = "ReplaceName", DataFormat = DataFormat.Default)]
		public string ReplaceName
		{
			get
			{
				return this._ReplaceName;
			}
			set
			{
				this._ReplaceName = value;
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000B95D0 File Offset: 0x000B77D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000B95E0 File Offset: 0x000B77E0
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

		// Token: 0x06002E60 RID: 11872 RVA: 0x000B96AC File Offset: 0x000B78AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ReplaceAnim));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400238F RID: 9103
		private string _DefaultName;

		// Token: 0x04002390 RID: 9104
		private string _ReplaceName;

		// Token: 0x04002391 RID: 9105
		private IExtension extensionObject;

		// Token: 0x04002392 RID: 9106
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002393 RID: 9107
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002394 RID: 9108
		private LuaFunction m_ctor_hotfix;
	}
}
