using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000268 RID: 616
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataPlayerLevelInfo")]
	[Serializable]
	public class ConfigDataPlayerLevelInfo : IExtensible
	{
		// Token: 0x06002780 RID: 10112 RVA: 0x000AC044 File Offset: 0x000AA244
		public ConfigDataPlayerLevelInfo()
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

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000AC0AC File Offset: 0x000AA2AC
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x000AC0B4 File Offset: 0x000AA2B4
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000AC0C0 File Offset: 0x000AA2C0
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x000AC0C8 File Offset: 0x000AA2C8
		[ProtoMember(3, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
		public int Exp
		{
			get
			{
				return this._Exp;
			}
			set
			{
				this._Exp = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000AC0D4 File Offset: 0x000AA2D4
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x000AC0DC File Offset: 0x000AA2DC
		[ProtoMember(4, IsRequired = true, Name = "Energy", DataFormat = DataFormat.TwosComplement)]
		public int Energy
		{
			get
			{
				return this._Energy;
			}
			set
			{
				this._Energy = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000AC0E8 File Offset: 0x000AA2E8
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x000AC0F0 File Offset: 0x000AA2F0
		[ProtoMember(5, IsRequired = true, Name = "ArenaBuffID", DataFormat = DataFormat.TwosComplement)]
		public int ArenaBuffID
		{
			get
			{
				return this._ArenaBuffID;
			}
			set
			{
				this._ArenaBuffID = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000AC0FC File Offset: 0x000AA2FC
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x000AC104 File Offset: 0x000AA304
		[ProtoMember(6, IsRequired = true, Name = "PVPBuffID", DataFormat = DataFormat.TwosComplement)]
		public int PVPBuffID
		{
			get
			{
				return this._PVPBuffID;
			}
			set
			{
				this._PVPBuffID = value;
			}
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000AC110 File Offset: 0x000AA310
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000AC120 File Offset: 0x000AA320
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

		// Token: 0x0600278D RID: 10125 RVA: 0x000AC1EC File Offset: 0x000AA3EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataPlayerLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001833 RID: 6195
		private int _ID;

		// Token: 0x04001834 RID: 6196
		private int _Exp;

		// Token: 0x04001835 RID: 6197
		private int _Energy;

		// Token: 0x04001836 RID: 6198
		private int _ArenaBuffID;

		// Token: 0x04001837 RID: 6199
		private int _PVPBuffID;

		// Token: 0x04001838 RID: 6200
		private IExtension extensionObject;

		// Token: 0x04001839 RID: 6201
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400183A RID: 6202
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400183B RID: 6203
		private LuaFunction m_ctor_hotfix;
	}
}
