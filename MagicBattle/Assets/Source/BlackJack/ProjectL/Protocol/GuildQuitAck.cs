using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000778 RID: 1912
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildQuitAck")]
	[Serializable]
	public class GuildQuitAck : IExtensible
	{
		// Token: 0x0600632D RID: 25389 RVA: 0x001BDC5C File Offset: 0x001BBE5C
		public GuildQuitAck()
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

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x001BDCC4 File Offset: 0x001BBEC4
		// (set) Token: 0x0600632F RID: 25391 RVA: 0x001BDCCC File Offset: 0x001BBECC
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

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x001BDCD8 File Offset: 0x001BBED8
		// (set) Token: 0x06006331 RID: 25393 RVA: 0x001BDCE0 File Offset: 0x001BBEE0
		[DefaultValue(0L)]
		[ProtoMember(2, IsRequired = false, Name = "NextJoinTime", DataFormat = DataFormat.TwosComplement)]
		public long NextJoinTime
		{
			get
			{
				return this._NextJoinTime;
			}
			set
			{
				this._NextJoinTime = value;
			}
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x001BDCEC File Offset: 0x001BBEEC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x001BDCFC File Offset: 0x001BBEFC
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

		// Token: 0x06006334 RID: 25396 RVA: 0x001BDDC8 File Offset: 0x001BBFC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildQuitAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A51 RID: 19025
		private int _Result;

		// Token: 0x04004A52 RID: 19026
		private long _NextJoinTime;

		// Token: 0x04004A53 RID: 19027
		private IExtension extensionObject;

		// Token: 0x04004A54 RID: 19028
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A55 RID: 19029
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A56 RID: 19030
		private LuaFunction m_ctor_hotfix;
	}
}
