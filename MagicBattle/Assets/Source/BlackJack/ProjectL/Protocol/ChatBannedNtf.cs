using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000626 RID: 1574
	[ProtoContract(Name = "ChatBannedNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatBannedNtf : IExtensible
	{
		// Token: 0x0600568A RID: 22154 RVA: 0x001956D4 File Offset: 0x001938D4
		public ChatBannedNtf()
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

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x0019573C File Offset: 0x0019393C
		// (set) Token: 0x0600568C RID: 22156 RVA: 0x00195744 File Offset: 0x00193944
		[ProtoMember(1, IsRequired = true, Name = "BannedTime", DataFormat = DataFormat.TwosComplement)]
		public long BannedTime
		{
			get
			{
				return this._BannedTime;
			}
			set
			{
				this._BannedTime = value;
			}
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x00195750 File Offset: 0x00193950
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x00195760 File Offset: 0x00193960
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

		// Token: 0x0600568F RID: 22159 RVA: 0x0019582C File Offset: 0x00193A2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatBannedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004105 RID: 16645
		private long _BannedTime;

		// Token: 0x04004106 RID: 16646
		private IExtension extensionObject;

		// Token: 0x04004107 RID: 16647
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004108 RID: 16648
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004109 RID: 16649
		private LuaFunction m_ctor_hotfix;
	}
}
