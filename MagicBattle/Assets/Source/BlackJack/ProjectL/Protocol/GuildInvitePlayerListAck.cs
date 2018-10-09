using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076E RID: 1902
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildInvitePlayerListAck")]
	[Serializable]
	public class GuildInvitePlayerListAck : IExtensible
	{
		// Token: 0x060062D6 RID: 25302 RVA: 0x001BC9C4 File Offset: 0x001BABC4
		public GuildInvitePlayerListAck()
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

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x001BCA38 File Offset: 0x001BAC38
		// (set) Token: 0x060062D8 RID: 25304 RVA: 0x001BCA40 File Offset: 0x001BAC40
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x001BCA4C File Offset: 0x001BAC4C
		[ProtoMember(4, Name = "PlayerList", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> PlayerList
		{
			get
			{
				return this._PlayerList;
			}
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x001BCA54 File Offset: 0x001BAC54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x001BCA64 File Offset: 0x001BAC64
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

		// Token: 0x060062DC RID: 25308 RVA: 0x001BCB30 File Offset: 0x001BAD30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildInvitePlayerListAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A11 RID: 18961
		private int _Result;

		// Token: 0x04004A12 RID: 18962
		private readonly List<ProUserSummary> _PlayerList = new List<ProUserSummary>();

		// Token: 0x04004A13 RID: 18963
		private IExtension extensionObject;

		// Token: 0x04004A14 RID: 18964
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A15 RID: 18965
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A16 RID: 18966
		private LuaFunction m_ctor_hotfix;
	}
}
