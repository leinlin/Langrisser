using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077A RID: 1914
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildKickOutAck")]
	[Serializable]
	public class GuildKickOutAck : IExtensible
	{
		// Token: 0x0600633B RID: 25403 RVA: 0x001BDFF0 File Offset: 0x001BC1F0
		public GuildKickOutAck()
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

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x001BE058 File Offset: 0x001BC258
		// (set) Token: 0x0600633D RID: 25405 RVA: 0x001BE060 File Offset: 0x001BC260
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

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x001BE06C File Offset: 0x001BC26C
		// (set) Token: 0x0600633F RID: 25407 RVA: 0x001BE074 File Offset: 0x001BC274
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Guild", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x001BE080 File Offset: 0x001BC280
		// (set) Token: 0x06006341 RID: 25409 RVA: 0x001BE088 File Offset: 0x001BC288
		[DefaultValue(0L)]
		[ProtoMember(3, IsRequired = false, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x001BE094 File Offset: 0x001BC294
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x001BE0A4 File Offset: 0x001BC2A4
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

		// Token: 0x06006344 RID: 25412 RVA: 0x001BE170 File Offset: 0x001BC370
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildKickOutAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A5C RID: 19036
		private int _Result;

		// Token: 0x04004A5D RID: 19037
		private ProGuild _Guild;

		// Token: 0x04004A5E RID: 19038
		private long _LastUpdateTime;

		// Token: 0x04004A5F RID: 19039
		private IExtension extensionObject;

		// Token: 0x04004A60 RID: 19040
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A61 RID: 19041
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A62 RID: 19042
		private LuaFunction m_ctor_hotfix;
	}
}
