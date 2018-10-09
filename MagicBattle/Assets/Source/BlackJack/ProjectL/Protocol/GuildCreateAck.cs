using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000753 RID: 1875
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildCreateAck")]
	[Serializable]
	public class GuildCreateAck : IExtensible
	{
		// Token: 0x06006220 RID: 25120 RVA: 0x001B9980 File Offset: 0x001B7B80
		public GuildCreateAck()
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

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06006221 RID: 25121 RVA: 0x001B99E8 File Offset: 0x001B7BE8
		// (set) Token: 0x06006222 RID: 25122 RVA: 0x001B99F0 File Offset: 0x001B7BF0
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x001B99FC File Offset: 0x001B7BFC
		// (set) Token: 0x06006224 RID: 25124 RVA: 0x001B9A04 File Offset: 0x001B7C04
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06006225 RID: 25125 RVA: 0x001B9A10 File Offset: 0x001B7C10
		// (set) Token: 0x06006226 RID: 25126 RVA: 0x001B9A18 File Offset: 0x001B7C18
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

		// Token: 0x06006227 RID: 25127 RVA: 0x001B9A24 File Offset: 0x001B7C24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x001B9A34 File Offset: 0x001B7C34
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

		// Token: 0x06006229 RID: 25129 RVA: 0x001B9B00 File Offset: 0x001B7D00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildCreateAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400497E RID: 18814
		private int _Result;

		// Token: 0x0400497F RID: 18815
		private ProGuild _Guild;

		// Token: 0x04004980 RID: 18816
		private long _LastUpdateTime;

		// Token: 0x04004981 RID: 18817
		private IExtension extensionObject;

		// Token: 0x04004982 RID: 18818
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004983 RID: 18819
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004984 RID: 18820
		private LuaFunction m_ctor_hotfix;
	}
}
