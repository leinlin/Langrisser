using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031F RID: 799
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroPerformanceUnlcokCondition")]
	[Serializable]
	public class HeroPerformanceUnlcokCondition : IExtensible
	{
		// Token: 0x06002F53 RID: 12115 RVA: 0x000BC66C File Offset: 0x000BA86C
		public HeroPerformanceUnlcokCondition()
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x000BC6D4 File Offset: 0x000BA8D4
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x000BC6DC File Offset: 0x000BA8DC
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public HeroPerformanceUnlockConditionType ConditionType
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

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x000BC6E8 File Offset: 0x000BA8E8
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x000BC6F0 File Offset: 0x000BA8F0
		[ProtoMember(2, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000BC6FC File Offset: 0x000BA8FC
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x000BC704 File Offset: 0x000BA904
		[ProtoMember(3, IsRequired = true, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public int Param2
		{
			get
			{
				return this._Param2;
			}
			set
			{
				this._Param2 = value;
			}
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000BC710 File Offset: 0x000BA910
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000BC720 File Offset: 0x000BA920
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

		// Token: 0x06002F5C RID: 12124 RVA: 0x000BC7EC File Offset: 0x000BA9EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPerformanceUnlcokCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002440 RID: 9280
		private HeroPerformanceUnlockConditionType _ConditionType;

		// Token: 0x04002441 RID: 9281
		private int _Param1;

		// Token: 0x04002442 RID: 9282
		private int _Param2;

		// Token: 0x04002443 RID: 9283
		private IExtension extensionObject;

		// Token: 0x04002444 RID: 9284
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002445 RID: 9285
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002446 RID: 9286
		private LuaFunction m_ctor_hotfix;
	}
}
