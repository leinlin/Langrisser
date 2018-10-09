using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062E RID: 1582
	[ProtoContract(Name = "ProChatEnterRoomInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProChatEnterRoomInfo : IExtensible
	{
		// Token: 0x060056D1 RID: 22225 RVA: 0x001965F0 File Offset: 0x001947F0
		public ProChatEnterRoomInfo()
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

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x00196658 File Offset: 0x00194858
		// (set) Token: 0x060056D3 RID: 22227 RVA: 0x00196660 File Offset: 0x00194860
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				this._RoomId = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x0019666C File Offset: 0x0019486C
		// (set) Token: 0x060056D5 RID: 22229 RVA: 0x00196674 File Offset: 0x00194874
		[ProtoMember(2, IsRequired = true, Name = "PlayerCount", DataFormat = DataFormat.TwosComplement)]
		public int PlayerCount
		{
			get
			{
				return this._PlayerCount;
			}
			set
			{
				this._PlayerCount = value;
			}
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00196680 File Offset: 0x00194880
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00196690 File Offset: 0x00194890
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

		// Token: 0x060056D8 RID: 22232 RVA: 0x0019675C File Offset: 0x0019495C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatEnterRoomInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400413A RID: 16698
		private int _RoomId;

		// Token: 0x0400413B RID: 16699
		private int _PlayerCount;

		// Token: 0x0400413C RID: 16700
		private IExtension extensionObject;

		// Token: 0x0400413D RID: 16701
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400413E RID: 16702
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400413F RID: 16703
		private LuaFunction m_ctor_hotfix;
	}
}
