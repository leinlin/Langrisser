using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067F RID: 1663
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBusinessCardStatisticalData")]
	[Serializable]
	public class ProBusinessCardStatisticalData : IExtensible
	{
		// Token: 0x06005A96 RID: 23190 RVA: 0x001A08A4 File Offset: 0x0019EAA4
		public ProBusinessCardStatisticalData()
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

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06005A97 RID: 23191 RVA: 0x001A090C File Offset: 0x0019EB0C
		// (set) Token: 0x06005A98 RID: 23192 RVA: 0x001A0914 File Offset: 0x0019EB14
		[ProtoMember(1, IsRequired = true, Name = "MostSkilledHeroId", DataFormat = DataFormat.TwosComplement)]
		public int MostSkilledHeroId
		{
			get
			{
				return this._MostSkilledHeroId;
			}
			set
			{
				this._MostSkilledHeroId = value;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x001A0920 File Offset: 0x0019EB20
		// (set) Token: 0x06005A9A RID: 23194 RVA: 0x001A0928 File Offset: 0x0019EB28
		[ProtoMember(2, IsRequired = true, Name = "HeroTotalPower", DataFormat = DataFormat.TwosComplement)]
		public int HeroTotalPower
		{
			get
			{
				return this._HeroTotalPower;
			}
			set
			{
				this._HeroTotalPower = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x001A0934 File Offset: 0x0019EB34
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x001A093C File Offset: 0x0019EB3C
		[ProtoMember(3, IsRequired = true, Name = "AchievementMissionNums", DataFormat = DataFormat.TwosComplement)]
		public int AchievementMissionNums
		{
			get
			{
				return this._AchievementMissionNums;
			}
			set
			{
				this._AchievementMissionNums = value;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x001A0948 File Offset: 0x0019EB48
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x001A0950 File Offset: 0x0019EB50
		[ProtoMember(4, IsRequired = true, Name = "MasterJobNums", DataFormat = DataFormat.TwosComplement)]
		public int MasterJobNums
		{
			get
			{
				return this._MasterJobNums;
			}
			set
			{
				this._MasterJobNums = value;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x001A095C File Offset: 0x0019EB5C
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x001A0964 File Offset: 0x0019EB64
		[ProtoMember(5, IsRequired = true, Name = "RiftAchievementNums", DataFormat = DataFormat.TwosComplement)]
		public int RiftAchievementNums
		{
			get
			{
				return this._RiftAchievementNums;
			}
			set
			{
				this._RiftAchievementNums = value;
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06005AA1 RID: 23201 RVA: 0x001A0970 File Offset: 0x0019EB70
		// (set) Token: 0x06005AA2 RID: 23202 RVA: 0x001A0978 File Offset: 0x0019EB78
		[ProtoMember(6, IsRequired = true, Name = "ChooseLevelAchievementNums", DataFormat = DataFormat.TwosComplement)]
		public int ChooseLevelAchievementNums
		{
			get
			{
				return this._ChooseLevelAchievementNums;
			}
			set
			{
				this._ChooseLevelAchievementNums = value;
			}
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x001A0984 File Offset: 0x0019EB84
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x001A0994 File Offset: 0x0019EB94
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

		// Token: 0x06005AA5 RID: 23205 RVA: 0x001A0A60 File Offset: 0x0019EC60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBusinessCardStatisticalData));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043DA RID: 17370
		private int _MostSkilledHeroId;

		// Token: 0x040043DB RID: 17371
		private int _HeroTotalPower;

		// Token: 0x040043DC RID: 17372
		private int _AchievementMissionNums;

		// Token: 0x040043DD RID: 17373
		private int _MasterJobNums;

		// Token: 0x040043DE RID: 17374
		private int _RiftAchievementNums;

		// Token: 0x040043DF RID: 17375
		private int _ChooseLevelAchievementNums;

		// Token: 0x040043E0 RID: 17376
		private IExtension extensionObject;

		// Token: 0x040043E1 RID: 17377
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043E2 RID: 17378
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043E3 RID: 17379
		private LuaFunction m_ctor_hotfix;
	}
}
