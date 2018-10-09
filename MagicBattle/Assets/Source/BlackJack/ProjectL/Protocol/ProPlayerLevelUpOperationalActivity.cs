using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000663 RID: 1635
	[ProtoContract(Name = "ProPlayerLevelUpOperationalActivity")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProPlayerLevelUpOperationalActivity : IExtensible
	{
		// Token: 0x0600595F RID: 22879 RVA: 0x0019D184 File Offset: 0x0019B384
		public ProPlayerLevelUpOperationalActivity()
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x0019D1F8 File Offset: 0x0019B3F8
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x0019D200 File Offset: 0x0019B400
		[ProtoMember(1, IsRequired = true, Name = "BasicInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo BasicInfo
		{
			get
			{
				return this._BasicInfo;
			}
			set
			{
				this._BasicInfo = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x0019D20C File Offset: 0x0019B40C
		// (set) Token: 0x06005963 RID: 22883 RVA: 0x0019D214 File Offset: 0x0019B414
		[ProtoMember(2, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevel
		{
			get
			{
				return this._PlayerLevel;
			}
			set
			{
				this._PlayerLevel = value;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x0019D220 File Offset: 0x0019B420
		[ProtoMember(3, Name = "GainRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> GainRewardIndexs
		{
			get
			{
				return this._GainRewardIndexs;
			}
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x0019D228 File Offset: 0x0019B428
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x0019D238 File Offset: 0x0019B438
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

		// Token: 0x06005967 RID: 22887 RVA: 0x0019D304 File Offset: 0x0019B504
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProPlayerLevelUpOperationalActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042FF RID: 17151
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x04004300 RID: 17152
		private int _PlayerLevel;

		// Token: 0x04004301 RID: 17153
		private readonly List<int> _GainRewardIndexs = new List<int>();

		// Token: 0x04004302 RID: 17154
		private IExtension extensionObject;

		// Token: 0x04004303 RID: 17155
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004304 RID: 17156
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004305 RID: 17157
		private LuaFunction m_ctor_hotfix;
	}
}
