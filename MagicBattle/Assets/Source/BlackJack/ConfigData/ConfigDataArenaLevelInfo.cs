using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FD RID: 509
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArenaLevelInfo")]
	[Serializable]
	public class ConfigDataArenaLevelInfo : IExtensible
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x0009A960 File Offset: 0x00098B60
		public ConfigDataArenaLevelInfo()
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0009A9C8 File Offset: 0x00098BC8
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x0009A9D0 File Offset: 0x00098BD0
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0009A9DC File Offset: 0x00098BDC
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0009A9E4 File Offset: 0x00098BE4
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0009A9F0 File Offset: 0x00098BF0
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0009A9F8 File Offset: 0x00098BF8
		[ProtoMember(4, IsRequired = true, Name = "UpgradePoints", DataFormat = DataFormat.TwosComplement)]
		public int UpgradePoints
		{
			get
			{
				return this._UpgradePoints;
			}
			set
			{
				this._UpgradePoints = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0009AA04 File Offset: 0x00098C04
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0009AA0C File Offset: 0x00098C0C
		[ProtoMember(5, IsRequired = true, Name = "LevelMaxPoints", DataFormat = DataFormat.TwosComplement)]
		public int LevelMaxPoints
		{
			get
			{
				return this._LevelMaxPoints;
			}
			set
			{
				this._LevelMaxPoints = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0009AA18 File Offset: 0x00098C18
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0009AA20 File Offset: 0x00098C20
		[ProtoMember(6, IsRequired = true, Name = "DowngradePoints", DataFormat = DataFormat.TwosComplement)]
		public int DowngradePoints
		{
			get
			{
				return this._DowngradePoints;
			}
			set
			{
				this._DowngradePoints = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0009AA2C File Offset: 0x00098C2C
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0009AA34 File Offset: 0x00098C34
		[ProtoMember(7, IsRequired = true, Name = "LevelRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int LevelRewardMailTemplateId
		{
			get
			{
				return this._LevelRewardMailTemplateId;
			}
			set
			{
				this._LevelRewardMailTemplateId = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0009AA40 File Offset: 0x00098C40
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0009AA48 File Offset: 0x00098C48
		[ProtoMember(8, IsRequired = true, Name = "DecreasePointsPerWeek", DataFormat = DataFormat.TwosComplement)]
		public int DecreasePointsPerWeek
		{
			get
			{
				return this._DecreasePointsPerWeek;
			}
			set
			{
				this._DecreasePointsPerWeek = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0009AA54 File Offset: 0x00098C54
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0009AA5C File Offset: 0x00098C5C
		[ProtoMember(11, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0009AA68 File Offset: 0x00098C68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0009AA78 File Offset: 0x00098C78
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

		// Token: 0x06001D5C RID: 7516 RVA: 0x0009AB44 File Offset: 0x00098D44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400117F RID: 4479
		private int _ID;

		// Token: 0x04001180 RID: 4480
		private string _Name;

		// Token: 0x04001181 RID: 4481
		private int _UpgradePoints;

		// Token: 0x04001182 RID: 4482
		private int _LevelMaxPoints;

		// Token: 0x04001183 RID: 4483
		private int _DowngradePoints;

		// Token: 0x04001184 RID: 4484
		private int _LevelRewardMailTemplateId;

		// Token: 0x04001185 RID: 4485
		private int _DecreasePointsPerWeek;

		// Token: 0x04001186 RID: 4486
		private string _Icon;

		// Token: 0x04001187 RID: 4487
		private IExtension extensionObject;

		// Token: 0x04001188 RID: 4488
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001189 RID: 4489
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400118A RID: 4490
		private LuaFunction m_ctor_hotfix;
	}
}
