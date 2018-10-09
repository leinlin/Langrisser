using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AD RID: 1709
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProTeamRoomPlayerPositionInfo")]
	[Serializable]
	public class ProTeamRoomPlayerPositionInfo : IExtensible
	{
		// Token: 0x06005CA2 RID: 23714 RVA: 0x001A63E8 File Offset: 0x001A45E8
		public ProTeamRoomPlayerPositionInfo()
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

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x001A6450 File Offset: 0x001A4650
		// (set) Token: 0x06005CA4 RID: 23716 RVA: 0x001A6458 File Offset: 0x001A4658
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06005CA5 RID: 23717 RVA: 0x001A6464 File Offset: 0x001A4664
		// (set) Token: 0x06005CA6 RID: 23718 RVA: 0x001A646C File Offset: 0x001A466C
		[ProtoMember(2, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x001A6478 File Offset: 0x001A4678
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x001A6488 File Offset: 0x001A4688
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

		// Token: 0x06005CA9 RID: 23721 RVA: 0x001A6554 File Offset: 0x001A4754
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeamRoomPlayerPositionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400454B RID: 17739
		private ulong _SessionId;

		// Token: 0x0400454C RID: 17740
		private int _Position;

		// Token: 0x0400454D RID: 17741
		private IExtension extensionObject;

		// Token: 0x0400454E RID: 17742
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400454F RID: 17743
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004550 RID: 17744
		private LuaFunction m_ctor_hotfix;
	}
}
