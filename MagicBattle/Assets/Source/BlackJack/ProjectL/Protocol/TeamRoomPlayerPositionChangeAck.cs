using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083F RID: 2111
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomPlayerPositionChangeAck")]
	[Serializable]
	public class TeamRoomPlayerPositionChangeAck : IExtensible
	{
		// Token: 0x060069BB RID: 27067 RVA: 0x001DC118 File Offset: 0x001DA318
		public TeamRoomPlayerPositionChangeAck()
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

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x060069BC RID: 27068 RVA: 0x001DC180 File Offset: 0x001DA380
		// (set) Token: 0x060069BD RID: 27069 RVA: 0x001DC188 File Offset: 0x001DA388
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

		// Token: 0x060069BE RID: 27070 RVA: 0x001DC194 File Offset: 0x001DA394
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x001DC1A4 File Offset: 0x001DA3A4
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

		// Token: 0x060069C0 RID: 27072 RVA: 0x001DC270 File Offset: 0x001DA470
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomPlayerPositionChangeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400517B RID: 20859
		private int _Result;

		// Token: 0x0400517C RID: 20860
		private IExtension extensionObject;

		// Token: 0x0400517D RID: 20861
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400517E RID: 20862
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400517F RID: 20863
		private LuaFunction m_ctor_hotfix;
	}
}
