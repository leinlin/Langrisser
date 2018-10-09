using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000833 RID: 2099
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomJoinAck")]
	[Serializable]
	public class TeamRoomJoinAck : IExtensible
	{
		// Token: 0x0600696A RID: 26986 RVA: 0x001DABA0 File Offset: 0x001D8DA0
		public TeamRoomJoinAck()
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x001DAC08 File Offset: 0x001D8E08
		// (set) Token: 0x0600696C RID: 26988 RVA: 0x001DAC10 File Offset: 0x001D8E10
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

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600696D RID: 26989 RVA: 0x001DAC1C File Offset: 0x001D8E1C
		// (set) Token: 0x0600696E RID: 26990 RVA: 0x001DAC24 File Offset: 0x001D8E24
		[ProtoMember(2, IsRequired = true, Name = "Room", DataFormat = DataFormat.Default)]
		public ProTeamRoom Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				this._Room = value;
			}
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x001DAC30 File Offset: 0x001D8E30
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x001DAC40 File Offset: 0x001D8E40
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

		// Token: 0x06006971 RID: 26993 RVA: 0x001DAD0C File Offset: 0x001D8F0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomJoinAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005139 RID: 20793
		private int _Result;

		// Token: 0x0400513A RID: 20794
		private ProTeamRoom _Room;

		// Token: 0x0400513B RID: 20795
		private IExtension extensionObject;

		// Token: 0x0400513C RID: 20796
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400513D RID: 20797
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400513E RID: 20798
		private LuaFunction m_ctor_hotfix;
	}
}
