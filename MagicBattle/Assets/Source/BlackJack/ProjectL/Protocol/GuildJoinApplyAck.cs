using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000755 RID: 1877
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinApplyAck")]
	[Serializable]
	public class GuildJoinApplyAck : IExtensible
	{
		// Token: 0x06006230 RID: 25136 RVA: 0x001B9D28 File Offset: 0x001B7F28
		public GuildJoinApplyAck()
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

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06006231 RID: 25137 RVA: 0x001B9D90 File Offset: 0x001B7F90
		// (set) Token: 0x06006232 RID: 25138 RVA: 0x001B9D98 File Offset: 0x001B7F98
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x001B9DA4 File Offset: 0x001B7FA4
		// (set) Token: 0x06006234 RID: 25140 RVA: 0x001B9DAC File Offset: 0x001B7FAC
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

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x001B9DB8 File Offset: 0x001B7FB8
		// (set) Token: 0x06006236 RID: 25142 RVA: 0x001B9DC0 File Offset: 0x001B7FC0
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

		// Token: 0x06006237 RID: 25143 RVA: 0x001B9DCC File Offset: 0x001B7FCC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x001B9DDC File Offset: 0x001B7FDC
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

		// Token: 0x06006239 RID: 25145 RVA: 0x001B9EA8 File Offset: 0x001B80A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400498A RID: 18826
		private int _Result;

		// Token: 0x0400498B RID: 18827
		private ProGuild _Guild;

		// Token: 0x0400498C RID: 18828
		private long _LastUpdateTime;

		// Token: 0x0400498D RID: 18829
		private IExtension extensionObject;

		// Token: 0x0400498E RID: 18830
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400498F RID: 18831
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004990 RID: 18832
		private LuaFunction m_ctor_hotfix;
	}
}
