using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031A RID: 794
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroBiographyCondition")]
	[Serializable]
	public class HeroBiographyCondition : IExtensible
	{
		// Token: 0x06002F23 RID: 12067 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		public HeroBiographyCondition()
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000BBD60 File Offset: 0x000B9F60
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x000BBD68 File Offset: 0x000B9F68
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public HeroBiographyUnlockConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000BBD74 File Offset: 0x000B9F74
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000BBD7C File Offset: 0x000B9F7C
		[ProtoMember(2, IsRequired = true, Name = "Parm1", DataFormat = DataFormat.TwosComplement)]
		public int Parm1
		{
			get
			{
				return this._Parm1;
			}
			set
			{
				this._Parm1 = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000BBD88 File Offset: 0x000B9F88
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x000BBD90 File Offset: 0x000B9F90
		[ProtoMember(3, IsRequired = true, Name = "Parm2", DataFormat = DataFormat.TwosComplement)]
		public int Parm2
		{
			get
			{
				return this._Parm2;
			}
			set
			{
				this._Parm2 = value;
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000BBD9C File Offset: 0x000B9F9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000BBDAC File Offset: 0x000B9FAC
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

		// Token: 0x06002F2C RID: 12076 RVA: 0x000BBE78 File Offset: 0x000BA078
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroBiographyCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400241E RID: 9246
		private HeroBiographyUnlockConditionType _ConditionType;

		// Token: 0x0400241F RID: 9247
		private int _Parm1;

		// Token: 0x04002420 RID: 9248
		private int _Parm2;

		// Token: 0x04002421 RID: 9249
		private IExtension extensionObject;

		// Token: 0x04002422 RID: 9250
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002423 RID: 9251
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002424 RID: 9252
		private LuaFunction m_ctor_hotfix;
	}
}
