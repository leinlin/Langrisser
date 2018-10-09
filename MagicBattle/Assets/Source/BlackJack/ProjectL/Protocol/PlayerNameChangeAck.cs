using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F8 RID: 1784
	[ProtoContract(Name = "PlayerNameChangeAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class PlayerNameChangeAck : IExtensible
	{
		// Token: 0x06005F17 RID: 24343 RVA: 0x001AEF68 File Offset: 0x001AD168
		public PlayerNameChangeAck()
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

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x001AEFD0 File Offset: 0x001AD1D0
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x001AEFD8 File Offset: 0x001AD1D8
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x001AEFE4 File Offset: 0x001AD1E4
		// (set) Token: 0x06005F1B RID: 24347 RVA: 0x001AEFEC File Offset: 0x001AD1EC
		[ProtoMember(2, IsRequired = true, Name = "NewPlayerName", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005F1C RID: 24348 RVA: 0x001AEFF8 File Offset: 0x001AD1F8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x001AF008 File Offset: 0x001AD208
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

		// Token: 0x06005F1E RID: 24350 RVA: 0x001AF0D4 File Offset: 0x001AD2D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerNameChangeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400472B RID: 18219
		private int _Result;

		// Token: 0x0400472C RID: 18220
		private string _NewPlayerName;

		// Token: 0x0400472D RID: 18221
		private IExtension extensionObject;

		// Token: 0x0400472E RID: 18222
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400472F RID: 18223
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004730 RID: 18224
		private LuaFunction m_ctor_hotfix;
	}
}
