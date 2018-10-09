using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F7 RID: 1783
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "PlayerNameChangeReq")]
	[Serializable]
	public class PlayerNameChangeReq : IExtensible
	{
		// Token: 0x06005F11 RID: 24337 RVA: 0x001AEDA8 File Offset: 0x001ACFA8
		public PlayerNameChangeReq()
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

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06005F12 RID: 24338 RVA: 0x001AEE10 File Offset: 0x001AD010
		// (set) Token: 0x06005F13 RID: 24339 RVA: 0x001AEE18 File Offset: 0x001AD018
		[ProtoMember(1, IsRequired = true, Name = "NewPlayerName", DataFormat = DataFormat.Default)]
		public string NewPlayerName
		{
			get
			{
				return this._NewPlayerName;
			}
			set
			{
				this._NewPlayerName = value;
			}
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x001AEE24 File Offset: 0x001AD024
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x001AEE34 File Offset: 0x001AD034
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

		// Token: 0x06005F16 RID: 24342 RVA: 0x001AEF00 File Offset: 0x001AD100
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerNameChangeReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004726 RID: 18214
		private string _NewPlayerName;

		// Token: 0x04004727 RID: 18215
		private IExtension extensionObject;

		// Token: 0x04004728 RID: 18216
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004729 RID: 18217
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400472A RID: 18218
		private LuaFunction m_ctor_hotfix;
	}
}
