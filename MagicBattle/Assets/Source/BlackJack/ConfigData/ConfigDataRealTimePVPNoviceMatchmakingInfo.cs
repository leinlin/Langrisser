using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200027B RID: 635
	[ProtoContract(Name = "ConfigDataRealTimePVPNoviceMatchmakingInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRealTimePVPNoviceMatchmakingInfo : IExtensible
	{
		// Token: 0x060028C8 RID: 10440 RVA: 0x000AEAC8 File Offset: 0x000ACCC8
		public ConfigDataRealTimePVPNoviceMatchmakingInfo()
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000AEB30 File Offset: 0x000ACD30
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x000AEB38 File Offset: 0x000ACD38
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x000AEB44 File Offset: 0x000ACD44
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x000AEB4C File Offset: 0x000ACD4C
		[ProtoMember(3, IsRequired = true, Name = "Battles", DataFormat = DataFormat.TwosComplement)]
		public int Battles
		{
			get
			{
				return this._Battles;
			}
			set
			{
				this._Battles = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x000AEB58 File Offset: 0x000ACD58
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x000AEB60 File Offset: 0x000ACD60
		[ProtoMember(4, IsRequired = true, Name = "LevelAdjustment", DataFormat = DataFormat.TwosComplement)]
		public int LevelAdjustment
		{
			get
			{
				return this._LevelAdjustment;
			}
			set
			{
				this._LevelAdjustment = value;
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000AEB6C File Offset: 0x000ACD6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000AEB7C File Offset: 0x000ACD7C
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

		// Token: 0x060028D1 RID: 10449 RVA: 0x000AEC48 File Offset: 0x000ACE48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPNoviceMatchmakingInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001912 RID: 6418
		private int _ID;

		// Token: 0x04001913 RID: 6419
		private int _Battles;

		// Token: 0x04001914 RID: 6420
		private int _LevelAdjustment;

		// Token: 0x04001915 RID: 6421
		private IExtension extensionObject;

		// Token: 0x04001916 RID: 6422
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001917 RID: 6423
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001918 RID: 6424
		private LuaFunction m_ctor_hotfix;
	}
}
