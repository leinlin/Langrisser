using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000831 RID: 2097
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomAuthorityChangeAck")]
	[Serializable]
	public class TeamRoomAuthorityChangeAck : IExtensible
	{
		// Token: 0x06006956 RID: 26966 RVA: 0x001DA7D0 File Offset: 0x001D89D0
		public TeamRoomAuthorityChangeAck()
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x001DA838 File Offset: 0x001D8A38
		// (set) Token: 0x06006958 RID: 26968 RVA: 0x001DA840 File Offset: 0x001D8A40
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x001DA84C File Offset: 0x001D8A4C
		// (set) Token: 0x0600695A RID: 26970 RVA: 0x001DA854 File Offset: 0x001D8A54
		[ProtoMember(2, IsRequired = true, Name = "Authority", DataFormat = DataFormat.TwosComplement)]
		public int Authority
		{
			get
			{
				return this._Authority;
			}
			set
			{
				this._Authority = value;
			}
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x001DA860 File Offset: 0x001D8A60
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x001DA870 File Offset: 0x001D8A70
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

		// Token: 0x0600695D RID: 26973 RVA: 0x001DA93C File Offset: 0x001D8B3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAuthorityChangeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400512B RID: 20779
		private int _Result;

		// Token: 0x0400512C RID: 20780
		private int _Authority;

		// Token: 0x0400512D RID: 20781
		private IExtension extensionObject;

		// Token: 0x0400512E RID: 20782
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400512F RID: 20783
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005130 RID: 20784
		private LuaFunction m_ctor_hotfix;
	}
}
