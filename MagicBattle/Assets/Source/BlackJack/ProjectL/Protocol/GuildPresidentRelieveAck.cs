using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077E RID: 1918
	[ProtoContract(Name = "GuildPresidentRelieveAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildPresidentRelieveAck : IExtensible
	{
		// Token: 0x06006359 RID: 25433 RVA: 0x001BE72C File Offset: 0x001BC92C
		public GuildPresidentRelieveAck()
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

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x001BE794 File Offset: 0x001BC994
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x001BE79C File Offset: 0x001BC99C
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

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x001BE7A8 File Offset: 0x001BC9A8
		// (set) Token: 0x0600635D RID: 25437 RVA: 0x001BE7B0 File Offset: 0x001BC9B0
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600635E RID: 25438 RVA: 0x001BE7BC File Offset: 0x001BC9BC
		// (set) Token: 0x0600635F RID: 25439 RVA: 0x001BE7C4 File Offset: 0x001BC9C4
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Guild", DataFormat = DataFormat.Default)]
		public ProGuild Guild
		{
			get
			{
				return this._Guild;
			}
			set
			{
				this._Guild = value;
			}
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x001BE7D0 File Offset: 0x001BC9D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x001BE7E0 File Offset: 0x001BC9E0
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

		// Token: 0x06006362 RID: 25442 RVA: 0x001BE8AC File Offset: 0x001BCAAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildPresidentRelieveAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A73 RID: 19059
		private int _Result;

		// Token: 0x04004A74 RID: 19060
		private string _UserId;

		// Token: 0x04004A75 RID: 19061
		private ProGuild _Guild;

		// Token: 0x04004A76 RID: 19062
		private IExtension extensionObject;

		// Token: 0x04004A77 RID: 19063
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A78 RID: 19064
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A79 RID: 19065
		private LuaFunction m_ctor_hotfix;
	}
}
