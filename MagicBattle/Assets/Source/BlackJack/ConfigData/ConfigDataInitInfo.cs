using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000256 RID: 598
	[ProtoContract(Name = "ConfigDataInitInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataInitInfo : IExtensible
	{
		// Token: 0x0600257C RID: 9596 RVA: 0x000A8F90 File Offset: 0x000A7190
		public ConfigDataInitInfo()
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

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x000A900C File Offset: 0x000A720C
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x000A9014 File Offset: 0x000A7214
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

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000A9020 File Offset: 0x000A7220
		[ProtoMember(3, Name = "Heros_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Heros_ID
		{
			get
			{
				return this._Heros_ID;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000A9028 File Offset: 0x000A7228
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x000A9030 File Offset: 0x000A7230
		[ProtoMember(4, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x000A903C File Offset: 0x000A723C
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x000A9044 File Offset: 0x000A7244
		[ProtoMember(5, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public int Crystal
		{
			get
			{
				return this._Crystal;
			}
			set
			{
				this._Crystal = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000A9050 File Offset: 0x000A7250
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x000A9058 File Offset: 0x000A7258
		[ProtoMember(6, IsRequired = true, Name = "Waypoint_ID", DataFormat = DataFormat.TwosComplement)]
		public int Waypoint_ID
		{
			get
			{
				return this._Waypoint_ID;
			}
			set
			{
				this._Waypoint_ID = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000A9064 File Offset: 0x000A7264
		[ProtoMember(7, Name = "BagItem", DataFormat = DataFormat.Default)]
		public List<Goods> BagItem
		{
			get
			{
				return this._BagItem;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000A906C File Offset: 0x000A726C
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x000A9074 File Offset: 0x000A7274
		[ProtoMember(8, IsRequired = true, Name = "ArenaTicket", DataFormat = DataFormat.TwosComplement)]
		public int ArenaTicket
		{
			get
			{
				return this._ArenaTicket;
			}
			set
			{
				this._ArenaTicket = value;
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000A9080 File Offset: 0x000A7280
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000A9090 File Offset: 0x000A7290
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

		// Token: 0x0600258B RID: 9611 RVA: 0x000A915C File Offset: 0x000A735C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataInitInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016EB RID: 5867
		private int _ID;

		// Token: 0x040016EC RID: 5868
		private readonly List<int> _Heros_ID = new List<int>();

		// Token: 0x040016ED RID: 5869
		private int _Gold;

		// Token: 0x040016EE RID: 5870
		private int _Crystal;

		// Token: 0x040016EF RID: 5871
		private int _Waypoint_ID;

		// Token: 0x040016F0 RID: 5872
		private readonly List<Goods> _BagItem = new List<Goods>();

		// Token: 0x040016F1 RID: 5873
		private int _ArenaTicket;

		// Token: 0x040016F2 RID: 5874
		private IExtension extensionObject;

		// Token: 0x040016F3 RID: 5875
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016F4 RID: 5876
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016F5 RID: 5877
		private LuaFunction m_ctor_hotfix;
	}
}
