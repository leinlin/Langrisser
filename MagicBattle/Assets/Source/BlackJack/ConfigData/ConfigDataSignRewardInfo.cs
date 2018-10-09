using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028A RID: 650
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSignRewardInfo")]
	[Serializable]
	public class ConfigDataSignRewardInfo : IExtensible
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x000B0FC8 File Offset: 0x000AF1C8
		public ConfigDataSignRewardInfo()
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000B103C File Offset: 0x000AF23C
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x000B1044 File Offset: 0x000AF244
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

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000B1050 File Offset: 0x000AF250
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x000B1058 File Offset: 0x000AF258
		[ProtoMember(3, IsRequired = true, Name = "Month", DataFormat = DataFormat.TwosComplement)]
		public MonthType Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				this._Month = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000B1064 File Offset: 0x000AF264
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x000B106C File Offset: 0x000AF26C
		[ProtoMember(4, IsRequired = true, Name = "Day", DataFormat = DataFormat.TwosComplement)]
		public int Day
		{
			get
			{
				return this._Day;
			}
			set
			{
				this._Day = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000B1078 File Offset: 0x000AF278
		[ProtoMember(5, Name = "Reward", DataFormat = DataFormat.Default)]
		public List<Goods> Reward
		{
			get
			{
				return this._Reward;
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000B1080 File Offset: 0x000AF280
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000B1090 File Offset: 0x000AF290
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

		// Token: 0x06002A2E RID: 10798 RVA: 0x000B115C File Offset: 0x000AF35C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSignRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019F7 RID: 6647
		private int _ID;

		// Token: 0x040019F8 RID: 6648
		private MonthType _Month;

		// Token: 0x040019F9 RID: 6649
		private int _Day;

		// Token: 0x040019FA RID: 6650
		private readonly List<Goods> _Reward = new List<Goods>();

		// Token: 0x040019FB RID: 6651
		private IExtension extensionObject;

		// Token: 0x040019FC RID: 6652
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019FD RID: 6653
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019FE RID: 6654
		private LuaFunction m_ctor_hotfix;
	}
}
